using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}
