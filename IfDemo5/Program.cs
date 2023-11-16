namespace IfDemo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaslıkYaz();
            double boy = GirisYap("boy(m)");
            double kilo = GirisYap("kilo(kg)");
            double endeks = EndeksHesaplama(boy, kilo);
            Console.WriteLine(endeks);
        }

        static void BaslıkYaz()
        {
            Console.WriteLine("vücut kütle endeksi hesaplama");
        }
        static double GirisYap(string mesaj)
        {
            Console.Write(mesaj);
            return Convert.ToDouble(Console.ReadLine());
        }

        static double EndeksHesaplama(double boy, double kilo)
        {
            return kilo / (boy * boy);
        }
    }
}
