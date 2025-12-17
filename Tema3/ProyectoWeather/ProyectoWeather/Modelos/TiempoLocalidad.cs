using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeather.Modelos
{
    public class TiempoLocalidad
    {


        public string descripcion {  get; set; }
        //ES UN STRING PERO PARA OBTENER LA IMAGEN HTTPS://OPENWEATHERMAP:ORG/img/wn/10d@4x.png 
        //SUSTITUYENDO EL ICONO QUE DEVUELVA LA CONSULTA POR ESE NUMERO 10d
        public string icono { get; set; }
        public string temperatura { get; set; }
        public string velocidadViento { get; set; }

        public TiempoLocalidad(string descripcion, string icono, string temperatura, string velocidadViento)
        {
            this.descripcion = descripcion;
            this.icono = icono;
            this.temperatura = temperatura;
            this.velocidadViento = velocidadViento;
        }

    }
}
