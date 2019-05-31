using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Cursos
    {
        public int Id { get; set; }
        public int Profesor { get; set; }
        public int Estudiante { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }
    }
}
