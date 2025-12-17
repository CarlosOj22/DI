using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeather.Modelos
{
    public class Localidad
    {
        //Mayusucula y public por que es propiedad
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Nombre { get; set; }
        public string TipoLocalidad { get; set; }
        public string Detalle { get; set; }

        public Localidad(string lat, string lon, string n, string tl, string d)
        {
            Latitud = lat;
            Longitud = lon;
            Nombre = n;
            TipoLocalidad = tl;
            Detalle = d;
        }

        public override string ToString()
        {
            return Detalle;

        }
    }
}
