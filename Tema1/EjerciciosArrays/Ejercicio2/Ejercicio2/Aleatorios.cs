using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Aleatorios
    {
        Random rd= new Random();
        public int GenAle()
        {
            return rd.Next(1,11);
        }
    }
}
