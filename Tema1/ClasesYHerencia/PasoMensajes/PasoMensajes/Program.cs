namespace PasoMensajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Persona persona1 = new Persona("Juan", 18);
            Persona persona2 = new Persona("Lucas", 24);
            Persona persona3 = new Persona("Pepe", 31);
            Persona persona4 = new Persona("Fidel", 15);
            Persona persona5 = new Persona("Santi", 49);*/

            Coche coche1 = new Coche("Opel", "Corsa", "Amarillo", "Juan", 23);
            /*Coche coche2 = new Coche("Suzuki", "Molk", "Rojo", persona2);
            Coche coche3 = new Coche("Porchse", "Zins", "Azul", persona3);
            Coche coche4 = new Coche("Tesla", "Mmnt", "Verde", persona4);
            Coche coche5 = new Coche("Toyota", "Montero", "Negro", persona5);*/
            Console.WriteLine(persona1.ToString());
            persona1.CambioEdad(49);
            Console.WriteLine(persona1.ToString());
            Console.WriteLine(coche1.ToString());
            coche1.CambioPropietario(persona5);
            Console.WriteLine(coche1.ToString());
            Console.ReadLine();
        }
    }
}
            