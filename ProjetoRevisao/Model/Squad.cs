using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Squad
    {
        #region Propriedades
        public int Id { get; set; }
        public string Name { get; set; }
        public int QtdPessoas { get; set; }

        public const string INSERT = "INSERT INTO TB_SQUAD (name, qtdPessoas) VALUES ('{0}', {1})";
        public const string GETALL = "SELECT id, name, qtdPessoas FROM TB_SQUAD";
        public const string UPDATE = "UPDATE TB_SQUAD SET name = '{0}', qtdPessoas = {1} WHERE id = {2}";
        public const string DELETE = "DELETE FROM TB_SQUAD WHERE id = {0}";
        public const string GETBYID = "SELECT id, name, qtdPessoas FROM TB_SQUAD WHERE id = {0}";
        #endregion
    }
}
