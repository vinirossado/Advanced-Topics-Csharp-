using DesignPatterns.Generics;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
