using System;
namespace EjercicioAnimales
{
    class Aguila:Aves
    {
    public bool VolarAlto { get; set; }
    public Aguila(string nombre,string sexo,int edad,string colorPlumaje)
    {
      Nombre=nombre;
      Sexo=sexo;
      Edad=edad;
      ColorPlumaje=colorPlumaje;  
    }
    public void volarAlto()
    {
        VolarAlto=true;
        
    }



    }
    
}