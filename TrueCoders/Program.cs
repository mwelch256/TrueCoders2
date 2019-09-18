using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            var guy1 = new People();
            var guy2 = new People();
            var guy3 = new People();

            guy1 = new People(21, "Kobe", "Crawford", "Black");
            guy2 = new People(26, "Ryan", "Adams", "Brown");
            guy3 = new People(32, "Michael", "Jordan", "Bald");

            List<People> TrueCoders = new List<People>();
            TrueCoders.Add(guy1);
            TrueCoders.Add(guy2);
            TrueCoders.Add(guy3);

            foreach (var Human in TrueCoders)
            {
                Console.WriteLine($"Tell me about yourself? Name:{Human.FirstName} {Human.LastName} Age: {Human.Age} Hair Color: {Human.HairColor}");
            }



        }
    }
}
