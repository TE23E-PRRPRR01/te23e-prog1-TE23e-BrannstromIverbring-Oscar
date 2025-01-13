/* ***********************************
   *************MAIN***************
   *********************************** */
Console.Clear();
Console.WriteLine("Hej metoder!");

// Anropa/använd metoden
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

VisaMeny();

RegisterNamn();

/* ***********************************
   *************METODER***************
   *********************************** */

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>

static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}

/// <summary>
/// Metod för att visa en meny
/// </summary>

static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till Uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta
    """);
}

static void RegisterNamn()
{
    Console.Write("Ange namn: ");
    string namn = Console.ReadLine();
    Console.WriteLine($"Hej {namn}");
}