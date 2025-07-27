using System.Security.Cryptography;
using System.Threading.Channels;

namespace CarAppMike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liste til at gemme bilobjekter
            List<Car> cars = new List<Car>
            {
                new Car("Toyota", "Corolla", 2020, "Red"),
                new Car("Honda", "Civic", 2019, "Blue"),
                new Car("Ford", "Focus", 2021, "Black")
            };


            


            while (true)
            {
                Console.WriteLine("--carsystem menu--");
                Console.WriteLine("1. Read Car Details");
                Console.WriteLine("2. Drive");
                Console.WriteLine("3. Calculate Trip Price");
                Console.WriteLine("4. IsPalindrome");
                Console.WriteLine("5. Print Car Details");
                Console.WriteLine("6. Print All Team Cars");
                Console.WriteLine("7. Afslut programmet");

                Console.WriteLine("Vælg et menu nummer");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Du har valgt at læse biloplysninger");
                        PrintAllTeamCars(cars);


                        // Kald en metode til at læse biloplysninger
                        break;
                    case "2":
                        Console.WriteLine("Du har valgt at køre i bilen");
                        // Kald en metode til at køre i bilen
                        break;
                    case "3":
                        Console.WriteLine("Du har valgt at beregne turpris");
                        // Kald en metode til at beregne turpris
                        break;
                    case "4":
                        Console.WriteLine("Du har valgt at tjekke for palindrom");
                        // Kald en metode til at tjekke for palindrom
                        break;
                    case "5":
                        Console.WriteLine("Du har valgt at udskrive biloplysninger");
                        // Kald en metode til at udskrive biloplysninger
                        break;
                    case "6":
                        Console.WriteLine("Du har valgt at udskrive alle team biler");
                        // Kald en metode til at udskrive alle team biler
                        break;
                    case "7":
                        Console.WriteLine("Afslutter programmet...");
                        return; // Afslutter programmet
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;


                }


            }
            
            static void PrintAllTeamCars(List<Car> cars)
            {
                Console.WriteLine("Alle team biler:");
                foreach (var car in cars)
                {
                    Console.WriteLine($"Mærke: {car.Brand}, Model: {car.model}, Årgang: {car.Year}, Farve: {car.color}");
                }
            }



            /*
            Console.WriteLine("Indtast bilmærke: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Indtast bilmodel: ");
            string model = Console.ReadLine();

            Console.WriteLine("Indtast årgang: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Indtast geartype (A for automatisk, M for manuel): ");
            char gearType = (Console.ReadLine()[0]);

            Console.WriteLine($"Dette er biloplysningerne {brand} {model} {year} {gearType}");


            Console.WriteLine("Indtast fueltype");
            string fuelType = Console.ReadLine();

            Console.WriteLine("Indtast kilometer per liter");
            double kmPerLiter = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast fuelprice");
            double fuelPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast antal kilometer du vil køre");
            double distance = double.Parse(Console.ReadLine());


            double resultFuelNeeded = CalculatefuelNeeded(distance, kmPerLiter);

            double tripCost = calculateTripCost(resultFuelNeeded, fuelPrice);
            Console.WriteLine($"Turen koster: {tripCost}");

            //Variabel til opdateret ordometer stand
            int kmStand = 0;

            kmStand += (int)(Math.Round(distance));


            string formattedString = string.Format("Alle bilens oplysninger  - Tripcost: {0} kmStand: {1} fuelPrice: {2}", tripCost, kmStand, fuelPrice );

            Console.WriteLine(formattedString);




        }

        // This method calculates the amount of fuel needed for a given distance and fuel efficiency.
        // Navnene i Metodens parametre forneden er ikke nødvendigvis det samme som navnene i Metoden der bliver kaldt i Main.
        // Console Writeline i Metoden er bare for at vise hvad der sker i Metoden. Normalt bruger man breakpoints.
        public static double CalculatefuelNeeded(double distance1, double kmPerLiter1)
        {
            Console.WriteLine($"Udregning af turens brændstofsomkostninger {distance1} distance / {kmPerLiter1} kmPerLiter");
            return distance1 / kmPerLiter1;

        }

        // Navnene i Metodens parametre er total ligegyldige. Det er bare to double der bliver ganget med hinanden.
        public static double calculateTripCost(double fuelNeeded1, double fuelPrice1)
        {
            Console.WriteLine($"Vi udregner turen fuelnneeded: {fuelNeeded1} fuelprice {fuelPrice1}");
            return fuelNeeded1 * fuelPrice1;
        }
 */
        }


    }
}
