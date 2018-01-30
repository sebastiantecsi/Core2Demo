using System;
using Newtonsoft.Json;

namespace Core2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Product product = new Product();
            
            product.Name = "Apple";
            product.ExpiryDate = new DateTime(2008, 12, 28);
            product.Price = 3.99M;
            product.Sizes = new string[] { "Small", "Medium", "Large" };


            string output = JsonConvert.SerializeObject(product);

            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);

            Console.WriteLine("Hello World! " + deserializedProduct.Name);
            Console.ReadLine();
        }
    }

    internal class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public string[] Sizes { get; set; }
    }
}
