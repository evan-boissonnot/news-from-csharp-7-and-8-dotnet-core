using System;
using System.Collections.Generic;
using System.Text;

namespace BetterExtensionMethod
{
    public static class ExtensionMethods
    {
        public static void Voler(this Wookie wookie)
        {
            Console.WriteLine("I can fly");
        }
    }
}
