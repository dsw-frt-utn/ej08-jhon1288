using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? n1, int? n2, int? n3)
        {
            double suma = 0;
            int count = 0;

            if (n1.HasValue && n1 >= 0 && n1 <= 10) { suma += n1.Value; count++; }
            if (n2.HasValue && n2 >= 0 && n2 <= 10) { suma += n2.Value; count++; }
            if (n3.HasValue && n3 >= 0 && n3 <= 10) { suma += n3.Value; count++; }

            return count == 0 ? 0 : suma / count;
        }
    }
}
