using System.Runtime.CompilerServices;

Console.Clear();

Console.WriteLine("Hej Världen!");
Console.WriteLine("Nu mitt första C#-program");

Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();
Console.WriteLine("Hej " + namn);
Console.WriteLine("Vad gillar du på fritiden? " + namn);
string fritiden = Console.ReadLine();
Console.WriteLine("Vad roligt!");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Jag älskar Kendrick Lamar");
