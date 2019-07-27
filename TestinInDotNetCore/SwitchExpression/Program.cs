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
                new Wookie() { Name = "Chewie", Size = 3.5M },
                new Wookie() { Name = "Attichitcuk", Size = 3.4M },
                new Wookie() { Name = "Chak", Size = 3.2M }
            };

            foreach (var wookie in wookies)
            {
                WorkOneItem(wookie);
            }
        }

        // C# 7 way
        static void WorkOneItem(object item)
        {
            switch(item)
            {
                case Wookie wookie when wookie.Size > 3.4M:
                    {
                        Console.WriteLine("C'est un wookie grand");
                    }
                    break;

                case Wookie wookie:
                    {
                        Console.WriteLine("C'est un wookie");
                    } break;
            }
        }
    }
}
