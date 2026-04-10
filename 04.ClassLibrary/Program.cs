Random dice = new Random(); 

int roll = dice.Next(1,7);

Console.WriteLine(roll);

// Create a new instance of the Random class
// Generate a random number between 1 and 6 (inclusive)
// Print the result to the console  

Random dice2 = new();

int roll1 = dice2.Next();
int roll2 = dice2.Next(101);
int roll3 = dice2.Next(50,101);

Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);