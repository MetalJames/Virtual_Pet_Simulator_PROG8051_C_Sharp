using System;

namespace Virtual_Pet_Simulator_PROG8051_C__
{
    public static class Pet_Creation
    {
        public static void CreatePet(out string selectedPet, out string petName)
        {
            selectedPet = String.Empty;
            Console.WriteLine("Welcome to the Virtual Pet Simulator!");
            Console.WriteLine();

            string cat = "Cat";
            string dog = "Dog";
            string rabbit = "Rabbit";

            // Allow the user to choose a pet type
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine();
            Console.WriteLine($"1. {cat}");
            Console.WriteLine($"2. {dog}");
            Console.WriteLine($"3. {rabbit}");
            Console.WriteLine();

            Console.WriteLine("User Input: ");
            int petTypeChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (petTypeChoice)
            {
                case 1:
                    selectedPet = cat;
                    Console.WriteLine($"You've chosen a {cat}. What would you like to name your pet?");
                    Console.WriteLine();
                    break;
                case 2:
                    selectedPet = dog;
                    Console.WriteLine($"You've chosen a {dog}. What would you like to name your pet?");
                    Console.WriteLine();
                    break;
                case 3:
                    selectedPet = rabbit;
                    Console.WriteLine($"You've chosen a {rabbit}. What would you like to name your pet?");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    Console.WriteLine();
                    break;
            }

            // Give the pet a name
            Console.WriteLine("Give your pet a name: ");
            petName = Console.ReadLine();
            Console.WriteLine();

            // Display a welcome message
            Console.WriteLine($"Congratulations! You now have a {selectedPet} named {petName}.");
            Console.WriteLine();
        }
    }
}
