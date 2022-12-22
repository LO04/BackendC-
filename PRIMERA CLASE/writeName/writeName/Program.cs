using System;

namespace writeName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Tu nombre es: "+name);
            Console.WriteLine("La fecha actual es: "+ DateTime.Now.ToLongDateString());
        }
    }
}
