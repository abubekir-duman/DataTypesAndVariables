using System.ComponentModel.Design;

namespace IfDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string adSoyad;
           string ogrenciadSoyad  = OgrenciGiris();
           double vize1, vize2, vize3, final,ortalama;
            
            string sonuc;

            if (ogrenciadSoyad != "")
            {
                vize1 = NotGiris("vize1");
                if(vize1>=0 && vize1 <= 100)
                {
                    vize2 = NotGiris("vize2");
                    if(vize2 >= 0 && vize2 <= 100)
                    {
                        final = NotGiris("final");
                        if(final >= 0 && final <= 100)
                        {
                            ortalama = ortalamaHesapla(vize1, vize2, final);
                            if (ortalama >= 60)
                                sonuc = ogrenciadSoyad + "geçti"+ortalama;
                            else
                                sonuc = ogrenciadSoyad + "kaldınız" + ortalama;
                        }
                        else
                        {
                            sonuc = "final 0 ile 100 arasında olmalıdır.";
                        }
                    }
                    else
                    {
                        sonuc = "vize2 0 ile 100 arasında olmalıdır.";
                    }

                }
                else
                {
                    sonuc = "vize1 0 ile 100 arasında olmalıdır.";
                }
            }
            else
            {
                sonuc = "öğrenci adı ve soyadı boş olmaz.";
            }
            Console.WriteLine(sonuc);

        }

         static string OgrenciGiris()
        {
            Console.Write("Öğrenci Ad Soyadı:");
            //string giris = Console.ReadLine();
            //return giris;
            return Console.ReadLine();
        }

        static double NotGiris(string mesaj)
        {
            Console.Write(mesaj + ":");
            //return Convert.ToDouble(Console.ReadLine());
            return Double.Parse(Console.ReadLine());
        }

        static double ortalamaHesapla(double vize1,double vize2,double final)
        {
            const double vize1carpan = 0.2;
            const double vize2carpan = 0.2;
            const double finalcarpan = 0.2;

            return vize1 * vize1carpan + vize2 * vize2carpan + final * finalcarpan;
        }
    }
}