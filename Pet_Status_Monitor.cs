namespace Virtual_Pet_Simulator_PROG8051_C__;

public class Pet_Status_Monitor
{
    public static void CheckStatus(int hunger, int happiness, int health, string petName)
    {
        Console.WriteLine();
        Console.WriteLine($"{petName}'s Status");
        Console.WriteLine($"- Hunger: {hunger}");
        Console.WriteLine($"- Happiness: {happiness}");
        Console.WriteLine($"- Health: {health}");
        Console.WriteLine();

        // Check for critical conditions of our pet
        if (hunger == 8 || hunger == 9)
        {
            Console.WriteLine($"Your {petName} is starving! Time to eat!");
            Console.WriteLine();
        }
        
        if (happiness <= 3)
        {
            Console.WriteLine($"Your {petName} is very unhappy. Time to play to get happier!");
            Console.WriteLine();
        }

        if (health <= 3)
        {
            Console.WriteLine($"Your {petName}'s health is critical. Take care of {petName}!");
            Console.WriteLine();
        }
    }
}
