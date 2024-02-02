using Virtual_Pet_Simulator_PROG8051_C__;

class VirtualPetSimulator
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Pet Creation
            Pet_Creation.CreatePet(out string selectedPet, out string petName);

            // Pet Care Actions
            int hunger = 4;
            int happiness = 11;
            int health = 10;

            bool run = true;

            bool restart = true;

            while (run)
            {
                // Update pet stats based on time passage
                hunger++; // Increase hunger over time
                happiness--; // Decrease happiness slightly over time
                if (happiness < 0)
                {
                    happiness = 0; 
                }

                // Display options for user interaction
                Console.WriteLine("Choose an Action:");
                Console.WriteLine($"1. Feed {petName}");
                Console.WriteLine($"2. Play with {petName}");
                Console.WriteLine($"3. Let {petName} Rest");
                Console.WriteLine($"4. Check {petName}'s Status");
                Console.WriteLine($"5. Exit");
                Console.WriteLine();

                // Get user choice
                Console.Write("Enter your choice (1-5): ");

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
                
                if (hunger >= 7 && hunger <= 9)
                {
                    health -= 3;
                    Console.WriteLine("I am hungry :( Please feed me.");
                    Console.WriteLine();
                }
                if (happiness >= 2 && happiness <= 3)
                {
                    health--;
                    Console.WriteLine("I feel lonely and unhappy :( Can you play with me.");
                    Console.WriteLine();
                }
                else if (happiness == 1)
                {
                    health--;
                    Console.WriteLine("I am depressed. Pleaasssssse - play with me!");
                    Console.WriteLine();
                }
                else if (happiness <= 1)
                {
                    health--;
                    happiness = 0;
                }

                if (hunger == 10 || health == 0)
                {
                    Console.WriteLine("You were very negled. Your pet died :(");
                    Console.WriteLine();
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