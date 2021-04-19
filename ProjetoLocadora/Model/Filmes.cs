using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Filmes
    {
        #region Propriedades

        public int Id { get; set; }
        public string NomeFilme { get; set; }
        public string GeneFilme { get; set; }
        public string DiretorFilme { get; set; }
        public string SinopseFilme { get; set; }
        public string Preco { get; set; }
        

        public const string INSERT = "INSERT INTO TB_Filmes (NomeFilme, GeneFilme, DiretorFilme, SinopseFilme, Preco) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
        public const string GETALL = "SELECT id, NomeFilme, GeneFilme, DiretorFilme, SinopseFilme, Preco FROM TB_Filmes";
        
    
        #endregion
    }
}