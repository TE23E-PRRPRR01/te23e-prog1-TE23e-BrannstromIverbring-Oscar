Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Samlingar");

List<string> listaBöcker = [];

List<string> listaFilmer = ["2001", "I Robot", "Scarface"];

Console.WriteLine($"Alla filmer: {string.Join(", ", listaFilmer)}");

listaBöcker.Add("Pippi");
Console.WriteLine($"Alla filmer: {string.Join(", ", listaBöcker)}");
listaFilmer.Add("Black Witch");
Console.WriteLine($"Alla filmer: {string.Join(", ", listaFilmer)}");

Console.Write("Ange en bok: ");
string nyBok = Console.ReadLine();
listaBöcker.Add(nyBok);
Console.WriteLine($"Alla filmer: {string.Join(", ", listaBöcker)}");

if (listaBöcker.Contains("Bibel"))
{
    Console.WriteLine("Den finns");
    listaBöcker.Remove("Bibel");
}
else
{
    Console.WriteLine("Den finns inte");
}