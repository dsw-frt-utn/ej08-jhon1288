namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PROBLEMA 1 =====");
            ProductHelper helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(123, "Mouse", 1500));
        }
    }
}
