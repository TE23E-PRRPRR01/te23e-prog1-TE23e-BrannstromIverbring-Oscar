// Skapa lista med slupade tal
/* *************************************************************
**                           Main                             **
************************************************************* */

// Validera användarens inmatning
using System.Diagnostics;

Console.Clear();

// Deklarera variabler
// Skapa en lista för att spara des slumpade talen
List<int> listaSlumptal = [];

// Fråga igen till användaren matar in ett gilitgt svar
int antal = 0;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas
    Console.Write("Ange antal slumptal: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out antal);

    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Du vill ha {antal} slumptal");

// Användaren mata in min-värde
int min = 0;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas
    Console.Write("Ange minsta slumptal: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out min);

    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Minsta slumptal blir {min}");

// Användaren mata in max-värde
int max = 0;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas
    Console.Write("Ange högsta slumptal: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out max);

    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Högsta slumptal blir {max}");

// Slumpa fram ett antal tal
for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}

static int LäsInHeltal()
{
    int heltal = 0;
    while(true)
    {
        
    }
}
