// Program för att hitta BMI
Console.Clear();
Console.WriteLine("Program för att hitta BMI");

// Ange längd i Meter
Console.WriteLine("Ange längd i Meter");
double Meter = double.Parse(Console.ReadLine());

// Ange vikt i Kilogram
Console.WriteLine("Ange vikt i Kilogram");
double Kilogram = double.Parse(Console.ReadLine());

// Konvertera till BMI
double BMI = Kilogram / (Meter * Meter);

// Resultat
Console.WriteLine($"{Meter} meter och {Kilogram} Kilogram blir {BMI} BMI");
