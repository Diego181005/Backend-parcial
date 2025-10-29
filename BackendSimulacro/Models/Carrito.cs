namespace BackendSimulacro.Models;

public class Carrito
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    public List<CarritoItem> Items { get; set; } = new();
}

public class CarritoItem
{
    public int Id { get; set; }
    public int CarritoId { get; set; }
    public Carrito Carrito { get; set; }

    public int ProductoId { get; set; }
    public Producto Producto { get; set; }
    public decimal Precio { get; set; }

    public int Cantidad { get; set; }
}