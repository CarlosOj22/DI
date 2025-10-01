using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    public class Aleatorio
    {   
        private static Random rdm = new Random();
        public static int GenerarNumero()
        {
            return rdm.Next(1,51);
        }
    }
}
