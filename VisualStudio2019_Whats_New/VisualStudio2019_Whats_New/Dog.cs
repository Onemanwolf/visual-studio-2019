using System;
using System.Collections.Generic;
using System.Text;

namespace VisualStudio2019_Whats_New
{
    class Dog : IAnimal
    {
        public int Legs { get; set; }



        public bool Eat(IFood food, DateTime time) => true;

        public string FetchSomething(string command,
                                     string dogName,
                                     DateTime time)
        {
            if (string.IsNullOrEmpty(command))
            {
                Console.WriteLine($"My Dog {dogName} doesn't have anything to Fetch please tell him what you want");
            }

            if (string.IsNullOrWhiteSpace(dogName))
            {
                throw new ArgumentException("message", nameof(dogName));
            }
            var addVar = "Code Share is cool";
            var check = command.ToUpper();
            Legs = 4;
          var  itemFetched = check switch {
              "STICK" => "Stick",
              "BALL" => "Ball",
              "SHOE" => "Shoe",
               _ => $"My Dog {dogName} only gets Sticks, Balls or Shoes"
};
                    
         
            
            return itemFetched;
        }
    }
}
