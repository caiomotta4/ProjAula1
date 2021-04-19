using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IFilmeDB
    {
        bool Insert(Filmes filmes);
        bool Update(Filmes filmes, int id);
        bool Delete(int id);
        Filmes SelectById(int id);
        List<Filmes> GetAll();
    }
}
