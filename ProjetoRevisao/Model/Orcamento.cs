using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orcamento
    {
        #region Propriedades
        public int Id { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public int Dias { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public string Modulo { get; set; }

        public const string INSERT = "INSERT INTO TB_SQUAD (inicio, fim, dias, descricao, titulo, modulo) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}')";
        public const string GETALL = "SELECT id, inicio, fim, dias, descricao, titulo, modulo FROM TB_SQUAD";
        public const string UPDATE = "UPDATE TB_SQUAD SET inicio = '{0}', fim = '{1}', dias = {2}, descricao = '{3}', titulo = '{4}', modulo = '{5}' WHERE id = {6}";
        public const string DELETE = "DELETE FROM TB_SQUAD WHERE id = {0}";
        public const string GETBYID = "SELECT id, inicio, fim, dias, descricao, titulo, modulo FROM TB_SQUAD WHERE id = {0}";
        #endregion
    }
}
