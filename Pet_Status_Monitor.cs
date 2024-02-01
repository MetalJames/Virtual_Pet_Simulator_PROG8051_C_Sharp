namespace Virtual_Pet_Simulator_PROG8051_C__;

public class Pet_Status_Monitor
{
    public static void CheckStatus(int hunger, int happiness, int health, string selectedPet)
    {
        Console.WriteLine();
        Console.WriteLine($"{selectedPet} Status");
        Console.WriteLine($"- Hunger: {hunger}");
        Console.WriteLine($"- Happiness: {happiness}");
        Console.WriteLine($"- Health: {health}");
        Console.WriteLine();

        /*    // Check for critical conditions of our pet
            if (hunger <= 2)
                Console.WriteLine("Your pet is starving! Feed it soon!");
            if (hunger >= 9)
                Console.WriteLine("Your pet is getting too much food! Stop feeding him!");
            if (happiness <= 3)
                Console.WriteLine("Your pet is very unhappy. Play with it to make it happy!");
            if (health <= 1)
                Console.WriteLine("Your pet's health is critical. Take care of its health!");*/
    }
}
