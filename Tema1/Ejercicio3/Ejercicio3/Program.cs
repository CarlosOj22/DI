namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dado;
            Random numero=new Random();
            int coincidencias = 0;
            
            for(int i = 0; i < 50; i++)
            {
                dado=numero.Next(1,7);
                if(dado == 1)
                {
                    coincidencias++;
                }
            }
            Console.WriteLine("Salio el numero 1: " + coincidencias + " veces.");
        }
    }
}
