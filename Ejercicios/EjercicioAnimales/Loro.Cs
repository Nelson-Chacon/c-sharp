using System;
namespace EjercicioAnimales
{
    class Loro:Aves
    {

        public bool Hablar{ get; set; }
    public Loro(string nombre,string sexo,int edad,string colorPlumaje)
    {
      Nombre=nombre;
      Sexo=sexo;
      Edad=edad;
      Comer=true;
      ColorPlumaje=colorPlumaje;  
    }
    public void hablar()
    {
        Hablar=true;
    }



    }
    
}