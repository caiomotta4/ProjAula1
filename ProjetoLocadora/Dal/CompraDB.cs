using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CompraDB
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Compra> GetAll()
        {
            string sql = Compra.GETALL;
            List<Compra> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Compra> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Compra>();

            while (returnData.Read())
            {
                var item = new Compra()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    IDFilme = returnData["IDFilme"].ToString(),
                    NomeF = returnData["NomeF"].ToString(),
                    IDCliente = returnData["IDCliente"].ToString(),
                    NomeC = returnData["NomeC"].ToString()
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Compra compra)
        {
            bool status = false;
            string sql = string.Format(Compra.INSERT, compra.IDFilme, compra.NomeF, compra.IDCliente, compra.NomeC); 
            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Compra SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Compra compra, int id)
        {
            throw new NotImplementedException();
        }
    }
}
