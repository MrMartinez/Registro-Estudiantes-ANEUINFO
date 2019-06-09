using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string Comentario { get; set; }
    }
}
