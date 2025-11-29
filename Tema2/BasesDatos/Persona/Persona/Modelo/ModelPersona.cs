using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Modelo
{
    public class ModelPersona
    {
        public string Id { get; set; }
        public string Nombre { get; set; } //Propiedad
        public string Apellidos { get; set; } //Propiedad
     
        public ModelPersona(string i,string n, string a) 
        {
            Id = i;
            this.Nombre = n;
            this.Apellidos = a;
        }
    }
}
