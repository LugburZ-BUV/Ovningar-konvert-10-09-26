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
            // We convert the input to double (decimal)
            double tempIn = Convert.ToDouble(Console.ReadLine());
            // We then use the formula to convert it to Fahrenheit
            // Before printing the result
            double tempOut = tempIn * 9 / 5 + 32;
            Console.WriteLine($"Din temperatur i Fahrenheit: {tempOut}\n");




            // Öv 2
            //Be användaren mata in ett heltal.
            //Använd TryParse för att kontrollera inmatningen.
            //Om användaren skriver något som inte är ett tal ska programmet skriva "Fel inmatning" istället för att krascha.

            Console.WriteLine("Öv 2" +
                "\n");
            // We use a while loop to repeat the instructions/input until we get the correct response
            while (true)
            {
                Console.Write("Mata in ett heltal: ");
                string inputHeltal = Console.ReadLine();
                // If int.TryParse returns True we will print the result and break the loop
                if (int.TryParse(inputHeltal, out int resultat))
                {
                    Console.WriteLine($"{resultat} är ett heltal!" +
                        $"\n");
                    break;
                }
                else
                // If it doesn't return True we will continue the loop until it returns True
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

            // We use a while loop to allow the user to repeat the program
            while(true)
            {
                // If the user presses enter we will generate a new random number from 1-6
                // and print the result, and then continue the loop
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Random rnd = new Random();
                    Console.WriteLine($"Tärningen landade på: {rnd.Next(1, 7)}");
                    continue;
                }
                // If the user presses any other key we will break the loop and exit the program
                else
                {
                    Console.WriteLine("Programmet avslutas.");
                    break;
                }
            }
        }
    }
}
