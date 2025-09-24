namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int anterior=0;
            String cadena = "";
            for(int i=1; i < 16; i++)
            {   
                //Ir concatenando valores
                cadena = cadena + i;
                Console.WriteLine(cadena);
            }
        }
    }
}
