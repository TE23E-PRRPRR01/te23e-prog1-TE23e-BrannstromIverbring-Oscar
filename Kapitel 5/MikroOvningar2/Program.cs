Console.Clear();


List<string> listaNamn = ["Torkoal, Camerupt, Slugma, Numel, Ponyta"];
Console.WriteLine($"Min kompisar är: {string.Join(", ", listaNamn)}");

List<string> städer = ["Rustboro, Dewford, Mauville, Lavaridge, Petalburg"];
Console.WriteLine($"Fem städer {string.Join(" , ", städer)} ligger i Hoenn");

List<int> listaÅrtal = [2002, 2003, 2004, 2005, 2006];
Console.WriteLine($"Fem viktiga årtal: {string.Join(", ",listaÅrtal)}");

List<string> namnLista = ["Pelipper", "Politoad", "Thundurus", "Barraskewda", "Primarina"];
Console.WriteLine("Jag har en namnlista med 5 namn:");
Console.WriteLine("Första namnet: " + namnLista[0]);
Console.WriteLine("Sista namnet: " + namnLista[4]);

List<string> bär = ["Oran", "Rawst", "Sitrus", "Pecha", "Lum"];
Console.WriteLine("Mina favorit bär: ");
for (var i = 0; i < 5; i++)
{
    Console.WriteLine(i + ". " + $"{bär[i]}");
}

List<int> listaÅldrar = [18, 22, 25, 30, 35];
Console.WriteLine("Födelse år:");
for (var i = 0; i < 5; i++)
{
    Console.WriteLine(i+1 + ". " + $"{listaÅldrar[i]}");
}
