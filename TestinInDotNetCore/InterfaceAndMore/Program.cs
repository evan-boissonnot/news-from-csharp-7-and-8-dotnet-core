using System;

namespace InterfaceAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Wookie wookie = new Wookie();
            // wookie.Atterrir(); // Pas reconnu, car vision Wookie ... étrange.

            (wookie as IVolant).Atterrir(); // Et voilà, ici, on le reconnait. "Reconnu" via le cast, mais pas présent dans la classe, logique en fait
        }
    }
}
