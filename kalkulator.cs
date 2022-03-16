using System;

namespace KalkulatorConsoleApp
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Title = "Kalkulator C#";

            Console.WriteLine("Menu Kalkulator");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");

            Console.Write("Masukan Pilihan Anda = ");
            int pilihanMenu = int.Parse(Console.ReadLine());

            if (pilihanMenu <= 4){

            switch(pilihanMenu)
            {
            case 1:
            Console.Write("Penambahan");


            Console.Write("Masukan Nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Masukan Nilai B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan " + a + " + " + b +" = " + Penambahan(a,b));
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            break;

            case 2:
            Console.Write("Masukan Nilai A = ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Masukan Nilai B = ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Pengurangan " + c + " - " + d +" = " + Pengurangan(c,d));
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            break;

            case 3:
            Console.Write("Masukan Nilai A = ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Masukan Nilai B = ");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Perkalian " + e + " * " + f +" = " + Perkalian(e,f));

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            break;

            case 4:
             Console.Write("Masukan Nilai A = ");
            int g = int.Parse(Console.ReadLine());

            Console.Write("Masukan Nilai B = ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Pembagian " + g + " / " + h +" = " + Pembagian(g,h));
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            break;
            }
            }

            else {
            Console.WriteLine("Maaf pilihan yg anda masukan tidak ada");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            }
        }
        static int Penambahan (int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int c, int d)
        {
            return c - d;
        }
        static int Perkalian(int e,int f)
        {
            return e * f;
        }
        static int Pembagian (int g,int h)
        {
            return g / h;
        }
    }
}









