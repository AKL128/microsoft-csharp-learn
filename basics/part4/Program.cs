int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Anthony";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// append it instead of actually adding
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

// Parenthesis make them actually add
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
// quotient is truncated because it is returned as an int
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);


decimal decimalQuotient = 7.0m / 5;
// these work the same result
// decimal decimalQuotient = 7 / 5.0m;
// decimal decimalQuotient = 7.0m / 5.0m;

// these don't work
// int decimalQuotient = 7 / 5.0m;
// int decimalQuotient = 7.0m / 5;
// int decimalQuotient = 7.0m / 5.0m;
// decimal decimalQuotient = 7 / 5;

Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// casting them as decimals gets results
int first = 7;
int second = 5;
decimal quotientCast = (decimal)first / (decimal)second;
Console.WriteLine(quotientCast);

// modulus shows remainder of divison
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//PEMDAS
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// Increment and decrement

int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.


value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

//before and after incr and decr
value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m)*(5m / 9m);

Console.WriteLine($"The temperature is {celsius} Celsius.");