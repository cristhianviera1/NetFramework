using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Decimal Price { get; set; }
        public string[] Sizes { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ///esto es un comentario de prueba agregado
            Console.WriteLine("Test GitHub Actions - 20201");
            Console.WriteLine("Test doble commit");
            Console.WriteLine("Test arreglo comentario");
            Product product = new Product();
            product.Name = "Apple";
            product.ExpiryDate = new DateTime(2008, 12, 28);
            product.Price = 3.99M;
            product.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
