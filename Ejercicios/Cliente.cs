using System;


public class Cliente:Persona
{
    public string Telefono { get; set; }

    public Cliente(int codigo, string nombre, string telefono)
    {
        Codigo=codigo;
        Nombre= nombre;
        Telefono = telefono;
        
    }
}