// Spelet - gissa ett slumptal
Console.Clear();
Console.WriteLine("Spelet - gissa ett tal mellan minimum och maximum");

// Slumpar ett tal
Console.Write("Ange minvärde: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange maxvärde: ");
int max = int.Parse(Console.ReadLine());

int slumptal = Random.Shared.Next(min, max + 1);
int försök = 0;

// Upprepning - loop
while (true)
{
    //Ställ frågan till användaren
Console.Write($"Gissa ett tal ({min}-{max}): ");
int gissning = int.Parse(Console.ReadLine());

försök++; 

    //Kontroll om gissning är rätt
if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat! Du gissade rätt på {försök} försök.");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }     

    //Vill användaren gissa en gång till?
    Console.Write("Vill du fortsätta? (Y/N): ");
    string svar = Console.ReadLine().ToLower();
    if (svar == "Y")
    {
        break;
    }
}
// Slut på spelet
Console.WriteLine("Slut!, Tack för att du spelade mitt spel!");