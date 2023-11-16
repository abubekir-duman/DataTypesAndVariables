using System;

namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 1 + 2;
            Console.WriteLine("1+2="+toplam);

            int toplam2 = 1 + 2 + 3 + 4;
            Console.WriteLine($"1+2+3+4={toplam2}");


            int no1 = 1, no2 = 2, no3 = 3, no4 = 4;
            Console.WriteLine("no1+no2+no3+no4="+ (no1+no2+no3+no4));

            int toplam3 = no1 + no2 + no3 + no4;
            Console.WriteLine("no1+no2+no3+no4="+toplam3);

            long sayi3 = 3;
            sayi3 = sayi3 + 4;
            Console.WriteLine(sayi3);

            short sayi4 = 1;
            sayi4+= 2;
            Console.WriteLine(sayi4);

            byte sayi5 = 0;
            sayi5 = (byte)(sayi5 + 1);
            sayi5 += 1;
            sayi5++;
            Console.WriteLine(sayi5);


            int sayi6 = 1;
            Console.WriteLine(sayi6++);
            sayi6 = 1;
            Console.WriteLine(++sayi6);

            int sayi7 = 7;
            int sayi8 = 8;
            int fark = sayi7 - sayi8;
            Console.WriteLine(fark);

            double sayi9 = 8.9;
            sayi9 -= 0.9;
            Console.WriteLine(sayi9);


            short sayi10 = 10;
            --sayi10;
            sayi10--;
            Console.WriteLine(sayi10);

            int sayi11 = 11;
            int sayi12 = 12;
            int carpım = sayi11 * sayi12;
            Console.WriteLine($"Carpım:{carpım}");

            float sayi13 = 13.3f;
            sayi13 *= 2;
            Console.WriteLine(sayi13);

            int sayi14 = 14;
            int sayi15=5;
            int bolum = sayi14 / sayi15;
            Console.WriteLine(bolum);


            double bolum1 = sayi14 / sayi15;
            Console.WriteLine(bolum1);

            double bolum2 =(double) sayi14 / sayi15;
            Console.WriteLine(bolum2);


            double bolum3 = (double)sayi14 / (double)sayi15;
            Console.WriteLine(bolum3);


            double bolum4 = 4;
            bolum4 /= 2;
            Console.WriteLine(bolum4);

            int sayi21 = 21;
            int sayi22 = 2;
            int kalan = sayi21 % sayi22;
            Console.WriteLine(kalan);

            int sayi24 = 24;
            sayi24 %= 5;
            Console.WriteLine(sayi24);


        }
    }
}