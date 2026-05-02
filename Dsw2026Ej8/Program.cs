namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PROBLEMA 1 =====");
            ProductHelper helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(123, "Mouse", 1500));

            Console.WriteLine("\n===== PROBLEMA 2 =====");
            Problema2 p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(1001, "Teclado", 2, 1500));
        }
    }
}
