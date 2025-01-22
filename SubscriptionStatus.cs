//assigns daysUntilExpiration with a random number from 0-11.
Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0; //initializes discountPercentage at 0.

//assigns discount amount based on daysUntilExperiation value.
if (daysUntilExpiration == 1)
{
    discountPercentage = 20;    
}
    else if ((daysUntilExpiration >= 2) && (daysUntilExpiration <= 5))
{
    discountPercentage = 10;
}

//Prints a message to console depending on the random number generated and passed to daysUntilExpiration.
if (daysUntilExpiration == 0)
{
    Console.WriteLine("\nYour subscription has expired.\n");
}
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine($"\nYour subscription expires within a day!\nRenew now and save {discountPercentage}%!\n");
    }
    else if (daysUntilExpiration <= 5)
    {
        Console.WriteLine($"\nYour subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!\n");
    }
    else if (daysUntilExpiration <=10)
    {
        Console.WriteLine("\nYour subscription will expire soon. Renew now!\n");
    }
