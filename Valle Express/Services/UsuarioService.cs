using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Valle_Express.Models;
using Valle_Express.Views;
using System.Net.Http.Json;

namespace Valle_Express.Services
{
    internal class UsuarioService
    {
        HttpClient HttpClient { get; set; }

        public UsuarioService()
        {
#if ANDROID
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    (message, cert, chain, errors) => true
            };

            HttpClient = new HttpClient(handler);
#else
    HttpClient = new HttpClient();
#endif
        }
        public async Task<List<Usuario>> GetUsuarios()
        {
            try
            {
                var url = "http://192.168.1.145:5034/api/Usuarios";
                var usuarios = await HttpClient.GetFromJsonAsync<List<Usuario>>(url);
                return usuarios ?? new List<Usuario>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;

            }
        }
        public async Task<Usuario?> InsertarUsuario(Usuario usuario)
        {
            var url = "https://192.168.1.145:7133/api/Usuarios";
            var response = await HttpClient.PostAsJsonAsync(url, usuario);

            if (!response.IsSuccessStatusCode)
            {
                await Shell.Current.DisplayAlert("Error de registro","Favor de Llenar los datos/ ingresar datos validos","OK");
                return null;
            }

            // Leer el JSON que devuelve el POST
            var usuarioCreado = await response.Content.ReadFromJsonAsync<Usuario>();

            return usuarioCreado;
        }
    }
}
