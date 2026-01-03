using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valle_Express.Dto_s
{
    internal class PutUsuarioDto
    {
        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioApellido { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioHash { get; set; }
        public string UsuarioCelular { get; set; }
        public string UsuarioPerfil { get; set; }
    }
}
