using System;

namespace VisualStudio2019_Whats_New
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hello World!");
           
            Dog dog = new Dog();
            string dogName = "Ruffy";
            string fetch = dog.FetchSomething("stick",dogName, DateTime.Now);
            dog.Legs = 6;

            var fetch2 = dog.FetchSomething("", dogName, DateTime.Now);
            Console.WriteLine($"My Dog {dogName} fetched a {fetch}");
            Console.WriteLine($"My Dog {dogName} fetched a {fetch2}");
            //error for debug example
            int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
            //error       

         

        }


    }
}
