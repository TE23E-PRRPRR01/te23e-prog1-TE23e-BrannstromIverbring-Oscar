// Program för att konvertera Celsius till Fahrenheit
Console.Clear();
Console.WriteLine("Program för att konvertera temperaturen i Celsius till Farhrenheit");

// Ange temp i Celsius 
Console.WriteLine("Ange temperaturen i Celsius");
double tempCelsius = double.Parse(Console.ReadLine());

// Konvertera till Fahrenheit
double tempFahrenheit = tempCelsius * 9 / 5 + 32;

//Resultat
Console.WriteLine($"{tempCelsius} Celsius är {tempFahrenheit} Fahrenheit");