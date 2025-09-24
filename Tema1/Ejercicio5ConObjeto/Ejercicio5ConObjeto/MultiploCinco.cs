using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5ConObjeto
{
    internal class MultiploCinco
    {
        public bool EsMultiploCinco(int n)
        {
            if ((n % 5) != 0) return false;
            else return true;
        }
    }
}
