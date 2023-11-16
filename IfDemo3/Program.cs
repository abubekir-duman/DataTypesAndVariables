namespace IfDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adSoyad;
            string egitimDurumu;
            string sonuc;
            int yas;
            Console.Write("Ad Soyad:");
            adSoyad = Console.ReadLine();
            Console.Write("Yaş:");
            yas = int.Parse(Console.ReadLine());
            Console.Write("Eğitim Durumu(i:ilkokul veya altı,o:ortaokul,l:lise,ü:üniversite veya üstü):");
            egitimDurumu = Console.ReadLine();

            if(yas>=18 && (egitimDurumu=="l" || egitimDurumu == "ü"))
            {
                sonuc = adSoyad + ",ehliyet alabilirsiniz";
            }
            else
            {
                sonuc = adSoyad + ",ehliyet alamazsınız";            
            }
            Console.WriteLine(sonuc);
        }
    }
}