namespace Ejercicio5Optativo
{
    public class App
    {
        public static void Main(string[] args)
        {
            int cantidadBoletos = 100;
            Boletos[] boletos=new Boletos[cantidadBoletos];
            bool boletosRepetidos = false;
            //Creamos 100 objetos boletos con números diferentes
            //Primero les doy numeros aleatorios a los 100, luego repito si alguno coincide entero
            for (int i = 0; i < boletos.Length; i++)
            {
                boletos[i] = new Boletos();
                boletos[i].CreacionNumerosBoleto();
            }

            for (int i = 0; i < cantidadBoletos; i++)
            {
                for (int j = 0; j < cantidadBoletos-1; j++)
                {
                    do
                    {
                        if (boletos[j].Equals(boletos[j + 1]))
                        {
                            boletosRepetidos = true;
                            boletos[j].CreacionNumerosBoleto();

                        }
                        else
                        {
                            boletosRepetidos = false;
                        }
                        
                    }
                    while (boletosRepetidos);
                }
            }

            //Imprimo los bolets

            for(int i = 0;i < boletos.Length; i++)
            {
                Console.WriteLine(boletos[i].ToString());
            }
        }
    }
}