/*********************************
***************MAIN***************
********************************** */
Console.Clear();

string meddelande = "Måndag! ";
SkrivVertikalt(meddelande);

string meddelande1 = "Tisdag! ";
SkrivVertikalt(meddelande1);

string meddelande2 = "Onsdag! ";
SkrivVertikalt(meddelande2);

RitaKvadrat(3);
Console.WriteLine();
RitaKvadrat(4);


UpprepaText("Hej", 3);
UpprepaText("Hejsan", 5);

tärning(5);
/*********************************
**************METODER*************
********************************** */

/// <summary>
/// Skriv ett meddelande vertikalt
/// </summary>
/// 
/// <param name="meddelande"></param>

static void SkrivVertikalt(string meddelande)
{
    for (var i = 0; i < meddelande.Length; i++)
    {
        Console.WriteLine(meddelande[i]);
    }
}

static void RitaKvadrat(int sidlängd)


{
    for (int i = 0; i < sidlängd; i++)
    {
        for (int j = 0; j < sidlängd; j++)
        {
            Console.WriteLine("*");
        }
    }
    Console.WriteLine();
}

static void UpprepaText(string text, int antal)
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

static void CelsiusTillFahrenheit(int celsius)
{
    int fahrenheit = celsius * 9 / 5 + 32;
    Console.WriteLine($"{celsius} grader Celsius motsvarar {fahrenheit} fahrenheit");
}

static void tärning(int slumpTal)
{
    for (var i = 0; i < slumpTal; i++)
    {
        Console.WriteLine("Tärningen visar: {Random.Shared.Next(1, 7)}");
    }
}