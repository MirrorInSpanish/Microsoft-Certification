string? readResult;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {  
        readResult = readResult.Trim().ToLower();
        if(readResult.Contains("administrator"))
    {
            Console.WriteLine("Welcome Administrator");
    }
        else if(readResult.Contains("manager"))
        {
            Console.WriteLine("Welcome Manager");
        }
        else if(readResult.Contains("user"))
        {
            Console.WriteLine("Welcome User");
        }
        else
        {
            
            Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            readResult = null;
        }
    }
} while (readResult == null);
