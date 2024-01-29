// Step 1: Pet Creation
Console.WriteLine("Welcome to the Virtual Pet Simulator!");

int choiceOne = 1;
int choiceTwo = 2;
int choiceThree = 3;

// Allow the user to choose a pet type
Console.WriteLine("Please choose a type of pet:");
Console.WriteLine($"{choiceOne}. Cat");
Console.WriteLine($"{choiceTwo}. Dog");
Console.WriteLine($"{choiceThree}. Rabbit");

Console.WriteLine("User Input: ");
int petTypeChoice = Convert.ToInt32(Console.ReadLine());

switch (petTypeChoice)
{
    case 1:
        Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
        break;
    case 2:
        Console.WriteLine("You've chosen a Dog. What would you like to name your pet?");
        break;
    case 3:
        Console.WriteLine("You've chosen a Rabbit. What would you like to name your pet?");
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}

string petType = Console.ReadLine();

// Give the pet a name
Console.Write("Give your pet a name: ");
string petName = Console.ReadLine();

// Display a welcome message
Console.WriteLine($"\nCongratulations! You now have a {petType} named {petName}.");