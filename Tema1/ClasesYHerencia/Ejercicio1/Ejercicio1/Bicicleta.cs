using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Bicicleta : Vehiculo
    {
        private string modalidad = string.Empty;
        public string disciplina
        {
            get
            {
                return modalidad;
            }
            set
            {
                if (value == "carretera" || value == "montaña")
                {
                    modalidad = value;
                }
            }
        }

        public override void mostrar()
        {
            //Console.WriteLine(color)
            //Se puede acceder a color poruqe fue declarada como protected
            //Consoloe.WriteLine(personas)
            //No se puede acceder porque en la clase padre fue definida como private
            base.mostrar();
            if (modalidad != string.Empty)
            {
                Console.WriteLine("La bicicleta es de: " + disciplina);
            }
        }
    }
}

//PREGUNTARLE SINTAXIS DE ATRIBUTOS PROPIEDADES QUE QUIERE QUE PONGAMOS COMO REGLA PARA TODOS

