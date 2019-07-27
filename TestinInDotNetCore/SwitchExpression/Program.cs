using System;
using System.Collections.Generic;

namespace SwitchExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Wookie> wookies = new List<Wookie>()
            {
                new Wookie() { Name = "Chewie", Size = 3.2M },
                new Wookie() { Name = "Attichitcuk", Size = 3.4M },
                new Wookie() { Name = "Chak", Size = 3.2M }
            };

            foreach (var wookie in wookies)
            {
                DisplayBirthOfV7(wookie);
                Console.WriteLine(DisplayBirthOfV8(wookie));
            }
        }

        // C# 7 way
        static void DisplayBirthOfV7(object item)
        {
            switch (item)
            {
                case Wookie wookie when wookie.Size > 3.4M:
                    {
                        Console.WriteLine("C'est un wookie grand");
                    }
                    break;

                case Wookie wookie:
                    {
                        Console.WriteLine("C'est un wookie");
                    }
                    break;
            }
        }

        static string DisplayBirthOfV8(object item)
        {
            string content = string.Empty;

            content = item switch
            {
                Wookie wookie when wookie.Size > 3.4M => "C'est un wookie grand",

                Wookie { Name: "Chewie" } => "C'est Chewie",

                Wookie wookie => "C'est un wookie",
                _ => "Non prévu"
            };

            return content;
        }
    }
}
