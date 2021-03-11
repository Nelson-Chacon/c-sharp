using System;
using System.Collections.Generic;

public class Orden
{
    public int  Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string NumeroOrden { get; set; }

    public Cliente Cliente { get; set; }

    public Vendedor Vendedor { get; set; }

    public List<OrdenDetalle> ListaOrdenDetalle { get; set; }

    public Orden(int codigo,DateTime fecha, string numeroOrden, Cliente clientes, Vendedor vendedor)

    {
        Codigo = codigo;
        Fecha = fecha;
        NumeroOrden = numeroOrden;
        Cliente = clientes;
        Vendedor = vendedor;
        ListaOrdenDetalle = new List<OrdenDetalle>();
    }

    public void agregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaOrdenDetalle.Count+1;
        OrdenDetalle oD = new OrdenDetalle(nuevoCodigo,1,producto);
        ListaOrdenDetalle.Add(oD);
    }
}