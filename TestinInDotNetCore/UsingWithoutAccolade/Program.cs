using System;

namespace UsingWithoutAccolade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Before C# 8
            using (System.IO.StreamReader reader = new System.IO.StreamReader(@"I:\Tmps\mysql-init.txt"))
            {
                string contenu = reader.ReadToEnd();
                Console.WriteLine(contenu);
            }

            // Now, with C# 8
            using System.IO.StreamReader reader2 = new System.IO.StreamReader(@"I:\Tmps\mysql-init.txt");
            string contenu2 = reader2.ReadToEnd();
            Console.WriteLine(contenu2);
        }
    }
}
