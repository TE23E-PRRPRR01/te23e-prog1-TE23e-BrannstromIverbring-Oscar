// Använda listor för skapa/hantera samlingar
using System.Collections.ObjectModel;

Console.Clear();

// Lista på trevliga frukter t.ex "äpple", "apelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"]; 

Console.WriteLine($"Min fruktlist: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan:
frukter[0] = "banan";
Console.WriteLine($"Min fruktlist: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Gå igenom listan = loppa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// Skapa en lista på valfri ska (4st)
List<string> artister = ["Kendrick", "Kanye", "Nas", "Jay-Z"];
Console.WriteLine($"Mina favorit artister: {artister[0]}, {artister[1]}, {artister[2]}, {artister[3]}");

//Skriv ut varje sak på samma rad
foreach (var artist in artister)
{
    Console.WriteLine(artist);
}

// Skapa ett register
// En tom lista
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    // Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}