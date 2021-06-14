using Newtonsoft.Json;
using System;

namespace ConsoleApp
{
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
            product.Expiry = new DateTime(2008, 12, 28);
            product.Price = 3.99M;
            product.Sizes = new string[] { "Small", "Medium", "Large" };
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
    class Product
    {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public decimal Price { get; set; }
        public string[] Sizes { get; set; }
    }
}
