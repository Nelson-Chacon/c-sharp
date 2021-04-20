using System;
using System.Collections.Generic;
using System.Linq;

namespace UNAHVS
{
    class ClasesAdministracion
    {
        int matriculadosAdministracion = 0;
        public List<DeptoAdministracion> ListaAdministracion { get; set; }

        public ClasesAdministracion()
        {
        ListaAdministracion = new List<DeptoAdministracion>();
        administracion();
        }
        private void administracion()
        {
            DeptoAdministracion a =new DeptoAdministracion ("DAE-300", "Administracion I","Gabriel Peña","08:00 - 09:00",30);
            DeptoAdministracion b =new DeptoAdministracion ("DAE-400", "Administracion II","Juan Jose","18:00 - 19:00",30);
            DeptoAdministracion c =new DeptoAdministracion ("DAE-610", "Analisis Cuantitativo I","Pedro Perez","11:00 - 12:00",30);
            DeptoAdministracion d =new DeptoAdministracion ("DAE-505", "Contabilidad Administrativa I","Julio Amalla","07:00 - 08:00",30);
            DeptoAdministracion e =new DeptoAdministracion ("DAE-605", "Contabilidad Administrativa II.","Roberto Perdomo","11:00 - 12:00",30);
            DeptoAdministracion f =new DeptoAdministracion ("DAE-710", "Analisis Cuantitativo II.","Josefina Martinez","12:00 - 13:00",30);
        
            ListaAdministracion.Add(a);
            ListaAdministracion.Add(b);
            ListaAdministracion.Add(c);
            ListaAdministracion.Add(d);
            ListaAdministracion.Add(e);
            ListaAdministracion.Add(f);
            
        }

    public void ListadeAdministracion()
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

            foreach (var administracion in ListaAdministracion)
            {
                Console.WriteLine(administracion.Codigo +" -> "+administracion.Nombre+" -> "+administracion.NombreMaestro+" -> "+administracion.Hora+" -> "+administracion.Cupos );
            }
            Console.ReadLine();
        }
public void matricula(string codigo)
    {
    Console.Clear();  
    string matricular = "";
    
    foreach (var administracion in ListaAdministracion)
       {
            if(administracion.Codigo==codigo)
                {
                    Console.Clear();
                    Console.WriteLine("Asignatura: "+administracion.Nombre+"|| Horario: "+" "+administracion.Hora);
                    Console.WriteLine("Cupos Disponibles: "+administracion.Cupos);
                    Console.WriteLine("Decea matricular su clase (s/n): ");
                    matricular= Console.ReadLine();
                    
                    if (matricular.ToLower() == "s")
                    {
                        administracion.Cupos--;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        matriculadosAdministracion++;
                        if (administracion.Cupos == 0)
                    {
                        Console.WriteLine("NO HAY CUPOS");
                    }
                        Console.ReadLine();
                    }
                    
                    
                }
       }
    }
public void adicionar()
    {
    Console.Clear();
    string codigo="";
    Console.WriteLine("Ingrese el codigo de su clase: ");
    codigo=Console.ReadLine();
    matricula(codigo);

    }


public void matriculadoAdministracion()
{
Console.WriteLine("Los matriculados en el departamento de informatica son: "+matriculadosAdministracion);
}

    } 
}
    