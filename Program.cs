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
Console.WriteLine();

// Display a welcome message
Console.WriteLine($"Congratulations! You now have a {selectedPet} named {petName}.");
Console.WriteLine();

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
    // if(hunger <= 3 || happiness <= 3) {
    //     health -= 3;
    // }

    if(hunger >= 15){
        Console.WriteLine();
        Console.WriteLine("You feed me too much! I can not eat any more!");
        health -= 3;
        Console.WriteLine();
    } else if (hunger <= 3 || happiness <= 3)
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
            Feed(ref hunger, ref health, ref selectedPet);
            break;
        case 2:
            Play(ref hunger, ref happiness, ref selectedPet);
            break;
        case 3:
            Rest(ref health, ref happiness, ref selectedPet);
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

static void Feed(ref int hunger, ref int health, ref string selectedPet)
{
    hunger += 4;
    health++;
    Console.WriteLine();
    Console.WriteLine($"You feed {selectedPet}, he is very thankful for that :)");
    Console.WriteLine();
}

static void Play(ref int hunger, ref int happiness, ref string selectedPet)
{
    hunger--;
    happiness +=2;
    Console.WriteLine();
    Console.WriteLine($"That was a nice game with {selectedPet} :)");
    Console.WriteLine();
}

static void Rest(ref int health, ref int happiness, ref string selectedPet)
{
    health +=2;
    happiness--;
    Console.WriteLine();
    Console.WriteLine($"Your {selectedPet} is taking a nap :)");
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

    // Check for critical conditions of our pet
    if (hunger <= 2)
        Console.WriteLine("Your pet is starving! Feed it soon!");
    if (hunger >= 9)
        Console.WriteLine("Your pet is getting too much food! Stop feeding him!");
    if (happiness <= 3)
        Console.WriteLine("Your pet is very unhappy. Play with it to make it happy!");
    if (health <= 1)
        Console.WriteLine("Your pet's health is critical. Take care of its health!");
}