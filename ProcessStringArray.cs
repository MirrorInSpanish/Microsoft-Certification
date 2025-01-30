string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

for (int i = 0; i < stringsCount; i++)
{
    string myString = myStrings[i];
    int periodLocation = myString.IndexOf('.');

    string mySentence;

    while(periodLocation != -1)
    {   //returns new string, removing anything after the "." including the "."
        mySentence = myString.Remove(periodLocation);
        //returns anything after first instance of "."
        myString = myString.Substring(periodLocation + 1);
        //removes white space
        myString = myString.TrimStart();
        //updates the "." index
        periodLocation = myString.IndexOf('.');
        
        Console.WriteLine(mySentence);
    }

mySentence = myString.Trim();
Console.WriteLine(mySentence);
}
