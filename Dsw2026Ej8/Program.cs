using Dsw2026ej8;

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

            Console.WriteLine("\n===== PROBLEMA 3 =====");
            Problema3 p3 = new Problema3();
            Product prod = new Product { Description = "Original" };
            Console.WriteLine(p3.CompararCopias(5, prod));

            Console.WriteLine("\n===== PROBLEMA 4 =====");
            Problema4 p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, null, 10));

            Console.WriteLine("\n===== PROBLEMA 5 =====");
            Problema5 p5 = new Problema5();
            Sale venta1 = new RetailSale { Amount = 1000 };
            Sale venta2 = new WholesaleSale { Amount = 1000 };
            Console.WriteLine(p5.ObtenerImporteFinal(venta1));
            Console.WriteLine(p5.ObtenerImporteFinal(venta2));

            Console.WriteLine("\n===== PROBLEMA 6 =====");
            Problema6 p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
            Console.WriteLine(p6.NormalizarCodigoProducto(null));

            Console.ReadLine();

        }
    }
}
