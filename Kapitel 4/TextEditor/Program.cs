Console.Clear();
Console.WriteLine("""    
    Texteditor
    ============
    """);
// Variabel för valet
string val = "";

// Program som snurrar  tills användaren säger avsluta

while (true)
{
    // Visar en meny och läser användarens val
    Console.Write("""

    Välj ett av följande alternativ:
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta programmet
    """);

    // Läs in användarens val
    val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        Console.WriteLine("Skriv in en text: ");
        string text = Console.ReadLine();
        File.WriteAllText("filnamn.txt", text);
      
    
    }
    else if (val == "2")
    {
        if (File.Exists("filnamn.txt"))
        {
        string text = File.ReadAllText("filnamn.txt");
        Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("Filen finns inte.");
        }
        
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag.");
        break;
    }
    else
    {
        Console.WriteLine("Du valde ett ogiltigt alternativ, försök igen.");
    }
}