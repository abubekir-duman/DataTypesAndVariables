﻿namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam=Topla((int)1.2,(int)2.3);
            Console.WriteLine(toplam);

            int n1 = 10;
            int n2 = 20;
            double sum = Topla(n1, n2);
           
            Console.WriteLine(sum);

            Console.WriteLine(Topla(100,200,300));

            sum = Topla(1, 10, 21, 33);
            Console.WriteLine(sum);

            Topla("sayıların toplamı:", 1, 3, 5, 7, 9);
        }


        static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        static double DoubleTopla(double sayi1,double sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla(int sayi1,int sayi2,int sayi3)
        {
            return sayi1 + sayi2+sayi3;
        }

        static int Topla(params int[] sayilar)
        {
            return sayilar.Sum();
        }

        static void Topla(string mesaj,params int[] sayilar)
        {
            Console.WriteLine($"{mesaj}:{sayilar.Sum()}");
        }
    }
}