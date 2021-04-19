using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FilmesDB : IFilmeDB
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Filmes> GetAll()
        {
            string sql = Filmes.GETALL;
            List<Filmes> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Filmes> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Filmes>();

            while (returnData.Read())
            {
                var item = new Filmes()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    NomeFilme = returnData["NomeFilme"].ToString(),
                    GeneFilme = returnData["GeneFilme"].ToString(),
                    DiretorFilme = returnData["DiretorFilme"].ToString(),
                    SinopseFilme = returnData["SinopseFilme"].ToString(),
                    Preco = returnData["Preco"].ToString()

                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Filmes filmes)
        {
            bool status = false;
            string sql = string.Format(Filmes.INSERT, filmes.NomeFilme, filmes.GeneFilme, filmes.DiretorFilme, filmes.SinopseFilme, filmes.Preco);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Update(Filmes filmes, int id)
        {
            throw new NotImplementedException();
        }

        public Filmes SelectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
