Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode; 
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Välkommen till vår lucktext!");
Console.WriteLine("Ange ditt förnamn");
string förnamn = Console.ReadLine();
Console.WriteLine("Ange ett Adjektiv");
string adjektiv = Console.ReadLine();
Console.WriteLine("Ange en Kroppsdel");
string kroppsdel = Console.ReadLine();
Console.WriteLine("Ange en Plats");
string plats = Console.ReadLine();


Console.WriteLine("En gång fanns det en " + adjektiv + " " + förnamn + " " + "som hade en " + kroppsdel + " " + "som var så stor att han kunde bära hela " + plats + "!");
Console.WriteLine("Tack för att du deltog i våran lucktext!");
