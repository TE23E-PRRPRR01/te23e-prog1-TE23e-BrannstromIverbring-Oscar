// Program med meny
Console.Clear();
Console.WriteLine("Program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
// Variabel för valet
string val = "";

// Program som snurrar  tills användaren säger avsluta

while (true)
{
    // Visar en meny och läser användarens val
    Console.Write("""
    Välj ett av följande alternativ:
    1. Omvandla en text till versaler
    2. Omvandla en text till gemener
    3. Avsluta programmet
    """);

    // Läs in användarens val
    val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        Console.Write("Skriv in en text:");
        string texten = Console.ReadLine().ToUpper();
        Console.WriteLine($"Texten i versaler blir: {texten}");
    }
    else if (val == "2")
    {
        Console.Write("Skriv in en text:");
        string texten = Console.ReadLine().ToLower();
        Console.WriteLine($"Texten i gemener blir: {texten}");
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