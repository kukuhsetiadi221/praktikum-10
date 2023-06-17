using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_printer2
{
    public class Epson : IPrinter
    {
        public void Print(Printer printer)
        {
            Console.WriteLine("Epson display dimension : 10*11");
            Console.WriteLine("Epson printer printing....");
        }
    }
}
