using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            string opcion="";
            ListaAnimales a = new ListaAnimales();
            
                Console.Clear();
                Console.WriteLine("Menu de Opciones");
                Console.WriteLine("================");
                Console.WriteLine("");
                Console.WriteLine("1->Mamiferos");
                Console.WriteLine("2->Aves");
                Console.WriteLine("3->Peces");
                Console.WriteLine("0->Salir");
                Console.WriteLine("Seleccione una opcion: ");
                opcion=Console.ReadLine();
                switch (opcion)
                {

                    case "1":
                    {
                    a.mamiferos();
                    break;
                    }
                    case "2":
                    {
                      break;  
                    }
                    case "3":
                    {
                      break;  
                    }
                    default:
                    break;
                }
                if (opcion=="0")
                {
                    break;
                }
            }

        }
    }
}
