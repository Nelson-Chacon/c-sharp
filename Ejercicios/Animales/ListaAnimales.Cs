using System;

namespace Animales
{
    public class ListaAnimales
    {
        public void mamiferos()
        {
                    Console.Clear();
                    string opcionM="";
                    Listas a =new Listas();
                    Console.Clear();
                    Console.WriteLine("MAMIFEROS");
                    Console.WriteLine("=========");
                    Console.WriteLine("");
                    Console.WriteLine("1->Lista de perros");
                    Console.WriteLine("2->Lista de gatos");
                    Console.WriteLine("3->Lista de Monos");
                    Console.WriteLine("Seleccione una opcion: ");
                    opcionM=Console.ReadLine();

                    switch (opcionM)
                    {
                       case "1":
                       {
                           a.ListarPerros();
                           break;
                       } 
                       case "2":
                       {
                           a.ListarGatos();
                           break;
                       } 
                       case "3":
                       {
                           a.ListarMonos();
                           break;
                       } 
                        default:
                        break;
                    }
        }
    }
}