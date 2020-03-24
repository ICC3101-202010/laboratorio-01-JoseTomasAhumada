using System;

namespace Laboratorio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Bob", "Kunga");
            Console.WriteLine("La persona " + p1.GetFirstName() + " " + p1.GetLastName() + " obtuvo " + p1.Lanzar());
            Console.ReadKey();
        }
    }
}