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
            int happiness = 9;
            int health = 8;

            bool run = true;

            bool restart = true;

            while (run)
            {
                // Update pet stats based on time passage
                hunger++; // Increase hunger over time
                happiness--; // Decrease happiness slightly over time
                // Preventing happiness from falling below 0
                if (happiness < 1)
                {
                    happiness = 1; 
                }
                else if (happiness >= 11)
                {
                    happiness = 10;
                }
                // Preventing health from going above 10
                if (health >= 11)
                {
                    health = 10;
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

                // This will prevent the program from crashing if the user enters anything else besides 1-5 (character or any special character)
                bool validActionInput = int.TryParse(Console.ReadLine(), out int choiceAction);

                if (!validActionInput || choiceAction < 1 || choiceAction > 5)
                {
                    // If input is invalid this will prevent from increasing hunger and decreasing happiness
                    hunger--; // Decrease hunger over time
                    happiness++; // Increase happiness slightly over time
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                // Perform the choosen action
                switch (choiceAction)
                {
                    case 1:
                        Pet_Care_Actions.Feed(ref hunger, ref health, ref petName);
                        break;
                    case 2:
                        Pet_Care_Actions.Play(ref hunger, ref happiness, ref health, ref petName);
                        break;
                    case 3:
                        Pet_Care_Actions.Rest(ref health, ref happiness, ref petName);
                        break;
                    case 4:
                        Pet_Status_Monitor.CheckStatus(hunger, happiness, health, petName);
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Exiting the Virtual Pet Simulator. Goodbye!");
                        run = false;
                        playAgain = false;
                        restart = false;
                        break;
                }

                // Check for hunger and happiness conditions only if the user did not choose to check the status or exit
                if (choiceAction != 4 && choiceAction != 5)
                {
                    if (choiceAction != 1 && hunger == 8 && hunger == 9 && health !=0)
                    {
                        health -= 3;
                        Console.WriteLine("I am hungry :( Please feed me.");
                        Console.WriteLine();
                    }
                    if (choiceAction != 2 && happiness == 3 && health != 0)
                    {
                        health--;
                        Console.WriteLine("I feel lonely and unhappy :( Can you play with me.");
                        Console.WriteLine();
                    }
                    else if (choiceAction != 2 && happiness == 2 && health != 0)
                    {
                        health--;
                        Console.WriteLine("I am depressed. Pleaasssssse - play with me!");
                        Console.WriteLine();
                    }
                    else if (choiceAction != 2 && happiness <= 1 && health != 0)
                    {
                        health--;
                        happiness = 1;
                    }
                }

                // Check for game-ending conditions only if the user did not choose to exit
                if (choiceAction != 5)
                {
                    if (hunger >= 10 || health <= 0)
                    {
                         Console.WriteLine("You were very negled. Your pet died :(");
                         Console.WriteLine();
                         run = false;
                    }
                }
            }

            while (restart)
            {
                // Ask if the user wants to play again
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine();

                // Get user choice
                Console.Write("Enter your choice (1-5): ");
                // This will prevent the program from crashing if the user enters anything else besides 1-2 (character or any special character)
                bool validRestartGameInput = int.TryParse(Console.ReadLine(), out int chooseRestartGameAction);

                if (!validRestartGameInput || (chooseRestartGameAction != 1 && chooseRestartGameAction != 2))
                {
                    Console.WriteLine("Invalid input. Please enter either 1 or 2.");
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Exiting the Virtual Pet Simulator. Goodbye!");
                    restart = false;
                    playAgain = (chooseRestartGameAction == 1);
                }
            }

        }
    }
}