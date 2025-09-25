using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Vehiculo
    {
        protected string color;
        private int personas;
        public int Ruedas { get; set; }
        public int MaxPersonas {
            get => personas;
            //Lamdba o asi, en el examen puede pedir diferentes maneras de hacerlo, de estas cuatro:
            //{
            //return personas
            //}
            set => personas = value;
            //{
            //personas = value;
            //}
        }

        public Vehiculo()
        {
            color = "Azul";
            personas = 3;
            Ruedas = 4;
        }
        public Vehiculo(string color, int ruedas, int pers)
        {
            this.color = color;
            Ruedas = ruedas;
            personas = pers;
            
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public virtual void mostrar()
        {
            Console.WriteLine("Tiene {0} ruedas, puede llevar a {1} personas y es de color {2} ", Ruedas, personas, color);
        }
        public override bool Equals(object obj)
        {
            //Importante hacer un castinf de objeto a el objeto en si
            Vehiculo veh=(Vehiculo)obj; 
            if(veh == null) return false;
            if(this.color == veh.color)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

    }
}

