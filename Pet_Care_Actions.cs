namespace Virtual_Pet_Simulator_PROG8051_C__
{
    public class Pet_Care_Actions
    {
        // Feed action for the pet
        public static void Feed(ref int hunger, ref int health, ref string petName)
        {
            // Check if the pet is already full
            if (hunger <= 1)
            {
                Console.WriteLine();
                Console.WriteLine("I am full, I can not eat anymore.");
                health -= 2;
                Console.WriteLine();
            }
            else {
                hunger -= 3;
                health++;
                if(hunger <= 0)
                {
                    hunger = 0;
                }
                Console.WriteLine();
                Console.WriteLine($"You feed {petName}, he is very thankful for that :) His hunger, decreases, and health improves slightly.");
                Console.WriteLine();
            }
        }

        // Play action for the pet
        public static void Play(ref int hunger, ref int happiness, ref int health, ref string petName)
        {
            // Check if the pet is in a condition to play
            if ( hunger >= 8 || health <= 3)
            {
                Console.WriteLine();
                Console.WriteLine("I will not play with you, first you have to feed me");
                Console.WriteLine();
            } else
            {
                hunger++;
                happiness += 2;
                Console.WriteLine();
                Console.WriteLine($"That was a nice game with {petName} :)");
                Console.WriteLine();
            }
        }

        // Rest action for the pet
        public static void Rest(ref int health, ref int happiness, ref string petName)
        {
            health += 2;
            happiness--;
            Console.WriteLine();
            Console.WriteLine($"Your {petName} is taking a nap :)");
            Console.WriteLine();
        }
    }
}
