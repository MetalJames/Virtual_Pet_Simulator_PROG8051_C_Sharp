namespace Virtual_Pet_Simulator_PROG8051_C__
{
    public class Pet_Care_Actions
    {
        public static void Feed(ref int hunger, ref int health, ref string selectedPet)
        {
            hunger += 4;
            health++;
            Console.WriteLine();
            Console.WriteLine($"You feed {selectedPet}, he is very thankful for that :)");
            Console.WriteLine();
        }

        public static void Play(ref int hunger, ref int happiness, ref string selectedPet)
        {
            hunger--;
            happiness += 2;
            Console.WriteLine();
            Console.WriteLine($"That was a nice game with {selectedPet} :)");
            Console.WriteLine();
        }

        public static void Rest(ref int health, ref int happiness, ref string selectedPet)
        {
            health += 2;
            happiness--;
            Console.WriteLine();
            Console.WriteLine($"Your {selectedPet} is taking a nap :)");
            Console.WriteLine();
        }
    }
}
