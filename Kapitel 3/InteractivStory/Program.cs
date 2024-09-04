
Console.Clear();
Console.WriteLine("Welcome to an interactive story"); // Välkommen

// Context för berättelsen
Console.WriteLine($"""
There is a door in front of you. 
""");

Console.Write("Do you open the door? (Y/N)"); // Fråga till texten innan
string answer = Console.ReadLine().ToUpper();

// Kolla om svar är ja eller nej
if (answer == "Y")
{ // Y
Console.Write("A lit up room stands in front of you. Do you enter? (Y/N)"); // Fråga om man öppna dörren
answer = Console.ReadLine().ToUpper(); 
if (answer == "Y") // Ja
{
    Console.Write("Congratulations! There is cake for you!"); // Ja Ja
}
else
{
    Console.Write("You close the door and move on."); // Ja Nej
}
}
else
{ // Nej
    Console.Write("Are you sure? (Y/N)"); // Fråga om man inte öppna dörren
    answer = Console.ReadLine().ToUpper();
    if (answer == "N") // Nej Nej 
    {
        Console.Write("You open the door. A lit up room stands in front of you. Do you enter? (Y/N)"); // Om man väljer att öppna dörren vid andra försöket
        answer = Console.ReadLine().ToUpper();
        if (answer == "Y") 
        {
            Console.Write("Congratulations! There is cake for you!"); // Nej Nej Ja
        }
        else
        {
            Console.Write("You close the door and move on. Pondering about what could of been inside the room."); // Nej Nej Nej
        }
    }
    else
    {
        Console.Write("You move on. Pondering about what could of been behind the door."); // Nej Ja
    }
}
Console.WriteLine(" The End"); // Slutet av interactive story