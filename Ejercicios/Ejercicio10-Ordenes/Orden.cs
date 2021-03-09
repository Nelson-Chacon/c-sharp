using System;


public class Orden
{
    public int  Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string NumeroOrden { get; set; }

    public Cliente Cliente { get; set; }

    public Vendedor Vendedor { get; set; }

    public Orden(int codigo,DateTime fecha, string numeroOrden, Cliente cliente, Vendedor vendedor)

    {
        Codigo = codigo;
        Fecha = fecha;
        NumeroOrden = numeroOrden;
        Cliente = cliente;
        Vendedor = vendedor;
    }
}