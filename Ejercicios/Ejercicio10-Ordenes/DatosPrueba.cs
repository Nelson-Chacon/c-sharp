using System;
using System.Collections.Generic;
public class DatosPrueba
{
    public List<Producto> ListaProductos{ get; set; }
    public List<Cliente>  ListaClientes { get; set; }
    public List<Vendedor> ListaVendedores{ get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosPrueba()
    {
        ListaProductos = new List<Producto>();
        CargarProducto();
        ListaClientes = new List<Cliente>();
        cargarClientes();
        ListaVendedores = new List<Vendedor>();
        cargarVendedor();
        ListaOrdenes = new List<Orden>();
        
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
    private void cargarClientes()
    {
        Cliente c1=new Cliente (001,"Maria","2560-3460",900);
        ListaClientes.Add(c1);
        Cliente  c2=new Cliente (002,"Jose","2674-2301",500);
        ListaClientes.Add(c2);
        Cliente  c3=new Cliente (003,"Dario","3324-5589",1500);
        ListaClientes.Add(c3);
        
    }
    public void ListarCliente()
    {
        Console.Clear();
        Console.WriteLine("LISTA DE CLIENTES");
        Console.WriteLine("=================");
        Console.WriteLine("");
        Console.WriteLine("CODIGO | NOMBRE DEL CLIENTE | TELEFONO DEL CLIENTE | SALDO DEL CLIENTE");
        foreach (var clientes in ListaClientes)
        {
           Console.WriteLine(clientes.Codigo + " | "+clientes.Nombre+" | "+clientes.Telefono+" | "+clientes.Saldo); 
        }
        Console.ReadLine();
    }
    private void cargarVendedor()
    {
        Vendedor v1=new Vendedor (001,"Pedro","v001");
        ListaVendedores.Add(v1);
        Vendedor  v2=new Vendedor (002,"Roberto","v002");
        ListaVendedores.Add(v2);
        Vendedor  v3=new Vendedor (003,"Juan Carlos","v 003");
        ListaVendedores.Add(v3);
        
    }
    public void ListarVendedores()
    {
        
        Console.Clear();
        Console.WriteLine("LISTA DE VENDEDORES");
        Console.WriteLine("=================");
        Console.WriteLine("");
        Console.WriteLine("CODIGO | NOMBRE DEL VENDEDOR| CODIGO DEL VENDEDOR");
        foreach (var vendedor in ListaVendedores)
        {
           Console.WriteLine(vendedor.Codigo + " | "+vendedor.Nombre+" | "+vendedor.CodigoVendedor); 
        }
        Console.ReadLine();
    }

    public void crearOrdenes()
    {
        string codigoCliente = ""; 
        string codigoVendedor = "";
        Console.WriteLine("CREANDO ORDENES");
        Console.WriteLine("================");
        Console.WriteLine("Ingrese el codigo del Cliente");
        codigoCliente=Console.ReadLine();

        Cliente cliente = ListaClientes.Find(v=>v.Codigo.ToString()==codigoCliente);
        if (cliente==null)
        {
            Console.WriteLine("Cliente No encontrado");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Cliente: "+ cliente.Nombre);
        }
        Console.WriteLine("");
        Console.WriteLine("Ingrese el codigo del Vendedor");
        codigoVendedor=Console.ReadLine();
        Vendedor vendedor = ListaVendedores.Find(v=>v.Codigo.ToString() == codigoVendedor);
        if (vendedor==null)
        {
            Console.WriteLine("vendedor No encontrado");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Vendedor: "+ vendedor.Nombre);
        }
        Console.WriteLine("");
        int nuevoCodigo =ListaOrdenes.Count + 1;
        Orden OrdenNueva =new Orden(nuevoCodigo, DateTime.Now ,"SPS"+nuevoCodigo,cliente,vendedor);
        ListaOrdenes.Add(OrdenNueva);

        while (true)
        {  Console.WriteLine("Ingrese el codigo del producto: ");
           string codigoProducto = Console.ReadLine();
           Producto producto = ListaProductos.Find(p=>p.Codigo.ToString() == codigoProducto);
            if (producto==null)
            {
            Console.WriteLine("Producto No encontrado");
            Console.ReadLine();
            }else
            {
                OrdenNueva.agregarProducto(producto);
                Console.WriteLine("Producto Agregado: "+ producto.Descripcion + " con precio de: "+ producto.Precio);
            }
            string continuar = "";
            Console.WriteLine("Desea continuar (s/n): ");
            continuar=Console.ReadLine();
            if (continuar.ToLower()== "n")
            {
                break;
            }

        }
        Console.WriteLine("");
        Console.WriteLine("El Subtotal de la orden es: "+OrdenNueva.Subtotal);
        Console.WriteLine("Impuesto total: "+OrdenNueva.Impuesto);
        Console.WriteLine("El total de la orden es: "+OrdenNueva.Total);
        Console.ReadLine();
    }
    public void ListarOrdenes()
    {

        Console.Clear();
        Console.WriteLine("             LISTA DE ORDENES");
        Console.WriteLine("             =================");
        Console.WriteLine("Codigo de la orden | Fecha | Total de la orden");
       Console.WriteLine("===============================================");
        Console.WriteLine("             Cliente|Vendedor");
        Console.WriteLine("             ================");
        Console.WriteLine("");
        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo+" | "+orden.Fecha+" | "+orden.Total );
            Console.WriteLine(orden.Cliente.Nombre+" | "+orden.Vendedor.Nombre);
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     "+detalle.Producto.Descripcion+" |"+detalle.Precio);
                
            }
        Console.WriteLine("");
        Console.WriteLine("El Subtotal de la orden es: "+orden.Subtotal);
        Console.WriteLine("Impuesto total: "+orden.Impuesto);
        Console.WriteLine("El total de la orden es: "+orden.Total);
        Console.WriteLine("");
        }
       Console.ReadLine();

    }
}