
namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kısaltma:");
            string kisaltma = Console.ReadLine();
           // KisaltmayaGoreOyunYazdirIf(kisaltma);
            KisaltmayaGoreOyunYazdirSwitch(kisaltma);
        }

        static void KisaltmayaGoreOyunYazdirSwitch(string kisaltma)
        {
            switch (kisaltma)
            {
                case "HL":
                    Console.WriteLine("Half Life");
                    break;
                case "CS":
                    Console.WriteLine("Contour Strike");
                    break;
                case "GTA":
                    Console.WriteLine("Grand Theft Auto");
                    break;
                case "RDR":
                    Console.WriteLine("Read Dead Redepthon");
                    break;

            }
                
            
        }

        static void KisaltmayaGoreOyunYazdirIf(string kisaltma)
        {
            if (kisaltma == "HL")
                Console.WriteLine("Half Life");
            else if (kisaltma == "CS")
                Console.WriteLine("Contour Strike");
            else if (kisaltma == "GTA")
                Console.WriteLine("Grand Theft Auto");
            else if (kisaltma == "RDR")
                Console.WriteLine("Read Dead Redepthon");
        }
    }
}
