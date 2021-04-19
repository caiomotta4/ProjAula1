using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        #region Propriedades

        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string NumeroCartao { get; set; }
        public string Validade { get; set; }
        public string CodSeguranca { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }

        public const string INSERT = "INSERT INTO TB_Cliente (Name, Telephone, NumeroCartao, Validade, CodSeguranca, Endereco, Cidade, Pais, CEP) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";
        public const string GETALL = "SELECT id, Name, Telephone, NumeroCartao, Validade, CodSeguranca, Endereco, Cidade, Pais, CEP FROM TB_Cliente";
      
        #endregion
    }
}
