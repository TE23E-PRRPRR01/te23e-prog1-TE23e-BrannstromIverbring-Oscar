// Ett litet nummerregister


Console.Clear();
Console.WriteLine("Ett litet nummerregister");
List<string> namnlista = [];

// Programloppen
while (true)
{
        // Visa en meny
    Console.WriteLine("""
1. Registrera namn
2. Skriv ut alla namn
3. Avsluta programmet
""");
        string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("Ange ett namn: ");
        string namn = Console.ReadLine();
        namnlista.Add(namn);
    }

    else if (val == "2")
    {
        foreach (var namnet in namnlista)
        {
            Console.Write($"{namnet}, ");
        }
        Console.WriteLine();
    }

    else if (val == "3")
    {
        break;
    }
}
