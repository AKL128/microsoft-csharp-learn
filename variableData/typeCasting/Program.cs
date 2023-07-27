
/*          Commented out for Challenge

int first = 2;
string second = "4";
string stringResult = first + second;
Console.WriteLine(stringResult);

decimal myDecimal = 3.14m;
Console.WriteLine($"Decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

int myInt2 = (int)myDecimal;
Console.WriteLine(myInt2);

// Conversion int to string

int first2 = 7;
int second2 = 4;
string message = first2.ToString() + second2.ToString();
Console.WriteLine(message);


// Convert string to int

string first3 = "5";
string second3 = "7";
int sum = int.Parse(first3) + int.Parse(second3);
Console.WriteLine(sum);

// Using convert class

string value1 = "8";
string value2 = "6";
int multiply = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(multiply);

int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);

string value = "252";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

*/

// Combine string array values as strings and as integers
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0m;
decimal validNumber;

foreach (string value in values)
{
    if (decimal.TryParse(value, out validNumber))
    {
        total += validNumber;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

// Output math operations as specific number types

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = value1 / Convert.ToInt32(value2);

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / (float)value1;
// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

