using ConsoleApp1; 

Dice dice = new Dice();
Console.Write("Enter the number of sides: ");
dice.Side = int.Parse(Console.ReadLine());
Console.Write("Enter a guessing number: ");
int guessNum = int.Parse(Console.ReadLine());
Console.WriteLine($"Your expected number is " + guessNum +  " and result of the rolling the dice is: " + dice.Roll(dice.Side)); 
Console.ReadLine();