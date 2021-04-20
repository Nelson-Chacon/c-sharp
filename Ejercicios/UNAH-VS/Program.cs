using System;

namespace UNAH_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion="";
            ListaClases a = new ListaClases();
            ListaUsuarios b= new ListaUsuarios();
            while (true)
            {
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
                    b.listaUsuarios();
                    break;
                }
                case "2":
                {
                    a.ofertaAcademica();
                    break;
                }
                case "3":
                {
                    a.agregar();;
                    break;
                }
                case "4":
                {
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
