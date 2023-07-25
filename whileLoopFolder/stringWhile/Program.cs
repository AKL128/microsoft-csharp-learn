Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
string? readInput;
string input = "";
bool validRole = false;

do
{
    readInput = Console.ReadLine();

    if (readInput != null)
    {
        input = readInput.Trim().ToLower();
    }

    if (input.Contains("administrator") || input.Contains("manager") || input.Contains("user"))
    {
        validRole = true;
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"Admin\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (validRole == false);

Console.WriteLine($"Your input value ({input}) has been accepted");