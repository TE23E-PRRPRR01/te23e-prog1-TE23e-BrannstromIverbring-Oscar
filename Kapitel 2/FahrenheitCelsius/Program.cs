// Program för att konvertera Fahrenheit till Celsius^
Console.Clear();
Console.WriteLine("Program för att konvertera från Fahrenheit till Celsius");

// Läs in Fahrenheit
Console.WriteLine("Ange tempraturen i Fahrenheit");
double tempFahrenheit = double.Parse(Console.ReadLine());

// Fa till Ce
double tempCelsius = (tempFahrenheit - 32) * 5 / 9;

// Skriva ut resultatet med decimaler 
Console.WriteLine($"{tempFahrenheit} F blir {tempCelsius} i C");