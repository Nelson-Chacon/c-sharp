using System;
using System.Collections.Generic;  
namespace Animales
{   
    class Listas
    {
    //Mamiferos
    public List<Perro> ListaPerro { get; set; }
    public List<Gatos> ListaGatos { get; set; }
    public List<Mono> ListaMono { get; set; }
    //Aves
    

    public Listas()
    {
        //Mamiferos
        ListaPerro =new List<Perro>();
        perros();
        ListaGatos = new List<Gatos>();
        Gato();
        ListaMono = new List<Mono>();
        Monos();

    }
//PERROS
    private void perros()
    {
        Perro a = new Perro ("MAX", "Macho" , "5", " 4 ","Viviparo","Digitígrados",true);
        ListaPerro.Add(a);
        Perro b = new Perro ("Kaiser", "Macho" , "2", " 4 ","Viviparo","Digitígrados",true);
        ListaPerro.Add(b);
        Perro c = new Perro ("Princesa", "Hembra" , "1", " 4 ","Viviparo","Digitígrados",true);
        ListaPerro.Add(c);
    }

    public void ListarPerros()
    {
        Console.Clear();
 
        Console.WriteLine("LISTA DE PERROS");
        Console.WriteLine("===============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | PATAS | REPRODUCCION | DESPLAZAMIENTO");
        
        foreach (var perros in ListaPerro)
        {
            Console.WriteLine(perros.Nombre+" | "+perros.Sexo+" | "+perros.Edad+" | "+perros.Patas+" | "+perros.Reproduccion+" | "+perros.Desplazamiento+" | "+perros.Comer);
        }
        Console.ReadLine();
    }
//Gatos
   private void Gato()
    {
        Gatos a = new Gatos ("Coco.", "Macho" , "1", " 4 ","Viviparo","Digitígrados");
        ListaGatos.Add(a);
        Gatos b = new Gatos ("Garfiel", "Macho" , "5", " 4 ","Viviparo","Digitígrados");
        ListaGatos.Add(b);
        Gatos c = new Gatos ("Pelusa", "Hembra" , "3", " 4 ","Viviparo","Digitígrados");
        ListaGatos.Add(c);
    }

    public void ListarGatos()
    {
        Console.Clear();
       Console.WriteLine("LISTA DE GATOS");
        Console.WriteLine("===============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | PATAS | REPRODUCCION | DESPLAZAMIENTO");
        foreach (var perros in ListaGatos)
        {
            Console.WriteLine(perros.Nombre+" | "+perros.Sexo+" | "+perros.Edad+" | "+perros.Patas+" | "+perros.Reproduccion+" | "+perros.Desplazamiento);
        }
        Console.ReadLine();
    }
    //Monos
   private void Monos()
    {
        Mono a = new Mono ("Jorge", "Macho" , "1", " 2 ","Viviparo","Plantígrados");
        ListaMono.Add(a);
        Mono b = new Mono ("King Kong", "Macho" , "5", " 2 ","Viviparo","Plantígrados");
        ListaMono.Add(b);
 
    }

    public void ListarMonos()
    {
        Console.Clear();
        Console.WriteLine("LISTA DE MONOS");
        Console.WriteLine("===============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | PATAS | REPRODUCCION | DESPLAZAMIENTO");
        
        foreach (var perros in ListaMono)
        {
            Console.WriteLine(perros.Nombre+" | "+perros.Sexo+" | "+perros.Edad+" | "+perros.Patas+" | "+perros.Reproduccion+" | "+perros.Desplazamiento);
        }
        Console.ReadLine();
    }  
    
    }
}