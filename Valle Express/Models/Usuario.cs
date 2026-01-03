using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valle_Express.Models
{
    internal class Usuario
    {
        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioApellido { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioHash { get; set; }
        public string UsuarioCelular { get; set; }
        public string UsuarioPerfil { get; set; }
        public DateTime UsuarioRegistro { get; set; }
    }
}
