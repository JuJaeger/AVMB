using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.DataModels
{
    public class Curso
    {
        public int Id { get; set; }
        public string curso { get; set; }
        public virtual Aluno aluno { get; set; }
    }
}
