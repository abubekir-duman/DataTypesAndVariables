namespace IfConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 11;
            Console.WriteLine("sayı:"+sayi);

            if (sayi == 10)
            {
                Console.WriteLine("doğru");
            }
            else
            {
                Console.WriteLine("doğru değil");
            }

            if(sayi>=10&& sayi < 20)
            {
                Console.WriteLine("sayı 10 ile 20 arasındadır");
            }
            else if (sayi >= 20 && sayi < 30)
            {
                Console.WriteLine("sayı 20 ile 30 arasındadır");

            }
            else if (sayi >= 30 && sayi < 40)
            {
                Console.WriteLine("sayı 30 ile 40 arasındadır");
            }
            else
            {
                Console.WriteLine("sayı aralık dışıdır");
            }
        }
    }
}