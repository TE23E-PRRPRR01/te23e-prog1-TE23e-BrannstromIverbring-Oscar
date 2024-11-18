using System.ComponentModel;

Console.Clear();
//Skapa en loop som körs 10 gånger.
//Varje gång loopen körs ska den skriva ut ditt namn

Console.WriteLine("Vad är ditt namn?");
string namn = Console.ReadLine();
while (namn == "Oscar BI")
{
    Console.WriteLine("Hur många repetitioner?");
    string tal = Console.ReadLine();
    int.TryParse(tal, out int siffra);

    for (int i = 0; i < siffra; i++)
    {
        Console.WriteLine(i + ". " + $"{namn}");
    }
    {
        break;
    }
}

Console.WriteLine("Skriv in ett nytt tal");
string nummer = Console.ReadLine();
int.TryParse(nummer, out int antal);
