namespace Ejercicio5Pilas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack <Informe> pilaInformes = new Stack<Informe>();
            Random rd = new Random();

            //Hago variable contador de codigos para no tener problemas con el codigo
            int contadorCodigo = 1;
            //Rellenamos la pila con informes de codigo 1 a 10, y con random entre 0 y 2 para las tareas 
            for (int i = 0; i < 10; i++) 
            {   
                pilaInformes.Push(new Informe(contadorCodigo, rd.Next(0, 3)));
                contadorCodigo++;
            }
            //Sacamos 3 informes
            for (int i = 0; i < 3; i++) 
            { 
                Informe informeSacado = pilaInformes.Pop();
                Console.WriteLine("Se ha sacado este informe: ");
                Console.WriteLine(informeSacado.ToString());
                contadorCodigo--;
            }

            //Agregamos 5 informes
            for(int i = 0;i < 5; i++)
            {
                pilaInformes.Push(new Informe(contadorCodigo,rd.Next(0,3)));
                contadorCodigo++;
            }
            //Sacamos todos los informes, dado que ahora no nos indican numero a sacar, lo hacemos con while (mas correcto)
            while(pilaInformes.Count > 0)
            {
                Console.WriteLine(pilaInformes.Pop().ToString());
            }
            //Comprobacion
            Console.WriteLine("Quedan un total de: " + pilaInformes.Count + " informes en la pila.");
            
        }
    }
}
