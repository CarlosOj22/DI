namespace Ejercicio4Colas
{
    public class Program
    {   
        public static int generarNumeroAleatorio(int minimo,int maximo)
        {   
            Random rand = new Random();
            return rand.Next(minimo,maximo);
        }
        static void Main(string[] args)
        {   
            Queue<Producto> colaProductos = new Queue<Producto>();
            double precioTotal = 0.00d;

            //Encolamos entre 1 y 8 productos con un Random
            for (int i = 0; i < generarNumeroAleatorio(1,9); i++) 
            { 
                colaProductos.Enqueue(new Producto(generarNumeroAleatorio(1,11),
                    ((double)generarNumeroAleatorio(100,5001)/100)));
            }
            int numProduc = 1;
            //Calculamos el precio total desencolandolos y guardando su precio
            Console.WriteLine("**************Cantidad********Precio***********Total");
            while (colaProductos.Count > 0)
            {
                Producto productoDesencolado = colaProductos.Dequeue();
                Console.WriteLine("Producto " + numProduc + " : \t" + productoDesencolado.getCantidad()
                    + "\t\t" + productoDesencolado.getPrecio() + "\t\t" + $"{productoDesencolado.precioFinal():F2}" );
                precioTotal = precioTotal + productoDesencolado.precioFinal();
                numProduc++;
            }
            Console.WriteLine("Precio Total: " + precioTotal +  " Euros");
        }
    }
}
