// Program som simulerar kända Engineering Flowchart
using System.Diagnostics.CodeAnalysis;

Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

// Visa en Ascii art
Console.WriteLine($"""

                       -   ,--_--.
               -           \      `.
                      -     "-_ _   \
     -                         / F   )
                   -     -    / / `--'
              -              / /
                   -        / /
            -            __/ /
                        /,-pJ
           -        _--"-L ||
                  ,"      "//
     -           /  ,-"".//\
                /  /     // J____
               J  /     // L/----\
   .           F J     //__//^---'
     `     ___J  F    '----| |
  `       J---|  F         F F
`   `. `   `--J  L        J  F
    .   .`     L J       J  F
       .  .    J  \    ,"  F
         .  `.` \  "--"  ,"
    hs      ` ``."-____-"

""");

Console.Write("Does it move? (Y/N)");
string answer = Console.ReadLine();

// Kolla om svar är ja eller nej
if (answer == "Y")
{ // Y
Console.Write("Should it? (Y/N)");
answer = Console.ReadLine();
if (answer == "Y")
{
    Console.Write("No problem!");
}
else
{
    Console.Write("Please use duct tape");
}
}
else
{ // N
    Console.Write("Should it (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.Write("Please use WD-40!");
    }
    else
    {
        Console.Write("No problem!");
    }
}