using System;
using System.Collections.Generic;

namespace hello_world
{
     class Program
    {
        private static void Main(string[] args)//private is set since the variables are never public, this is safer
        {
            var names = new List<string> { "World", "Hendrik", "Felipe", "Emilia", "Moira" };//List had to be imported
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}