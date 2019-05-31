using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estudiantes
    {
        [Key]
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaIngreso { get; set; }
        public char Sexo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Comentario { get; set; }
        public byte Foto { get; set; }
    }
    
}
