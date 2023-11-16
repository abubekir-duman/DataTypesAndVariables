namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayHello();
            Sum(1, 3);


            int no1 = 5;
            int no2 = 7;

            Sum(no1, no2);
            Sum(no2 , no1);

            double pi=GetPi();
            Console.WriteLine("pi:"+pi);

            Console.WriteLine(Substract(10,5));

            string sonuc = KurumaGoreCalisanGetir("ÇAĞIL", "ALSAÇ", "MİCROSOFT");
            Console.WriteLine(sonuc);

            Console.WriteLine(DepartmanaGoreGetir("leo","alsaç","istanbul eğitim akademi"));

        }


        static void DisplayHello()
        {
            Console.WriteLine("hello");
        }

        

        static void Sum(int no1,int no2)
        {
            int Sum = no1 + no2;
            Console.WriteLine($"{no1}+{no2}={Sum}");
        }

        static double GetPi()
        {
            return 3.14;
        }

        static long Substract(int number1, short number2)
        {
            return number1 - number2;
        }

        static string KurumaGoreCalisanGetir(string adi,string soyad,string kurum)
        {
            string sonuc= adi+" " + soyad+" " + "isimli çalışan"+" " + kurum +" "+ "kurumunda çalışıyor.";
            return sonuc;
        }

        static string DepartmanaGoreGetir(string ad,string soyad,string kurum="microsoft",string departman = "eğitim")
        {
            return ad + " " + soyad + " " + "isimli çalışan" + " " + kurum + " " + "kurumunda" + " " + departman + " " + "departmanında çalışıyor.";
        }

    }
}