//uses Random.Next to create 3 variables with dice rolls 1-6.
Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

//adds all the rolls together
int total = roll1 + roll2 + roll3;

//prints resul to console
Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) && (roll1 == roll3))    //awards bonus points for rolling the same number 3 times.
{   
    total += 6;
    Console.WriteLine("\nYou rolled triples! +6 bonus to total!");
    Console.WriteLine($"Your new score is: {total}\n");
}
    else if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))  //awards bonus points for rolling the same number 2 times.
{
    total += 2;
    Console.WriteLine("\nYou rolled doubles! +2 bonus to total!");
    Console.WriteLine($"Your new score is: {total}\n");
}

//awards prizes at different tresholds of number totals
if (total >= 16) 
 {
    Console.WriteLine("You win an all expenses paid vacation!\n");
 }   
    else if (total >= 10)
 { 
    Console.WriteLine("You win a brand new laptop!\n");
 }   
    else if (total == 7)
{    
    Console.WriteLine("You win a brand new car!\n");
}    
    else 
{
    Console.WriteLine("Sorry, you lose - but you get to play with our calico kittens!\n");
}
