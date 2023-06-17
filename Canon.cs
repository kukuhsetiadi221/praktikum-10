using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_printer2
{
    public class Canon : IPrinter
    {
        public void Print(Printer printer)
        {
			Console.WriteLine("Canon display dimension : 9.5*12");
			Console.WriteLine("Canon printer printing....");
		}
    }
}
