using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Profesor:Estudiantes
    {
        public int IdProfesor { get; set; }
        
        public int IdCurso { get; set; }
    }
}
