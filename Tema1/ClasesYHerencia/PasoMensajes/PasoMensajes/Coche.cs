using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoMensajes
{
    public class Coche
    {   
        //ESTO NO SON ATRIBUTOS SON PROPIEDADES (SOLO CAMPO ATRIBUTO, CON ALGO DE LOGICA O GET SET PROPIEDADES)
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Color { get; set; }
        public Persona Propietario { get; set; }
        /*public Coche (string marca, string  modelo, string color, Persona propietario)
        {
            this.Marca = marca;
            this.Modelo = modelo;  
            this.Color = color;
            Propietario = propietario;
        }*/

        public Coche(string marca, string modelo, string color, string nombre, int edad)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            Propietario= new Persona(nombre,edad);
        }
        public override string ToString()
        {
            return "Soy " + this.Propietario.Nombre+ " y mi coche es un " + this.Marca + " " + this.Modelo;
        }

        public void CambioPropietario(Persona propietarioNuevo)
        {
            this.Propietario=propietarioNuevo;
        }

    }
}
 