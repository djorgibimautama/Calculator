using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Program Aplikasi Calculator";

            Console.WriteLine("Pilih menu Calculator");

            Console.WriteLine();

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();

            Console.WriteLine("Masukan Pilihan :");

            String userinput = Console.ReadLine();

            Console.WriteLine("Isi input = " + userinput);
            if (userinput.Equals("1"))
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            
            }
            else if(userinput.Equals("2"))
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if(userinput.Equals("3"))
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if(userinput.Equals("4"))
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Pilihan yang anda masukan tidak ada");
            }
			
			Console.WriteLine("\nTekan Sembarang key untuk keluar");
            Console.ReadKey();
           
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}