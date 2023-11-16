using System.Threading.Channels;

namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            int sayi1;
            sayi1 = 11;

            Console.WriteLine("sayı:"+sayi1);
            Console.WriteLine("Max:{0},Min:{1}",int.MaxValue,int.MinValue);


            uint sayi2 = 22;
            Console.WriteLine($"sayı2:{sayi2}");
            Console.WriteLine("Max:{0},Min:{1}", uint.MaxValue, uint.MinValue);
            Console.WriteLine($"max:{Int32.MaxValue},min:{Int32.MinValue}");

            long sayi3 = 3000000000;
            Console.WriteLine("sayi3:"+sayi3);
            Console.WriteLine($"max:{long.MaxValue},min:{long.MinValue}");

            ulong sayi4 = 3000000000000;
            Console.WriteLine($"sayi4:{sayi4}");
            Console.WriteLine($"max:{ulong.MaxValue},min:{ulong.MinValue}");

            short sayi5 = -32000;
            Console.WriteLine(sayi5);
            Console.WriteLine($"max:{short.MaxValue},min:{short.MinValue}");

            ushort sayi6 = 64000;
            Console.WriteLine(sayi6);
            Console.WriteLine($"max:{ushort.MaxValue},min:{ushort.MinValue}");

            byte sayi7 = 0;
            Console.WriteLine(sayi7);
            Console.WriteLine($"max:{byte.MaxValue},min:{byte.MinValue}");

            sbyte sayi8 = -127;
            Console.WriteLine(sayi8);
            Console.WriteLine($"max:{sbyte.MaxValue},min:{sbyte.MinValue}");


            bool durum = false;
            Console.WriteLine(durum);

            double ondalik1 = 1.23;
            Console.WriteLine(ondalik1);
            Console.WriteLine($"max:{double.MaxValue},min:{double.MinValue}");


            float ondalik2 = -9.87f;
            Console.WriteLine(ondalik2);


            decimal ondalik3 = 123.4567m;
            Console.WriteLine(ondalik3);


            char karakter = 'A';
            Console.WriteLine($"karakter:{karakter},ASCII karşılığı:{(int)karakter}");


            int sayi3int = (int)sayi3;
            Console.WriteLine("castlenmiş:" + sayi3int);



            Console.WriteLine($"day is:{Days.Friday}, day value is: {(int) Days.Friday}");




            string adSoyad = "Çağıl Alsaç";
            Console.WriteLine("Tam ad:"+adSoyad);

            var karakter1 = "z";
            Console.WriteLine(karakter1);

            karakter1 = "ç";
            Console.WriteLine(karakter1);
            #endregion
        }

    }
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
}