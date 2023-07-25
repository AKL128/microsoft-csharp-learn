Console.WriteLine("Enter an integer value between 5 and 10:");
string readInput;
bool validNumber = false;
int input = 0;
do
{
    readInput = Console.ReadLine();

    if (readInput != null)
    {
        validNumber = int.TryParse(readInput, out input);
    }

    if (validNumber == true)
    {
        if (input <= 5 || input >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }


} while (validNumber == false);

Console.WriteLine($"Your input {input} was accepted");