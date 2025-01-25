Console.WriteLine("Enter job title.");
string permission = Console.ReadLine();

Console.WriteLine("Enter security level.");
string levelAsk = Console.ReadLine();
int level = Convert.ToInt32(levelAsk);

if (permission.Contains("Admin") && level > 55)
 {
    Console.WriteLine("Welcome, Super Admin user.");
 } 
    else if (permission.Contains("Admin") && level <= 55)
 {
    Console.WriteLine("Welcome, Admin user.");
 }
    else if (permission.Contains("Manager") && level >= 20)
 {
    Console.WriteLine("Contact an admin for access.");
 }
    else if (permission.Contains("Manager") && level < 20)
 {
    Console.WriteLine("You do not have sufficient privileges.");
 } 
    else
 { 
    Console.WriteLine("You do not have sufficient privileges.");
 }
