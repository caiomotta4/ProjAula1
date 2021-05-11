using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class OrcamentoDB : IOrcamentoDB
    {
        public List<Orcamento> GetAll()
        {
            string sql = Orcamento.GETALL;
            List<Orcamento> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Orcamento> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Orcamento>();

            while (returnData.Read())
            {
                var item = new Orcamento()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Inicio = returnData["inicio"].ToString(),
                    Fim = returnData["fim"].ToString(),
                    Dias = int.Parse(returnData["dias"].ToString()),
                    Descricao = returnData["descricao"].ToString(),
                    Titulo = returnData["titulo"].ToString(),
                    Modulo = returnData["modulo"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Orcamento orcamento)
        {
            bool status = false;
            string sql = string.Format(Orcamento.INSERT, orcamento.Inicio, orcamento.Fim, orcamento.Dias, orcamento.Descricao, orcamento.Titulo, orcamento.Modulo);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Orcamento SelectById(int id)
        {
            string sql = string.Format(Orcamento.GETBYID, id);
            Orcamento orcamento;

            using (var connection = new DB())
            {
                orcamento = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return orcamento;
        }

        public bool Update(Orcamento orcamento, int id)
        {
            bool status = false;
            string sql = string.Format(Orcamento.UPDATE, orcamento.Inicio, orcamento.Fim, orcamento.Dias, orcamento.Descricao, orcamento.Titulo, orcamento.Modulo, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Orcamento.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
