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
        Console.WriteLine(jsonstring);

        }
    }
    class Product{
        public int ID{get;set;}
        public string Name{get;set;}
        public double Price{get;set;}
    }
}
