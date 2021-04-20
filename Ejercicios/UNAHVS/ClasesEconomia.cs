using System;
using System.Collections.Generic;
using System.Linq;

namespace UNAHVS
{
    class ClasesEconomia
    {
        int matriculadosEconomia = 0;
        public List<DeptoEconomia> ListaEconomia { get; set; }

        public ClasesEconomia()
        {
        ListaEconomia = new List<DeptoEconomia>();
        economia();
        }
        private void economia()
        {
            DeptoEconomia a =new DeptoEconomia ("CE-020", "Principios de Economia","Lidia Ferrera","10:00 - 11:00",30);
            DeptoEconomia b =new DeptoEconomia ("CE-240", "Microenomia","Ramon Bustillo","13:00 - 14:00",30);
            DeptoEconomia c =new DeptoEconomia ("CE-075", "Macroeconomia","Alonso Paredes","16:00 - 17:00",30);
            ListaEconomia.Add(a);
            ListaEconomia.Add(b);
            ListaEconomia.Add(c);

            
        }

    public void ListadeEconomia()
        {
            Console.Clear();
            Console.WriteLine("================================================================================================================================"); 
            Console.WriteLine("    ||   ||||||   ||       || ||||||  ||     || |||||||| ||||||| |||||||| ||||||    ||    ||||||| |||||| ||||||| ||     ||      ");
            Console.WriteLine("   ||||  ||   ||  ||||   ||||   ||    ||||   ||    ||    ||         ||    ||  ||   || ||  ||        ||   ||   || ||||   ||      ");
            Console.WriteLine(" ||   || ||    || || || || ||   ||    ||  || ||    ||    |||||||    ||    ||||||  ||   || ||        ||   ||   || || ||  ||      ");  
            Console.WriteLine(" ||||||| ||    || ||  ||   ||   ||    ||   ||||    ||         ||    ||    ||||    ||||||| ||        ||   ||   || ||  || ||      ");
            Console.WriteLine(" ||   || ||   ||  ||       ||   ||    ||    |||    ||         ||    ||    || ||   ||   || ||        ||   ||   || ||   ||||      " );
            Console.WriteLine(" ||   || ||||||   ||       || ||||||| ||     ||  ||||||| |||||||    ||    ||  ||  ||   || ||||||| |||||| ||||||| ||     ||      ");
            Console.WriteLine("================================================================================================================================");
            Console.WriteLine("");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("Codigo  | Asignatura | Maestro | Hora inicio - Hora Final | Cupos disponibles");
            Console.WriteLine("=============================================================================");

            foreach (var economia in ListaEconomia)
            {
                Console.WriteLine(economia.Codigo +" -> "+economia.Nombre+" -> "+economia.NombreMaestro+" -> "+economia.Hora+" -> "+economia.Cupos );
            }
            Console.ReadLine();
        }
public void matricula(string codigo)
    {
    Console.Clear(); 
    string matricular = "";
    
    foreach (var economia in ListaEconomia)
       {
            if(economia.Codigo==codigo)
                {
                    Console.Clear();
                    Console.WriteLine("Asignatura: "+economia.Nombre+"|| Horario: "+" "+economia.Hora);
                    Console.WriteLine("Cupos Disponibles: "+economia.Cupos);
                    Console.WriteLine("Decea matricular su clase (s/n): ");
                    matricular= Console.ReadLine();
                    
                    if (matricular.ToLower() == "s")
                    {
                        economia.Cupos--;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        matriculadosEconomia++ ;
                        if (economia.Cupos == 0)
                    {
                        Console.WriteLine("NO HAY CUPOS");
                    }
                        Console.ReadLine();
                    }
                    
                    
                }
       }
    }
public void claseNueva()
    {
    Console.Clear();
    string codigo="";
    Console.WriteLine("Ingrese el codigo de su clase: ");
    codigo=Console.ReadLine();
    matricula(codigo);

    }

public void matriculadoEconomia()
{
Console.WriteLine("Los matriculados en el departamento de economia son: "+matriculadosEconomia);
}
    } 
}
    