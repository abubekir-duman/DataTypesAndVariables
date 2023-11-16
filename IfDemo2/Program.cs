namespace IfDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("iki sayı girin:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //string sonuc = HangisiBuyuk(sayi1, sayi2, sayi3);

            //Console.WriteLine(sonuc);

            Console.WriteLine(HangisiBuyuk(5,7,2));
        }

        //static string HangisiBuyuk(int sayi1, int sayi2)
        //{
        //    int buyuk = sayi1;
        //    if (sayi2 > sayi1)
        //        buyuk = sayi2;
        //    return Convert.ToString(buyuk);
        //}

        //static string HangisiBuyuk(int sayi1, int sayi2)
        //{
        //    if (sayi2 > sayi1)
        //    {
        //        return $"sayi2({sayi2})>sayi1({sayi1})";
        //    }
        //    else if (sayi1 == sayi2)
        //    {
        //        return $"sayi1({sayi1})=sayi2({sayi2})";
        //    }
        //    else
        //    {
        //        return $"sayi1({sayi1})>sayi2({sayi2})";
        //    }
        //}

        static string HangisiBuyuk(int sayi1,int sayi2,int sayi3)
        {
            string sonuc = "";

            if(sayi1>sayi2 && sayi1 > sayi3)
            {
                sonuc += $"sayi1{sayi1}";
            }
            else if(sayi2>sayi1 && sayi2 > sayi3)
            {
                sonuc += $"sayi2{sayi2}";
            }
            else
            {
                sonuc += $"sayi3{sayi3}";
            }

            return sonuc;
        }



    }
}