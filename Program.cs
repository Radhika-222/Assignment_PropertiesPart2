using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PropertiesPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct product = new HerbalProduct();
            product.setInfo();
            product.Show();
            Product product1 = new Product();
            product1.setInfo();
            product1.Show();
            Console.ReadKey();
        }
    }
}
        
