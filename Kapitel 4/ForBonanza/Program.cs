Console.Clear();

Console.WriteLine("Ange startvärde: ");
string startvärde = Console.ReadLine();
int.TryParse(startvärde, out int start);

Console.WriteLine("Ange slutvärde: ");
string slutvärde = Console.ReadLine();
int.TryParse(slutvärde, out int slut );


for (var i = start; i < slut + 1; i++)
{
    Console.WriteLine(i);
}


int summa = 0;
for (var i = 0; i < 11; i++)
{
    summa += i;
    Console.WriteLine(i);
}

 Console.WriteLine($"Summan av siffrorna 1 till 10 är: {summa}");

Console.WriteLine("Ange startvärde: ");
string start2 = Console.ReadLine();
int.TryParse(start2, out int stvärde);

Console.WriteLine("Ange slutvärde: ");
string slut2 = Console.ReadLine();
int.TryParse(slut2, out int slvärde);

int summan = 0;

for (var i = stvärde; i < slvärde + 1; i++)
{
    summan += i;
    Console.WriteLine(i);
}
  Console.WriteLine($"Summan av siffrorna {stvärde} till {slvärde} är: {summan}");


Console.Write("Jämna tal: ");
for (var i = 2; i < 21; i+=2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();

Console.Write("Udda tal:");
for (var i = 1; i < 21; i+=2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();


Console.Write("Ange ett tal: ");
string tal = Console.ReadLine();
int.TryParse(tal, out int talet);

for (var i = 0; i < 11; i++)
{
    int summa3 = talet * i;
    Console.WriteLine($"{talet} x {i} = {summa3}");
}

for (var i = 0; i < 6; i++)
{
    
}