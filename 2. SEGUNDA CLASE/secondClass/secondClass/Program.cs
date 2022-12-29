using System;

namespace secondClass
{
    class Program
    {

        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio03();
        }
        public static void Ejercicio1()
        {
            Console.WriteLine("Introduce tu Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tus Apellidos: ");
            string Apellido = Console.ReadLine();
            Console.WriteLine("Introduce tu edad: ");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sabe Programar? : ");
            bool sabeProgramar = bool.Parse(Console.ReadLine() == "si" ? "true" : "false");

            Console.WriteLine("\n" + "Su nombre es: " + nombre + " " + Apellido + " Con una edad de " + edad + "  y " + (sabeProgramar == false ? "NO" : "si") + " sabe programar");
        }
        public static void Ejercicio2()
        {
            Coche coche = new Coche();
            coche.puertas = 4;
            coche.ruedas = 4;
            coche.marca = "ford";
            coche.ITVvigente = true;
            Puerta puerta = new Puerta();
            puerta.peso = 4.5;
            puerta.largo = 5.5;
            puerta.material = "Madera";
            puerta.color = "Rojo";

            Console.WriteLine(coche.marca);
        }
        public static void Ejercicio03()
        {
            int numero=0;
            char letra = 'a';
            if (numero>18 && letra == 'a')
            {
                Console.WriteLine("El numero es mayor a 18");
            }
            if (numero > 18 && letra != 'a')
            {
                Console.WriteLine("El numero es mayor a 18");
            }

        }
    }

    public class Coche
    {
        public int puertas { get; set; }
        public int ruedas { get; set; }
        public string marca { get; set; }
        public bool ITVvigente { get; set; }
    }
    public class Puerta
    {
        public double peso { get; set; }
        public double largo { get; set; }
        public string material { get; set; }
        public string color { get; set; }
    }
    
}
