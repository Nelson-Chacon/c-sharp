using System;
using System.Collections.Generic;
using System.Linq;

namespace UNAHVS
{
    class ListaClases
    {
        int matriculadosInformatica = 0;
        public List<DeptoInformatica> ListaInformatica { get; set; }

        public ListaClases()
        {
        ListaInformatica = new List<DeptoInformatica>();
        informatica();
        }
        private void informatica()
        {
            DeptoInformatica a =new DeptoInformatica ("A-012", "Introducion a la informatica","Carmen Salgado","07:00 - 08:00",3);
            DeptoInformatica b =new DeptoInformatica ("A-012", "Introducion a la informatica","Carmen Salgado","17:00 - 21:00",30);
            DeptoInformatica c =new DeptoInformatica ("A-023", "Taller de Hardware I","Hector Garcia","09:00 - 10:00",30);
            DeptoInformatica d =new DeptoInformatica ("A-033", "Metodologia de la Programacion","Jorge Hernandez","07:00 - 08:00",30);
            DeptoInformatica e =new DeptoInformatica ("A-044", "Lenguaje de Programación I.","Igor Mejia","11:00 - 12:00",30);
            DeptoInformatica f =new DeptoInformatica ("A-044", "Lenguaje de Programación I.","Igor Mejia","12:00 - 13:00",30);
            DeptoInformatica g =new DeptoInformatica ("A-054", "Taller de Hardware II","Juan Mejia","14:00 - 15:00",30);
            DeptoInformatica h =new DeptoInformatica ("IA-065", "Lenguaje de Programación II.","Bilys Fernandez","19:00 - 20:00",30);

            ListaInformatica.Add(a);
            ListaInformatica.Add(b);
            ListaInformatica.Add(c);
            ListaInformatica.Add(d);
            ListaInformatica.Add(e);
            ListaInformatica.Add(f);
            ListaInformatica.Add(g);
            ListaInformatica.Add(h);
        }

    public void ListadeInformatica()
        {
            Console.Clear();
            Console.WriteLine(); 
            Console.WriteLine("||||||| ||       || ||||||  |||||||||  ||||||| ||         ||     ||     ||||||||  ||||||  |||||||    ||      ");
            Console.WriteLine("   ||   ||||     || ||      ||     ||  ||   || ||||     ||||    || ||      ||       ||    ||        || ||    ");
            Console.WriteLine("   ||   || ||    || ||      ||     ||  ||||||| ||  ||  || ||   ||   ||     ||       ||    ||       ||   ||   ");
            Console.WriteLine("   ||   ||   ||  || ||||||  ||     ||  ||||    ||    ||   ||  |||||||||    ||       ||    ||       |||||||   ");
            Console.WriteLine("   ||   ||     |||| ||      ||     ||  ||  ||  ||         ||  ||     ||    ||       ||    ||       ||   ||   ");
            Console.WriteLine("||||||| ||       || ||      |||||||||  ||   || ||         ||  ||     ||    ||     ||||||  |||||||  ||   ||   ");
            Console.WriteLine("");
            Console.WriteLine("Codigo  | Asignatura | Maestro | Hora inicio - Hora Final | Cupos disponibles");
            Console.WriteLine("=============================================================================");

            foreach (var informatica in ListaInformatica)
            {
                Console.WriteLine(informatica.Codigo +" -> "+informatica.Nombre+" -> "+informatica.NombreMaestro+" -> "+informatica.Hora+" -> "+informatica.Cupos );
            }
            Console.ReadLine();
        }
public void matricula(string codigo)
    {
    Console.Clear();  
    string matricular = "";
    
    foreach (var informatica in ListaInformatica)
       {
            if(informatica.Codigo==codigo)
                {
                    Console.Clear();
                    Console.WriteLine("Asignatura: "+informatica.Nombre);
                    Console.WriteLine("Cupos Disponibles: "+informatica.Cupos);
                    Console.WriteLine("Decea matricular su clase (s/n): ");
                    matricular= Console.ReadLine();
                    
                    if (matricular.ToLower() == "s")
                    {
                        informatica.Cupos--;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        matriculadosInformatica++ ;
                        if (informatica.Cupos == 0)
                    {
                        Console.WriteLine("NO HAY CUPOS");
                    }
                        Console.ReadLine();
                    }
                    
                    
                }
       }
    }
public void agregar()
{
    Console.Clear();
    string codigo="";
    Console.WriteLine("Ingrese el codigo de su clase: ");
    codigo=Console.ReadLine();
    matricula(codigo);

}
public void matriculadoInformatica()
{
Console.WriteLine("Los matriculados en el departamento de informatica son: "+matriculadosInformatica);
}




    }
}
    