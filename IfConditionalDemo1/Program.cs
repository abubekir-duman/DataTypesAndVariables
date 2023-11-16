namespace IfConditionalDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yasSonucu, giris;
            int yas;
            Console.WriteLine("yaş:");
            giris = Console.ReadLine();
            yas = Convert.ToInt32(giris);

            if (yas >= 0 && yas < 30)
            {
                yasSonucu = "genç";
            }
            else if (yas >= 30 && yas < 60)
            {
                yasSonucu = "orta yaşlı";
            }
            else
            {
                yasSonucu = "yaşlı";
            }

            Console.WriteLine("yaş:"+yas+"yaş grubu"+yasSonucu);
        }
    }
}