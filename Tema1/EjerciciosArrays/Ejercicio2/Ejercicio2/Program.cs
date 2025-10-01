using System.Collections;

namespace Ejercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aleatorios r = new Aleatorios();
            int[] numeros = new int[10000];
            int[] contadores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = r.GenAle();
            }
            // Mas sencillo for y eso
            //arrayNumerosAleatorios[numeroAletorio-1]++
            for (int i = 0; i < numeros.Length; i++)
            {
                switch (numeros[i])
                {
                    case 1:
                        contadores[0]++;
                        break;
                    case 2:
                        contadores[1]++;
                        break;
                    case 3:
                        contadores[2]++;
                        break;
                    case 4:
                        contadores[3]++;
                        break;
                    case 5:
                        contadores[4]++;
                        break;
                    case 6:
                        contadores[5]++; 
                        break;
                    case 7:
                        contadores[6]++;
                        break;
                    case 8:
                        contadores[7]++;
                        break;
                    case 9:
                        contadores[8]++;
                        break;
                    case 10:
                        contadores[9]++;
                        break;
                }
                    
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número " + (i+1) + " : " + contadores[i]);
            }
        }
    }
}
