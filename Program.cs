using System.Threading.Channels;

namespace CarAppMike
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
       
         

         Console.WriteLine("Indtast bilmærke: ");
         string brand = Console.ReadLine();

         Console.WriteLine("Indtast bilmodel: ");
         string model = Console.ReadLine();

         Console.WriteLine("Indtast årgang: ");
         int year = int.Parse(Console.ReadLine());

         Console.WriteLine("Indtast geartype (A for automatisk, M for manuel): ");
         char gearType = (Console.ReadLine()[0]);

         Console.WriteLine($"Dette er biloplysningerne {brand} {model} {year} {gearType}");












        }
    }
}
