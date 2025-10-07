namespace Ejercicio1Colas_CarlosOjeda_DI
{
    public class Program
    {
        static void Main(string[] args)
        {
            int precioTotal = 0;
            //Generamos la cola de personas
            Queue<Persona> colaPers = new Queue<Persona>();
            //Generamos objetos personas entre 0,50 para la cola
            for (int i = 0; i < generarNumeroAleatorio(0, 51); i++)
            {
                /*Encolamos tantas personas como el numero aleatorio salga
                llamando al constructor y pasandole una edad aleatoria entre 5 y 60*/
                colaPers.Enqueue(new Persona(generarNumeroAleatorio(5, 61)));
            }
            /*Recorremos la cola, hasta el tamaño que tenga al final con count, y 
            chequemos la edad de cada persona con su metodo getEdad, y he elegido un swithc
            en este caso para ir sumando cantidades*/

            /*No hace falta que lo pongamos dentro de un do while asta que cola este vacia o colapers count 
            sea 0, ya que con el for lo hara igual*/

            //Y una vez que una persona paga (se suma su cantidad a cantidadTotal, esta sale, con desqueu).

            //Esto es FIFO, ya que Dequeue devuelve la primera persona que metimos con queue y asi en orden.

            /* Me daba error con esto for(int i = 0;i < colaPers.Count; i++), hasta que me e dado cuenta
             * que se va incrementando la i a la vez que se decrementa count, asi que procesaba la mitad de 
             * persona, me di cuenta al ver que imprimiendo cuantos quedaban al final con count no era 0.
             * Tengo la opcion de guardar el count antes y asi no chequearlo en cada iteraciion, que sea fijo
             * O hacerlo con un while(count>0), asi lo hara hasta que no quede nadie.*/

            int cantidadPersonasEnCola = colaPers.Count;

            for (int i = 0; i < cantidadPersonasEnCola; i++)
            {
                Persona personaDesencolada = colaPers.Dequeue();
                int edadChequeo = personaDesencolada.getEdad();

                switch (edadChequeo)
                {
                    //Mayor que 5 y menor de 10
                    case >= 5 and <= 10:
                        Console.WriteLine("Persona de " + personaDesencolada.getEdad() + " años, paga: 3EUR");
                        precioTotal += 3;
                        break;
                    //Mayor que 11 y menor de 17
                    case >= 11 and <= 17:
                        Console.WriteLine("Persona de " + personaDesencolada.getEdad() + " años, paga: 5EUR");
                        precioTotal += 5;
                        break;
                    //Mayor que 18
                    case >= 18:
                        Console.WriteLine("Persona de " + personaDesencolada.getEdad() + " años, paga: 7EUR");
                        precioTotal += 7;
                        break;

                    default:
                        Console.WriteLine("Error en la edad de la persona");
                        break;

                }
            }
            //Imprimo total recaudado
            Console.WriteLine("Precio Total Recaudado: " + precioTotal + " Euros");
            //Pongo comprobacion de cola vacia 
            Console.WriteLine("Total de personas Restantes en cola: " + colaPers.Count());
        }
        public static int generarNumeroAleatorio(int minimo, int maximo)
        {
            Random rd = new Random();
            return rd.Next(minimo, maximo);
        }
    }
}
