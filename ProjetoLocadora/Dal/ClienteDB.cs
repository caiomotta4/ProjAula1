using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClienteDB : IClienteDB
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Cliente> GetAll()
        {        
            string sql = Cliente.GETALL;
            List<Cliente> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Cliente> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Cliente>();

            while (returnData.Read())
            {
                var item = new Cliente()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Name = returnData["Name"].ToString(),
                    Telephone = returnData["Telephone"].ToString(),
                    NumeroCartao = returnData["NumeroCartao"].ToString(),
                    Validade = returnData["Validade"].ToString(),
                    CodSeguranca = returnData["CodSeguranca"].ToString(),
                    Endereco = returnData["Endereco"].ToString(),
                    Cidade = returnData["Cidade"].ToString(),
                    Pais = returnData["Pais"].ToString(),
                    CEP = returnData["CEP"].ToString()
                };
                lst.Add(item);
            }
            return lst;
        }



        public bool Insert(Cliente cliente)
        {
            bool status = false;
            string sql = string.Format(Cliente.INSERT, cliente.Name, cliente.Telephone, cliente.NumeroCartao, cliente.Validade, cliente.CodSeguranca, cliente.Endereco, cliente.Cidade, cliente.Pais, cliente.CEP);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;

        }



        public Cliente SelectById(int id)
        {
            throw new NotImplementedException();
        }



        public bool Update(Cliente cliente, int id)
        {
            throw new NotImplementedException();
        }
    }
}
