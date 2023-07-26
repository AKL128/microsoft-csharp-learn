string[] myStrings = new string[2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};

int periodLocation = 0;

string result = "";

for (int i = 0; i < myStrings.Length; i++) 
{
    result = myStrings[i];

    periodLocation = result.IndexOf(".");

    string sentence;

    while (periodLocation != -1)
    {
        sentence = result.Remove(periodLocation);
        result = result.Substring(periodLocation+1);
        result = result.TrimStart();
        periodLocation = result.IndexOf(".");

        Console.WriteLine(sentence);
    }
    
    sentence = result.Trim();
    Console.WriteLine(sentence);
}