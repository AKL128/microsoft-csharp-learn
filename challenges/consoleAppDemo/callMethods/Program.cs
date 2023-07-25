//Instances (Stateful) vs stateless classes and methods
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Console.WriteLine(dice.Next(1, 7));

// Overloaded methods

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine(); // accepts zero input parameters
Console.WriteLine(text);


Random dice1 = new Random();
int roll1 = dice1.Next(); // returns values ranging from 0 to 2,147,483,647
int roll2 = dice1.Next(101); // specifies 0 to max
int roll3 = dice1.Next(50, 101); // lower and upper bounds

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);