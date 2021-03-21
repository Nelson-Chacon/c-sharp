using System;

namespace EjercicioAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion="";
            TodoAnimales a = new TodoAnimales();
            while (true)
            {
            Console.WriteLine("     Animales");
            Console.WriteLine("     ========");
            Console.WriteLine("");
            Console.WriteLine("1->Perros");
            Console.WriteLine("2->Gatos");
            Console.WriteLine("3->Mono");
            Console.WriteLine("4->Aguila");
            Console.WriteLine("5->Loro");
            Console.WriteLine("6->Pez Globo");
            Console.WriteLine("Seleccione una Opncion: ");
            opcion=Console.ReadLine();
            switch (opcion)
            {
                case "1":
                a.perro();

                break;
                case "2":
                a.gato();
                break;
                case "3":
                a.monos();
                break;
                case "4":
                a.aguila();
                break;
                case "5":
                a.loro();
                break;
                case "6":
                a.pezGlobo();
                break;

                default:
                break;
            }
            if (opcion =="0")
            {
               break; 
            }
            }
            
        }
    }
}
