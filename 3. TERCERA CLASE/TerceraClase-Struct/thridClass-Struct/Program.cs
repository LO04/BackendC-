using System;

namespace thridClass_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Nombre",999,"Direccion","email",true);
            Console.WriteLine(cliente.NomCompleto);
        }
    }
    public struct Cliente
    {
        
        public string NomCompleto { get; }
        public int Telefono { get;}
        public string Direccion { get; }
        public string Email { get;}
        public bool ClienteNuevo { get; }
        public Cliente(string nombre,int telefono,string direccion,string email,bool clientenuevo)
        {
            NomCompleto = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            ClienteNuevo = clientenuevo;

        }
    }
}
