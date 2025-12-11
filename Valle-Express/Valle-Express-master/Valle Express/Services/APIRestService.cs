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
    internal class APIRestService
    {
        HttpClient HttpClient { get; set; }

        public APIRestService()
        {
            HttpClient = new HttpClient();
        }
        public async Task<List<RegistroModel>> GetUsuarios()
        {
            try
            {
                var url = "https://localhost:7133/api/Usuarios";
                var usuarios = await HttpClient.GetFromJsonAsync<List<RegistroModel>>(url);
                return usuarios ?? new List<RegistroModel>();
            }
            catch
            {
                return new List<RegistroModel>();
            }
        }
        public async Task<RegistroModel?> InsertarUsuario(RegistroModel usuario)
        {
            var url = "https://localhost:7133/api/Usuarios";
            var response = await HttpClient.PostAsJsonAsync(url, usuario);

            if (!response.IsSuccessStatusCode)
            {
                await Shell.Current.DisplayAlert("Error de registro","Favor de Llenar los datos/ ingresar datos validos","OK");
                return null;
            }

            // Leer el JSON que devuelve el POST
            var usuarioCreado = await response.Content.ReadFromJsonAsync<RegistroModel>();

            return usuarioCreado;
        }
    }
}
