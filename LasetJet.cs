using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_printer2
{
    internal class LasetJet : IPrinter
    {
        public void Print(Printer printer)
        {
            Console.WriteLine("LasetJet display dimension : 12*12");
            Console.WriteLine("LasetJet printer printing....");
        }
    }
}
