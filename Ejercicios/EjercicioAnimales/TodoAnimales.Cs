using System;

namespace EjercicioAnimales
{
    class TodoAnimales
    {
        public void perro()
        {
            Perro a = new Perro("Toby","Macho",2,4,"Oviparo","Digitígrados","Pittbul");
            Console.Clear();   
            Console.WriteLine("     PERRO");
            Console.WriteLine("     =====");
            Console.WriteLine("Nombre: "+ a.Nombre);
            Console.WriteLine("Sexo: "+ a.Sexo);
            Console.WriteLine("Raza: "+ a.Raza);
            Console.WriteLine("Edad: "+ a.Edad);
            a.comer();
            Console.WriteLine("Come: "+ a.Comer);
            Console.WriteLine("Patas: "+ a.Patas);
            Console.WriteLine("Reproduccion: "+ a.Reproduccion);
            Console.WriteLine("Desplazamiento: "+ a.Desplazamiento);
            a.caminar();
            Console.WriteLine("Caminar: "+ a.Caminar);
            a.ladrar();
            Console.WriteLine("Ladrar: "+ a.Ladrar);
            
           
            Console.ReadLine();
        }
        public void gato()
        {
            Gatos a = new Gatos("Copito","Macho",4,4,"Oviparo","Digitígrados");
            Console.Clear();   
            Console.WriteLine("     Gatos");
            Console.WriteLine("     =====");
            Console.WriteLine("Nombre: "+ a.Nombre);
            Console.WriteLine("Sexo: "+ a.Sexo);
            Console.WriteLine("Edad: "+ a.Edad);
            a.comer();
            Console.WriteLine("Come: "+ a.Comer);
            Console.WriteLine("Patas: "+ a.Patas);
            Console.WriteLine("Reproduccion: "+ a.Reproduccion);
            Console.WriteLine("Desplazamiento: "+ a.Desplazamiento);
            a.caminar();
            Console.WriteLine("Caminar: "+ a.Caminar);
            a.maullar();
            Console.WriteLine("Maulla?: "+ a.Maullar);
            Console.ReadLine();
        }
        public void monos()
        {
            Monos a = new Monos("Jorge","Macho",7,2,"Oviparo","Plantígrados");
            Console.Clear();   
            Console.WriteLine("     Monos");
            Console.WriteLine("     =====");
            Console.WriteLine("Nombre: "+ a.Nombre);
            Console.WriteLine("Sexo: "+ a.Sexo);
            Console.WriteLine("Edad: "+ a.Edad);
            a.comer();
            Console.WriteLine("Come: "+a.Comer);
            Console.WriteLine("Patas: "+ a.Patas);
            Console.WriteLine("Reproduccion: "+ a.Reproduccion);
            Console.WriteLine("Desplazamiento: "+ a.Desplazamiento);
            a.caminar();
            Console.WriteLine("Caminar: "+ a.Caminar);
            a.maulla();
            Console.WriteLine("Maulla?: "+ a.Maulla);
            Console.ReadLine();
        }
        public void aguila()
        {
            Aguila a = new Aguila("Águila Arpía","Macho",1,"Blanco");
            Console.Clear();   
            Console.WriteLine("     Aguila");
            Console.WriteLine("     =====");
            Console.WriteLine("Nombre: "+ a.Nombre);
            Console.WriteLine("Sexo: "+ a.Sexo);
            Console.WriteLine("Edad: "+ a.Edad);
            a.comer();
            Console.WriteLine("Come: "+ a.Comer);
            Console.WriteLine("Color de Plumaje: "+ a.ColorPlumaje);
            a.volar();
            Console.WriteLine("Vuela?: "+ a.Volar);
            a.volarAlto();
            Console.WriteLine("Vuela Alto: "+ a.VolarAlto);
            Console.ReadLine();
        }
        public void loro()
        {
            Loro a = new Loro("Paquito","Macho",1,"Blanco");
            Console.Clear();   
            Console.WriteLine("     Loro");
            Console.WriteLine("     =====");
            Console.WriteLine("Nombre: "+ a.Nombre);
            Console.WriteLine("Sexo: "+ a.Sexo);
            Console.WriteLine("Edad: "+ a.Edad);
            a.comer();
            Console.WriteLine("Come: "+ a.Comer);
            Console.WriteLine("Color de Plumaje: "+ a.ColorPlumaje);
            a.volar();
            Console.WriteLine("Vuela?: "+ a.Volar);
            a.hablar();
            Console.WriteLine("Habla?: "+ a.Hablar);
            Console.ReadLine();
        }
        public void pezGlobo()
        {
            PezGlobo a = new PezGlobo("Nemo","Macho",1,2);
            Console.Clear();    
            Console.WriteLine("     Pez Globo");
            Console.WriteLine("     =========");
            Console.WriteLine("Nombre: "+ a.Nombre);
            Console.WriteLine("Sexo: "+ a.Sexo);
            Console.WriteLine("Edad: "+ a.Edad);
            a.comer();
            Console.WriteLine("Come: "+ a.Comer);
            a.nadar();
            Console.WriteLine("Nada? "+ a.Nadar);
            Console.WriteLine("Numero de Aletas: "+ a.NumeroAletas);
            a.inflarce();
            Console.WriteLine("Se infla?: "+ a.Inflarce);
            Console.ReadLine();
        }
        
    }
}