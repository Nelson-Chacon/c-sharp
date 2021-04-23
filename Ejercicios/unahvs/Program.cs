using System;

namespace unahvs
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion="";
            ListaClases a = new ListaClases();

            while (true)
            {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("     MENU PRINCIPAL");
            Console.WriteLine("===========================");
            Console.WriteLine("");
            Console.WriteLine("+ 1 -> Lista de Alumnos   +");
            Console.WriteLine("+ 2 -> Oferta Academica   +");
            Console.WriteLine("+ 3-> Adicionar Clases    +");
            Console.WriteLine("+ 4 -> Total Matriculados + ");
            Console.WriteLine("+ 0-> Salir               +");
            
            Console.WriteLine("Seleccione una opcion: ");
            opcion=Console.ReadLine();
            switch (opcion)
            {
                case "1":

                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    a.listaUsuarios();
                    break;
                }
                case "2":
                {

                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    a.ofertaAcademica();
                    break;
                }
                case "3":
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    a.agregar();;
                    break;
                }
                case "4":

                {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                
                    a.TotalMatriculado();
                    break;
                }
                
                default:
                break;
            }
            if(opcion=="0")
            {
                break;
            }

            }
            
        }
    }
}
