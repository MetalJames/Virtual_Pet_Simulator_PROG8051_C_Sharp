// Step 1: Pet Creation
Console.WriteLine("Welcome to the Virtual Pet Simulator!");
Console.WriteLine();

int choiceOne = 1;
int choiceTwo = 2;
int choiceThree = 3;

string cat = "Cat";
string dog = "Dog";
string rabbit = "Rabbit";

// Allow the user to choose a pet type
Console.WriteLine("Please choose a type of pet:");
Console.WriteLine();
Console.WriteLine($"{choiceOne}. {cat}");
Console.WriteLine($"{choiceTwo}. {dog}");
Console.WriteLine($"{choiceThree}. {rabbit}");
Console.WriteLine();

Console.WriteLine("User Input: ");
int petTypeChoice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string selectedPet = String.Empty;

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
string petName = Console.ReadLine();

// Display a welcome message
Console.WriteLine($"Congratulations! You now have a {selectedPet} named {petName}.");

// Step 2: Pet Care Actions

int hunger = 5;
int happiness = 5;
int health = 5;

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
            Feed(hunger, health, selectedPet);
            break;
        case 2:
            Play(hunger, happiness, selectedPet);
            break;
        case 3:
            Rest(health, happiness, selectedPet);
            break;
        case 4:
            CheckStatus(hunger, happiness, health, selectedPet);
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

static void Feed(int hunger, int health, string selectedPet)
{
    hunger += 2;
    health++;
    Console.WriteLine();
    Console.WriteLine($"You feed {selectedPet}");
    Console.WriteLine();
}

static void Play(int hunger, int happiness, string selectedPet)
{
    hunger--;
    happiness +=2;
    Console.WriteLine();
    Console.WriteLine($"You feed {selectedPet}");
    Console.WriteLine();
}

static void Rest(int health, int happiness, string selectedPet)
{
    health +=2;
    happiness--;
    Console.WriteLine();
    Console.WriteLine($"You feed {selectedPet}");
    Console.WriteLine();
}

static void CheckStatus(int hunger, int happiness, int health, string selectedPet)
{
    Console.WriteLine();
    Console.WriteLine($"{selectedPet} Status");
    Console.WriteLine($"- Hunger: {hunger}");
    Console.WriteLine($"- Happiness: {happiness}");
    Console.WriteLine($"- Health: {health}");
    Console.WriteLine();
}