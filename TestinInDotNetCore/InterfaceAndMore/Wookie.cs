using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndMore
{
    public class Wookie : IVolant
    {
        #region Public methods
        public void Voler()
        {
            Console.WriteLine("Je vole");
        }

        public void Atterrir()
        {
            Console.WriteLine("Pas envie d'atterrir");
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public decimal Size { get; set; }
        #endregion
    }
}
