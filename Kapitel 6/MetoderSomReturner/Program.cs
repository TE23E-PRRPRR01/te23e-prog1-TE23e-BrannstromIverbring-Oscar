/* ***************************************
*******************Main*******************
**************************************** */
Console.Clear();

int svar = Addera(3, 5);
Console.WriteLine($"Svaret är {svar}");
Console.WriteLine(Addera(3, 5));
Console.WriteLine($"3 + 5 = {Addera(3, 5)}");
Addera(3, 5);

string namn = "Oscar";
Console.WriteLine($"{namn} baklänges är {VändText(namn)}");

/* ***************************************
*****************METODER******************
**************************************** */

static int Addera(int tal1, int tal2)
{
    int summa = tal1 + tal2;
    return summa;
}

static string VändText(string text)
{
    string omvändText = "";
    for (var i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

double Multiplicera(double tal1, double tal2)
{
    double summa = tal1 * tal2;
    return summa;
}

double Dividera(double tal1, double tal2)
{
    double summa = tal1 / tal2;
    return summa;
}

