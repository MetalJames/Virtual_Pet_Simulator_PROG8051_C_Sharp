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

            int petTypeChoice;

            // This will prevent program from crashing if user will enter anything else besides 1-5(character or any special character)
            while (true)
            {
                Console.WriteLine("User Input: ");
                if (int.TryParse(Console.ReadLine(), out petTypeChoice) && petTypeChoice >= 1 && petTypeChoice <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    Console.WriteLine();
                    Console.WriteLine($"1. {cat}");
                    Console.WriteLine($"2. {dog}");
                    Console.WriteLine($"3. {rabbit}");
                    Console.WriteLine();
                }
            }

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
            }

            // Validate user input
            while (true)
            {
                // Give the pet a name
                Console.WriteLine("Give your pet a name: ");
                petName = Console.ReadLine();

                // Check if the petName contains only letters, numbers, characters, underscore (_), space (' '), dash (-), or period (.)
                if (IsLetterOrNumber(petName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Please enter a name with only letters, numbers, characters, underscore (_), space (' '), dash (-), or period (.).");
                }
            }

            // Display a welcome message
            Console.WriteLine($"Congratulations! You now have a {selectedPet} named {petName}.");
            Console.WriteLine();
        }

        // Helper method to check if a string contains only letters, numbers, characters, underscore (_), space (' '), dash (-), or period (.)
        private static bool IsLetterOrNumber(string? input)
        {
            if(input == null)
            {
                return false;
            }
            foreach (char character in input)
            {
                if (!(char.IsLetterOrDigit(character) || character == '_' || character == ' ' || character == '-' || character == '.'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
