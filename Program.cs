using Virtual_Pet_Simulator_PROG8051_C__;

class VirtualPetSimulator
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Step 1: Pet Creation
            Pet_Creation.CreatePet(out string selectedPet, out string petName);

            // Step 2: Pet Care Actions
            int hunger = 10;
            int happiness = 10;
            int health = 10;

            bool run = true;

            bool restart = true;

            while (run)
            {
                // Update pet stats based on time passage
                hunger -= 1; // Increase hunger over time
                happiness -= 1; // Decrease happiness slightly over time

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
                bool validActionInput = int.TryParse(Console.ReadLine(), out int choiceAction);

                if (!validActionInput || choiceAction < 1 || choiceAction > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue; // Restart the loop or handle it accordingly
                }

                // Perform the chosen action
                switch (choiceAction)
                {
                    case 1:
                        Pet_Care_Actions.Feed(ref hunger, ref health, ref selectedPet);
                        break;
                    case 2:
                        Pet_Care_Actions.Play(ref hunger, ref happiness, ref health, ref selectedPet);
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
                        playAgain = false;
                        restart = false;
                        break;
                }
                
                if (hunger >= 1 && hunger <= 4)
                {
                    health -= 3;
                    Console.WriteLine("I am hungry :( Please feed me.");
                }
                if (happiness <= 4)
                {
                    health -= 3;
                    Console.WriteLine("I feel lonely and unhappy :( Can you play with me.");
                }

                if (hunger == 0 || health == 0)
                {
                    Console.WriteLine("You were very negled. Your pet died :(");
                    run = false;
                }
            }

            while (restart)
            {
                // Ask if the user wants to play again
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine();

                // This will prevent program from crashing if the user enters anything else besides 1-2 (character or any special character)
                bool validRestartGameInput = int.TryParse(Console.ReadLine(), out int chooseRestartGameAction);

                if (!validRestartGameInput || (chooseRestartGameAction != 1 && chooseRestartGameAction != 2))
                {
                    Console.WriteLine("Invalid input. Please enter either 1 or 2.");
                    continue; // Restart the loop or handle it accordingly
                }
                else
                {
                    restart = false;
                    playAgain = (chooseRestartGameAction == 1);
                }
            }

        }
    }
}