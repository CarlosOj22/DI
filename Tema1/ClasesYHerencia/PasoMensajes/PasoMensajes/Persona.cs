using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoMensajes
{
    public class Persona
    {
        public string Nombre { get; set; } 
        public int Edad {  get; set; }

        public Persona(string nombre, int edad) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public override string ToString()
        {
            return "Mi nombre es " + this.Nombre + " y mi edad es " + this.Edad;
        }

        public void CambioEdad(int edad) 
        {
            this.Edad = edad;
        }

    }
}
