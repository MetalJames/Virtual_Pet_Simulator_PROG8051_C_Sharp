// Step 1: Pet Creation
Console.WriteLine("Welcome to the Virtual Pet Simulator!");

int choiceOne = 1;
int choiceTwo = 2;
int choiceThree = 3;

string cat = "Cat";
string dog = "Dog";
string rabbit = "Rabbit";

// Allow the user to choose a pet type
Console.WriteLine("Please choose a type of pet:");
Console.WriteLine($"{choiceOne}. {cat}");
Console.WriteLine($"{choiceTwo}. {dog}");
Console.WriteLine($"{choiceThree}. {rabbit}");

Console.WriteLine("User Input: ");
int petTypeChoice = Convert.ToInt32(Console.ReadLine());

string selectedPet = String.Empty;

switch (petTypeChoice)
{
    case 1:
        selectedPet = cat;
        Console.WriteLine($"You've chosen a {cat}. What would you like to name your pet?");
        break;
    case 2:
        selectedPet = dog;
        Console.WriteLine($"You've chosen a {dog}. What would you like to name your pet?");
        break;
    case 3:
        selectedPet = rabbit;
        Console.WriteLine($"You've chosen a {rabbit}. What would you like to name your pet?");
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}

// Give the pet a name
Console.WriteLine("Give your pet a name: ");
string petName = Console.ReadLine();

// Display a welcome message
Console.WriteLine($"Congratulations! You now have a {selectedPet} named {petName}.");