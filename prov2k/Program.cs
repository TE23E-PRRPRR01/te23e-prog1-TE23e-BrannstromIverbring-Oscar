Console.Clear();
Console.WriteLine("Filmregister");

List<string> listaFilmer = [];

Console.Write("Ange antal filmer per sida (3-5): ");
int antal = int.Parse(Console.ReadLine());


while (true)
{
Console.Write("""
    1. Lägg till filmer
    2. Lista alla filmer
    3. Sök en film
    4. Avsluta
    Välj ett alternativ:
""");
string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("Ange en film att lägga till: ");
        string film = Console.ReadLine();
    listaFilmer.Add(film);
    }

    else if(val == "2")
    {
    foreach (var filnamn in listaFilmer)
    {
        Console.WriteLine(filnamn);
    }
    }

    else if(val == "3")
    {
        Console.Write("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();

        foreach (var filnamn in listaFilmer)
        {
            if (filnamn.StartsWith(bokstav))
            {
                Console.WriteLine(filnamn);
            }
        }
    }

    else if(val == "4")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Fel val. Försök igen!");
    }
}


