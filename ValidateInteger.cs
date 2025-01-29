string? readResult;
bool validEntry = false;
int numericValue = 0;
Console.WriteLine("Enter an integer between 5 and 10");

do{
    readResult = Console.ReadLine();
    validEntry = int.TryParse(readResult, out numericValue);
    if (readResult != null)
    if(validEntry == true){
        if ((numericValue > 5)&&(numericValue < 10))
        {
            Console.WriteLine($"Your input value {numericValue} has been accepted.");break;
        }
        else if((numericValue <= 5)||(numericValue >= 10))
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }}
        else 
        {   validEntry = false;
            Console.WriteLine("Sorry, please try again.");
        }
    
} while ((numericValue <= 5) || (numericValue >= 10));
