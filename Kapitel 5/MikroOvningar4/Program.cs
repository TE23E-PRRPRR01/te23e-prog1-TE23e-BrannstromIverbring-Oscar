
using System.Xml.Schema;

Console.Clear();
Console.WriteLine("Allt om listor");

List<string> listaNamn = [];

listaNamn.Add("Oscar");
listaNamn.Add("Melker");

Console.WriteLine(listaNamn.Count);

Console.WriteLine($"Lista: {listaNamn}");

foreach (var namn in listaNamn)
{
    Console.WriteLine($"- {namn}");
}

Console.WriteLine($"Första elementet: {listaNamn[0]}");

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"{i}- {listaNamn[i]}");
}

for (int i = 0; i < listaNamn.Count; i++)
{
    Console.WriteLine($"{i}- {listaNamn[i]}");
}

List<string> actionSpel = [];
actionSpel.Add("CS");
actionSpel.Add("GTA");

List<string> aventyrSpel = [];

Console.WriteLine("Nu ska du fylla i två action-spel i listan:");

for (var i = 0; i < 2; i++)
{
    Console.Write("Ange ett action-spel: ");
    string svar = Console.ReadLine();
    actionSpel.Add(svar);
}
