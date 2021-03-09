using System;
using System.Collections.Generic;
public class DatosPrueba
{
    public List<Producto> ListaProductos{ get; set; }
    public List<Cliente>  ListaClientes { get; set; }
    public List <Vendedor> ListaVendedores{ get; set; }

    public DatosPrueba()
    {
        ListaProductos = new List<Producto>();
        CargarProducto();
        ListaClientes = new List<Cliente>();

        ListaVendedores = new List<Vendedor>();
        
    }
    private void CargarProducto(){

        Producto a=new Producto (001,"Mause",150.5);
        ListaProductos.Add(a);
        Producto b=new Producto (002,"Teclado",300.45);
        ListaProductos.Add(b);
        Producto c=new Producto (003,"Tarjeta Grafica",1500);
        ListaProductos.Add(c);
        Producto d=new Producto (004,"Discos duro SSD",1300.34);
        ListaProductos.Add(d);
        Producto e=new Producto (005,"Monitor",8000);
        ListaProductos.Add(e);
        
    }
    public void ListarProductos(){
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("==================");
        Console.WriteLine("CODIGO | DESCRIPCION | PRECIO");
        foreach (var producto in ListaProductos)
        {
            Console.WriteLine (producto.Codigo +" | "+producto.Descripcion +"  | " +producto.Precio);
        }
    }
}