using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoWeather.Servicios
{
    public class Clima
    {
        //METODO OBTENER TIEMPO_LOCALIDAD (LAT Y LONG)
        public Clima()
        {

        }

        public async Task<Modelos.TiempoLocalidad> ObtenerDatosClimaticos(string lat, string lon)
        {
            Modelos.TiempoLocalidad tiempoLocalidad=null;
            JsonDocument jsonRespuesta;

            var direccion = new Uri("https://api.openweathermap.org/data/2.5/");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {   

                //No se necesita
                //httpClient.DefaultRequestHeaders.Add("User-Agent", "ProyectoWeather/1.0");
                string consulta = $"weather?lat={lat}&lon={lon}&appid=27e1bbd09b02a6389f45a89e1dcdf4ab";
                try
                {
                    using (var response = await httpClient.GetAsync(consulta))
                    {
                        string respuesta = await response.Content.ReadAsStringAsync();
                        jsonRespuesta = JsonDocument.Parse(respuesta);

                        //Vamos separando los bloques de objetos que nos da
                        var clima = jsonRespuesta.RootElement.GetProperty("weather")[0];
                        var principal = jsonRespuesta.RootElement.GetProperty("main");
                        var viento = jsonRespuesta.RootElement.GetProperty("wind");
                       
                            tiempoLocalidad = new Modelos.TiempoLocalidad(clima.GetProperty("description").ToString(),
                                clima.GetProperty("icon").ToString(),
                                principal.GetProperty("temp").ToString(),
                                viento.GetProperty("speed").ToString());


                        return tiempoLocalidad;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
