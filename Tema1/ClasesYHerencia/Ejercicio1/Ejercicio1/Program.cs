namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo transporte = new Vehiculo();
            Vehiculo v1= new Vehiculo("Amarillo",4,4);
            Vehiculo v2 = new Vehiculo("Rojo", 4, 4);
            Vehiculo v3 = new Vehiculo("Amarillo", 4, 4);
            transporte.setColor("Amarillo");
            transporte.Ruedas = 4;
            transporte.MaxPersonas = 4;
            transporte.mostrar();
            if (v1.Equals(v2))
            {
                Console.WriteLine("V1 es igual a V2");
            }
            else
            {
                Console.WriteLine("V1 no es igual a V2");
            }
            if (v1.Equals(v3))
            {
                Console.WriteLine("V1 es igual a V3");
            }
            else
            {
                Console.WriteLine("V1 no es igual a V2");
            }
        }
    }
    }
