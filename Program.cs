namespace Övningar_konvert_10_09_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nivå 1

            // Öv 1
            // Skriv ett program som ber användaren mata in en temperatur i Celsius.
            // Konvertera texten till ett decimaltal och räkna om till Fahrenheit med formeln F = C × 9/5 + 32.
            // Skriv ut resultatet.

            Console.WriteLine("Nivå 1" +
                "\n Öv 1" +
                "\n");
            Console.Write("Mata in temperaturen i Celsius: ");
            double tempIn = Convert.ToDouble(Console.ReadLine());
            double tempOut = tempIn * 9 / 5 + 32;
            Console.WriteLine($"Din temperatur i Fahrenheit: {tempOut}\n");




            // Öv 2
            //Be användaren mata in ett heltal.
            //Använd TryParse för att kontrollera inmatningen.
            //Om användaren skriver något som inte är ett tal ska programmet skriva "Fel inmatning" istället för att krascha.

            Console.WriteLine("Öv 2" +
                "\n");
            while (true)
            {
                Console.Write("Mata in ett heltal: ");
                string inputHeltal = Console.ReadLine();
                if (int.TryParse(inputHeltal, out int resultat))
                {
                    Console.WriteLine($"{resultat} är ett heltal!" +
                        $"\n");
                    break;
                }
                else
                {
                    Console.WriteLine($"{inputHeltal} är inte ett heltal." +
                        $"\nVänligen försök igen.\n");
                    continue;
                }
            }

            // Öv 3
            // Skapa ett program som slumpar fram ett tärningsslag mellan 1 och 6 och skriver ut resultatet.
            // Låt användaren trycka Enter för att slå igen.
            
            Console.WriteLine("Öv 3" +
                "\n");
            Console.WriteLine("Tryck på enter för att kasta tärningen, tryck på valfri tangent för att avsluta: ");
            while(true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Random rnd = new Random();
                    Console.WriteLine($"Tärningen landade på: {rnd.Next(1, 6)}");
                    continue;
                }
                else
                {
                    Console.WriteLine("Programmet avslutas.");
                    break;
                }
            }
        }
    }
}
