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
            int actionOne = 1;
            int actionTwo = 2;
            int actionThree = 3;
            int actionFour = 4;
            int actionFive = 5;

            string feed = "Feed";
            string play = "Play";
            string rest = "Rest";
            string checkStatus = "Check Status";
            string exit = "Exit";

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
            }

            // Display options for user interaction
            Console.WriteLine("Choose an action:");
            Console.WriteLine($"{actionOne}. {feed}");
            Console.WriteLine($"{actionTwo}. {play}");
            Console.WriteLine($"{actionThree}. {rest}");
            Console.WriteLine($"{actionFour}. {checkStatus}");
            Console.WriteLine($"{actionFive}. {exit}");
            Console.WriteLine();

            // Get user choice
            Console.WriteLine("Enter your choice (1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine());

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
                    Pet_Status_Monitoing.CheckStatus(hunger, happiness, health, selectedPet);
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