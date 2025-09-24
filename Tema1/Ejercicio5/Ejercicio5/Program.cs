namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducie un numero para ver si es multiplo de 5");
            int numero;
            try
            {
                numero=Int32.Parse(Console.ReadLine());
                if (MultiploCinco.EsMultiplo5(numero))
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
