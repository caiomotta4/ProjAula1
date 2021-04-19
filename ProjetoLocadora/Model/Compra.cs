using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Compra
    {
        #region Propriedades
        public int Id { get; set; }
        public string IDFilme { get; set; }
        public string NomeF { get; set; }
        public string IDCliente { get; set; }
        public string NomeC { get; set; }

        public const string INSERT = "INSERT INTO TB_Compra (IDFilme, NomeF, IDCliente, NomeC) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT id, IDFilme, NomeF, IDCliente, NomeC FROM TB_Compra";
        public const string GETBYID = "SELECT id, IDFilme, NomeF, IDCliente, NomeC FROM TB_Compra WHERE id = {0}";
        public const string GETBYID_Cliente = "SELECT id, IDFilme, NomeF, IDCliente, NomeC FROM TB_Compra WHERE id = {0}";
        public const string GETBYID_Filmes = "SELECT id, IDFilme, NomeF, IDCliente, NomeC FROM TB_Compra WHERE id = {0}";
        #endregion
    }
}
