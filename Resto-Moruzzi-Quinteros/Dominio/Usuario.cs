using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public String NombreUsuario { get; set; }
        public String Contrasena { get; set; }
        public Byte Tipo { get; set; }
        public Boolean Estado { get; set; }

    }
}
