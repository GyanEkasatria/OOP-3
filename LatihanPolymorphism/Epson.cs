using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism
{
    class Epson : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing");
        }
    }
}
