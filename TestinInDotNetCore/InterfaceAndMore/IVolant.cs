using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndMore
{
    public interface IVolant
    {
        void Voler();

        void Atterrir()
        {
            Console.WriteLine("J'atterris");
        }
    }
}
