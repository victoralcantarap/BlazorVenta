namespace BlazorVenta.Data
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public DateOnly? Fecha { get; set; }
        public decimal? Itbis{ get; set; }
        public decimal? Total { get; set; }
    }
}
