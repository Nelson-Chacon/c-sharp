using System;

namespace UNAHVS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcion="";
            OfertaAcademica a = new OfertaAcademica();
            ListaUsuarios b = new ListaUsuarios();
            Matriculados c = new Matriculados();
            
            while (true)
            {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("\t  MENU PRINCIPAL");
            Console.WriteLine("===========================================");
            Console.WriteLine("+ 1-> Programacion Academica del Periodo  +");
            Console.WriteLine("+ 2-> Lista de Usuarios                   +");
            Console.WriteLine("+ 3-> Adicionar Clase                     +");
            Console.WriteLine("+ 4-> Cantidad de Alumnos matriculados    +");
            Console.WriteLine("+ 0-> Salir                               +");
            Console.WriteLine("Seleccione una opcion: ");
            opcion=Console.ReadLine();
            switch (opcion)
            {
                case "1":
                {
                    a.ofertaAcademica();
                    break;
                }
                case "2":
                {
                    b.listaUsuarios();
                    break;
                }
                case "3":
                {
                    a.matriculando();
                    break;
                }
                case "4":
                {
                    c.Matricula();
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
