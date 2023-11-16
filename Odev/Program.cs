namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double sayi1 = GirisYap("1.sayı:");
            string ıslem = GirisYap1("işlemi giriniz (t:toplama,-:çıkarma,/:bölme,*:çarpma)");
            double sayi2 = GirisYap("2.sayı:");
            double sonuc = IslemYap(sayi1,ıslem,sayi2);
            Console.WriteLine(sonuc);

        }

        static double GirisYap(string mesaj)
        {
            Console.Write(mesaj);
            return Convert.ToDouble(Console.ReadLine());
        }

        static string GirisYap1(string mesaj)
        {
            Console.Write(mesaj);
            return Console.ReadLine();
        }

        //static double IslemYap(double sayi1,string ıslem,double sayi2)
        //{
           
        //    double sonuc;

        //    if (ıslem == "+")
        //    {
        //        sonuc = sayi1 + sayi2;
        //    }
        //    else if (ıslem == "-")
        //    {
        //        sonuc = sayi1 - sayi2;
        //    }
        //    else if (ıslem == "/")
        //    {
        //        sonuc = sayi1 / sayi2;
        //    }
        //    else
        //    {
        //        sonuc = sayi1 * sayi2;
        //    }
        //    return sonuc;
        //}

        static double IslemYap(double sayi1, string ıslem, double sayi2)
        {
            double sonuc=0;
            switch (ıslem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
            }
            return sonuc;
        }

    }
}
