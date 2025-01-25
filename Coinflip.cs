//simulates a flipping coin
//delcares an a new instance of random and assigns the random.next using numbers 0-1 to variable coinflip
Random random = new Random();
int coinflip = random.Next(2);

//Uses conditional operator to determine heads or tails. If coinflip is larger than 0, it equates to Heads, otherwise Tails.
Console.WriteLine ($"Coin landed: {(coinflip > 0 ? "Heads": "Tails" )}");
