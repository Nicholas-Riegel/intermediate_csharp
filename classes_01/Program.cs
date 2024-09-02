using classes_01;

// VALUE TYPES
int num1 = 10;
int num2 = num1;
num2 = 11; 

Console.WriteLine($"num1 is: {num1}.");
Console.WriteLine($"num2 is: {num2}.");

// REFERENCE TYPES
TeamClass teamA = new();
teamA.Name = "   ";

// TeamClass teamB = teamA;

// teamB.Name = "TeamB";

Console.WriteLine($"teamA name is: {teamA.Name}"); //= "TeamB"
// Console.WriteLine($"teamB name is: {teamB.Name}"); //= "TeamB"