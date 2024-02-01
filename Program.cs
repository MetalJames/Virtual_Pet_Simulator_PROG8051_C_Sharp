using Virtual_Pet_Simulator_PROG8051_C__;

class VirtualPetSimulator
{
    static void Main()
    {
        // Step 1: Pet Creation
        Pet_Creation.CreatePet(out string selectedPet, out string petName);

        // Step 2: Pet Care Actions
        int hunger = 10;
        int happiness = 10;
        int health = 10;

        bool run = true;

        while (run)
        {
            // Update pet stats based on time passage
            hunger -= 1; // Increase hunger over time
            happiness -= 1; // Decrease happiness slightly over time

            if (hunger >= 15)
            {
                Console.WriteLine();
                Console.WriteLine("You feed me too much! I can not eat any more!");
                health -= 3;
                Console.WriteLine();
            }
            else if (hunger <= 3 || happiness <= 3)
            {
                health -= 3;
                Console.WriteLine("I am hungry and unhappy :( Please feed me and play with me.");
            }

            // Display options for user interaction
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Rest");
            Console.WriteLine("4. CheckStatus");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

            // Get user choice
            Console.WriteLine("Enter your choice (1-5): ");

            // This will prevent program from crashing if user will enter anything else besides 1-5(character or any special character)
            bool validInput = int.TryParse(Console.ReadLine(), out int choice);

            if (!validInput || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue; // Restart the loop or handle it accordingly
            }

            // Perform the chosen action
            switch (choice)
            {
                case 1:
                    Pet_Care_Actions.Feed(ref hunger, ref health, ref selectedPet);
                    break;
                case 2:
                    Pet_Care_Actions.Play(ref hunger, ref happiness, ref selectedPet);
                    break;
                case 3:
                    Pet_Care_Actions.Rest(ref health, ref happiness, ref selectedPet);
                    break;
                case 4:
                    Pet_Status_Monitor.CheckStatus(hunger, happiness, health, selectedPet);
                    break;
                case 5:
                    Console.WriteLine("Exiting the Virtual Pet Simulator. Goodbye!");
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}