using System;
using System.Collections.Generic;

namespace Quinta_entrega
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            Ejercicio2();
        }
        public static void Ejercicio1()
        {
            int producto = 100;
            Console.WriteLine("El precio del producto es "+producto);
            Console.WriteLine("Ingrese el nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Email: ");
            string Email = Console.ReadLine();
             Console.WriteLine("Tiene cupón? ");
            bool cupon = Console.ReadLine()=="si"?true:false;
           if(cupon == true)
            {
                Console.WriteLine("El usuario tiene un cupon, por lo tanto el programa tiene un costo de: "+(producto-50));
            }else
            {
                Console.WriteLine("El usuario no tiene un cupon, por lo tanto el programa tiene un costo de: " + producto);
            }
        }
        public static void Ejercicio2()
        {
            int index=0;
            
            List<string> lenguajes = new List<string>();
            lenguajes.Add("c#");
            lenguajes.Add("java");
            lenguajes.Add("python");

            Console.WriteLine("Escoja una opción: ");
            foreach (var item in lenguajes)
            {
                Console.WriteLine((index += 1) + ": " + item);
            }
            Console.WriteLine("\n" + "Escoja una opción: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Información sobre c#");
                    break;
                case 2:
                    Console.WriteLine("Información sobre java");
                    break;
                case 3:
                    Console.WriteLine("Información sobre python");
                    break;
            }

        }
    }
}
