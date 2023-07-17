// Welcome Statement

Console.WriteLine("Welcome to the Pig Latin Translator.");

//Provides a line space

Console.WriteLine();

// Loops Program

bool runProgram = true;

while (runProgram)
{
    
    //Gathers user input and stores it in lower case

    Console.WriteLine("Please enter a word.");
string input = Console.ReadLine().ToLower();

    //Determines output to user for words containing a number

     if (FindsNumber(input) > 0)
    {
        Console.WriteLine($"{input} can not translate words containing numbers" );
    }

     //Determines output to user for words containing symbols

    else if (FindsSymbol(input) > 0)
    {
        Console.WriteLine($"{input} can not translate words containing symbols");
    }

    //Determines output to user for words starting with a vowel

    else if (StartsWithVowel(input))
    {
        Console.WriteLine($"{input}way");
    }

    //Determines output to user for words starting with a consonant
        
    else if (StartsWithConst(input) >= 0)

    {
        string firstHalfWord = input.Substring(0, StartsWithConst(input));
        string secondHalfWord = input.Substring(StartsWithConst(input));

        Console.WriteLine(secondHalfWord + firstHalfWord + "ay");

    }
     //Ensures user entered text

   else 
    {
        Console.WriteLine("Invalid entry, please enter text");
    }

    //asks user if they want to translate another word

    while (true)
    {
        Console.WriteLine("Would you like to translate another word? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            runProgram = true;
            break;

        }
        else if (choice == "n")
        {
            runProgram = false;
            Console.WriteLine("Goodbye");
            break;
        }
        else
        {
            Console.WriteLine("invalid response, please enter y or n");
            
        }
    }
}
//Method to determine if word starts with a vowel

static bool StartsWithVowel(string input)
{
    if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u')
    {
        return true;
    }
    else
    { 
        return false;
    }
}
//Method to determine if word starts with a consonant

static int StartsWithConst(string input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
        {
            return i;
        }
    }
    return -1;
}
//Method determines if word contains numbers
static int FindsNumber(string input)
{ 
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] >= '0' && input[i] <= '9') 
        {
            return i;

        }
    }
    return -1;
}
//Method determines if word contains symbols
static int FindsSymbol(string input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '?' || input[i] == ':' || input[i] == '!' || input[i] == '@' || input[i] == '#' || input[i] == '$' || input[i] == '%' || input[i] == '(' || input[i] == ')' || input[i] == '&' || input[i] == '*')
        {
            return i;

        }
    }
    return -1;
}

