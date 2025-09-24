namespace Ejercicio5ConObjeto
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Introducie un numero para ver si es multiplo de 5");
                int numero;
                MultiploCinco m5=new MultiploCinco();
                try
                {
                    numero = Int32.Parse(Console.ReadLine());
                    if (m5.EsMultiploCinco(numero))
                    {
                        Console.WriteLine(numero + " es multiplo de 5.");
                    }
                    else
                    {
                        Console.WriteLine(numero + " no es multiplo de 5.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No has introducido un numero");
                }
            }
        }
    }
