namespace EjerciciosArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CLASES Y METODOS LA PRIMERA MAYUSCULA, ATRIBUTOS PRIMERA MINUSCULA, PROPIEDAD PRIMERA MAYUSCULA
            int[] numeros = new int[20];

            //Rellenamos el array
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Aleatorio.GenerarNumero();
            }
            //Lo recorremos para imprimirlo
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
