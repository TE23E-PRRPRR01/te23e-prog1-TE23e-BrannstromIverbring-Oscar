/*********************************
***************MAIN***************
********************************** */

Console.Clear();
Console.WriteLine("Hej metoder!");

SägHejNamn("Valentin");

/*********************************
***************METODER************
********************************** */

static void SägHejNamn(string namn)
{
    Console.WriteLine("Hej på dig!");
}

static void TalKvadrat (int tal)
{
    Console.WriteLine($"tal i kvadrat = {tal * tal}");
}