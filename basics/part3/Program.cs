Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World\"!");

Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Concatenate
string firstName = "Anthony";
string message = "Hello " + firstName;
Console.WriteLine(message);

string greeting = "Hello";
string message1 = greeting + " " + firstName + "!";
Console.WriteLine(message1);

// avoid intermediat/middle man variable
Console.WriteLine(greeting + " " + firstName + "!");

// Interpolatoin

string message2 = $"{greeting} {firstName}!";


string message3 = $"Hello {firstName}!";
Console.WriteLine(message3);

int version = 11;
string updateText = "Don't update to Windows";
string message4 = $"{updateText} {version}";
Console.WriteLine(message4);

// avoid middle man
Console.WriteLine($"{updateText} {version}!");

// Interpolation and literals

string projectName1 = "First-Project";
Console.WriteLine($@"C:\Output\{projectName1}\Data");

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");