using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ICompraDB
    { 
        bool Insert(Compra compra);
        bool Update(Compra compra, int id);
        bool Delete(int id);
        Compra SelectById(int id);
        List<Compra> GetAll();
    }
}
