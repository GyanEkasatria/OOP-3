using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism
{
    class LaserJet : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing");
        }
    }
}
