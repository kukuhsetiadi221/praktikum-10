using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_printer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Pilih printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LasetJet");
            Console.WriteLine();
            Console.Write("Nomor printer [1..3]: ");

            int pilihan = Convert.ToInt32(Console.ReadLine());
            printer.Jenis = pilihan;

            IPrinter print;

            if (printer.Jenis == 1)
                print = new Epson();
            else if (printer.Jenis == 2)
                print = new Canon();
            else
            {
                print = new LasetJet();
            }
            print.Print(printer);
            Console.ReadLine();
        }
    }
}
