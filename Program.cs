using System;

namespace cajero_remastered
{
    class Program
    {
        static void Main(string[] args)
        {
            int seleccion;
            bool salir = false;

           Console.WriteLine("Bienvenido al cajero automatico, seleccione una opcion: ");

        while(!salir){
            Console.WriteLine("1. DFD INVETSMENTS");
            Console.WriteLine("2. Banreservas");
            Console.WriteLine("3. Otro, especifique...");
           string other = Console.ReadLine();
           Console.WriteLine("4. Salir");

    Console.WriteLine("Seleccione una opcion del menu:");
    seleccion = Convert.ToInt32(Console.ReadLine());


    switch(seleccion){
        case 1:

        break;
    }

            }     
        }
    }
}
