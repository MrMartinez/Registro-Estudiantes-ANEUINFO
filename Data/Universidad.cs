using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Universidad
    {
        public int Id { get; set; }
        public string Siglas { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Comentario { get; set; }

        public List<Estudiantes> Estudiantes { get; set; }

    }
}
