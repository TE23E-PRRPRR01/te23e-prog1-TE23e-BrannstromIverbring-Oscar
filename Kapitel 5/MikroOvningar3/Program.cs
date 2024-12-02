Console.Clear();

List<string> maträtter = ["Våfflor", "Köttbullar", "Nudlar"];
Console.WriteLine("Alla maträtter: ");
foreach (var mat in maträtter)
{
    Console.WriteLine($" - {mat}");
}

List<int> årtal = [2000, 2001, 2002, 2003, 2004];
Console.WriteLine("Alla årtal i listan: ");
foreach (var år in årtal)
{
    Console.WriteLine($"* {år}");
}

List<int> årtal2 = [2000, 2001, 2002, 2003, 2004];
Console.Write("Alla årtal i listan: ");
foreach (var år2 in årtal2)
{
    Console.Write($"{år2}, ");
}
Console.WriteLine();

List<string> namn = [];
while (true)
{
    Console.Write("Ange ett namn att lägga till (eller 'exit' för att avsluta): ");
    string namn2 = Console.ReadLine();
    if (namn2 == "exit")
    {
        break;
    }
      namn.Add(namn2);
}
foreach (var namn3 in namn)
{
    Console.WriteLine($"Alla namn: {namn3}");
}


List<int> listS = [];
while (true)
{
    Console.Write("Ange en siffra att lägga till (eller '0' för att avsluta): ");
    int siffra = int.Parse(Console.ReadLine());
    if (siffra = "exit")
    {
        break;
    }
      listS.Add(siffra);
}
foreach (var siffra2 in listS)
{
    Console.WriteLine($"Alla namn: {siffra2}");
}

