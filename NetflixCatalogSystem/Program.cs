using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            catalog.PrintCatalog();
        }
    }
}
