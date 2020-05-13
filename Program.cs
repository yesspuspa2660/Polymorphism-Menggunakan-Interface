using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama \t: Rahayu Puspa Indah Lestari Ningrum");
            Console.WriteLine("NIM \t: 19.11.2660");
            Console.WriteLine("Kelas \t: Informatika 02\n");


            PrinterWindows printer;
            
            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Pilih printer yang akan digunakan [1/2/3] : ");

            int NomorPrinter = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            if (NomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (NomorPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();

        }
    }
}


