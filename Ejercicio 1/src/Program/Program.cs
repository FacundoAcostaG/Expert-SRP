using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor alfajor1 = new Alfajor(10, 8.5);
            Kiosco kiosco1 = new Kiosco();
            if (kiosco1.PuedeComprar(alfajor1, 15, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
