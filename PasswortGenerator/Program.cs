// See https://aka.ms/new-console-template for more information

Console.WriteLine("Willkommen beim Passwort-Generator!");

int pwLength = 0;
bool parsed = false;

while (!parsed)
{
    Console.WriteLine("Bitte gib deine gewünschte Zeichenlänge ein:");
    string inputPwLength = Console.ReadLine();
    parsed = Int32.TryParse(inputPwLength, out pwLength);

    if (!parsed || pwLength <= 0)
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gewünschte Zeichenlänge eingeben:");
        parsed = false;

    }
}

Console.WriteLine("Sollen Sonderzeichen (*, !, ?, +, -, %) enthalten sein?");
Console.WriteLine("(j / n)");
string input = Console.ReadLine().ToUpper();

while (input != "N" && input != "J")
{
    Console.WriteLine("Ungültige Eingabe!");
    Console.WriteLine("Bitte j oder N eingeben!");
    input = Console.ReadLine().ToUpper();
}

char c;
string str = string.Empty;

for (c = 'A'; c <= 'Z'; c++)
{
    str = str + c.ToString();
}

string specialChars = "*!?+-%";

bool sonderZeichen = (input == "J");

if (sonderZeichen) str += specialChars;

var placeholderLoop = string.Empty;
char ch;

Random random = new Random();
for (int i = 0; i <= pwLength; i++)
{
    int num = random.Next(0, str.Length);
    ch = str[num];
    //placeholderLoop = ch.ToString();
    placeholderLoop = placeholderLoop + ch.ToString();
}

Console.WriteLine(placeholderLoop);
Console.ReadKey();
