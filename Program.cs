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
            int hunger = 3;
            int happiness = 8;
            int health = 8;
            int actionCount = 0;

            bool run = true;

            bool restart = true;

            while (run)
            {
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

                // Update pet stats based on time passage every two actions, but only if the user input was valid
                if (validActionInput && choiceAction != 5 && actionCount % 2 == 0)
                {
                    hunger++; // Increase hunger over time
                    happiness--; // Decrease happiness slightly over time
                }

                // Check for hunger and happiness conditions only if the user did not choose to check the status or exit
                if (choiceAction != 4 && choiceAction != 5)
                {
                    if (hunger >= 7 && hunger <= 9)
                    {
                        if (choiceAction != 1 && health != 0)
                        {
                            Console.WriteLine("I am hungry :( Please feed me.");
                            Console.WriteLine();
                        }
                        health -= 3;
                    }
                    if (happiness == 3)
                    {
                        if(choiceAction != 2 && health != 0)
                        {
                            Console.WriteLine("I feel lonely and unhappy :( Can you play with me.");
                            Console.WriteLine();
                        }
                            health--;
                    }
                    else if (happiness == 2)
                    {
                        if(choiceAction != 2 && health != 0)
                        {
                            Console.WriteLine("I am depressed. Pleaasssssse - play with me!");
                            Console.WriteLine();
                        }
                        health--;
                    }
                    else if (happiness <= 1)
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
                // Increment action count after each valid action
                actionCount++;
            }

            while (restart)
            {
                // Ask if the user wants to play again
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine();

                // Get user choice
                Console.Write("Enter your choice (1 or 2): ");
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