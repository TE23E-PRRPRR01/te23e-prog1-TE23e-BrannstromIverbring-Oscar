
Console.Clear();
Console.WriteLine("Welcome to an interactive story");

// Dörr
Console.WriteLine($"""
There is a door in front of you. 
""");

Console.Write("Do you open the door? (Y/N)");
string answer = Console.ReadLine();

// Kolla om svar är ja eller nej
if (answer == "Y")
{ // Y
Console.Write("A lit up room stands in front of you. Do you enter? (Y/N)");
answer = Console.ReadLine();
if (answer == "Y")
{
    Console.Write("Congratulations! There is cake for you!");
}
else
{
    Console.Write("You close the door and move on");
}
}
else
{ // N
    Console.Write("Are you sure? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "N")
    {
        Console.Write("You open the door. A lit up room stands in front of you. Do you enter? (Y/N)");
        answer = Console.ReadLine();
        if (answer == "Y")
        {
            Console.Write("Congratulations! There is cake for you!");
        }
        else
        {
            Console.Write("You close the door and move on. Pondering about what could of been behind the door");
        }
    }
    else
    {
        Console.Write("You move on. Pondering about what could of been behind the door");
    }
}
Console.WriteLine(" The End");