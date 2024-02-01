namespace Virtual_Pet_Simulator_PROG8051_C__
{
    public class Pet_Care_Actions
    {
        public static void Feed(ref int hunger, ref int health, ref string selectedPet)
        {
            if (hunger >= 15 && hunger <=17)
            {
                Console.WriteLine();
                Console.WriteLine("I am full, I can not eat anymore.");
                health -= 1;
                Console.WriteLine();
            }
            else {
                hunger += 4;
                if(hunger > 17)
                {
                    hunger = 17;
                }
                health++;
                Console.WriteLine();
                Console.WriteLine($"You feed {selectedPet}, he is very thankful for that :)");
                Console.WriteLine();
            }
        }

        public static void Play(ref int hunger, ref int happiness, ref int health, ref string selectedPet)
        {
            if ( hunger <= 5 || health <= 5)
            {
                Console.WriteLine("I will not play with you, first you have to feed me");
            } else
            {
                hunger--;
                happiness += 3;
                Console.WriteLine();
                Console.WriteLine($"That was a nice game with {selectedPet} :)");
                Console.WriteLine();
            }
        }

        public static void Rest(ref int health, ref int happiness, ref string selectedPet)
        {
            health += 3;
            happiness--;
            Console.WriteLine();
            Console.WriteLine($"Your {selectedPet} is taking a nap :)");
            Console.WriteLine();
        }
    }
}
