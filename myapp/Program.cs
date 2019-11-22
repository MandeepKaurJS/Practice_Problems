using System;
using Newtonsoft.Json;
namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var product=new Product{ID=100,Name="Mandeep Kaur",Price=99.9};
        //Serialize the product object to json
        var jsonstring=JsonConvert.SerializeObject(product);
        System.Console.WriteLine(jsonstring);
        //deserialize the product to jsaon string
        var product2=JsonConvert.DeserializeObject<Product>(jsonstring)
        System.Console.WriteLine($"Teh Prodcut ID: {product2.ID}");
        System.Console.WriteLine($"Teh Prodcut NAme: {product2.Name}");
        System.Console.WriteLine($"Teh Prodcut PRice: {product2.Price}");
         
        }
    }
    class Product{
        public int ID{get;set;}
        public string Name{get;set;}
        public double Price{get;set;}
    }
}
