Random random = new Random();
int current = random.Next(1, 11);


do
{
    current = random.Next(1, 11);
    if (current >= 8) continue; // skips rest of code and starts again from the top
    // preventing any value to print at and over 8
    Console.WriteLine(current);
} while (current != 7);


/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

