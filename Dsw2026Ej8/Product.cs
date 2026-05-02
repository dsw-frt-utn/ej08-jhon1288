using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026ej8
{
    internal class Product
    {
        public string Description { get; set; }

        public void CambiarDescripcion(string nueva)
        {
            Description = nueva;
        }
    }
}
