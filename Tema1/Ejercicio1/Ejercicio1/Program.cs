namespace Ejercicio1
{
    class Program

    {

        static void Main(string[] args)

        {

            int numero=1;
            int numeroTotal = 0;
            int positivo = 0;

            do
            {
                try

                {

                    Console.WriteLine("Introduce un numero");
                    numero = Int32.Parse(Console.ReadLine());

                    if (numero > 0) 
                    { 
                    Console.WriteLine("Numero positivo aceptado");
                        positivo++;
                        numeroTotal++;
                    }
                    if (numero < 0)
                    {
                        Console.WriteLine("Has introducido un numero negativo");
                        numeroTotal++;
                    }
                }

                catch (FormatException)

                {

                    Console.WriteLine("No has introducido un numero");

                }

            } while (numero != 0);

            Console.WriteLine("Has introducido un total de {0} y son positivos {1}", numeroTotal, positivo);
        }
    }
}
 
 