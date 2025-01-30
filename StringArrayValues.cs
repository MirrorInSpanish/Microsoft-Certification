string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string alpha = string.Empty; // or " ";

//attempts to parse value into a decimal and add the decimal values to variable named total,
//if parsing can't be achieved the value is added to alpha for concatenation.
foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    alpha+= value;
}

Console.WriteLine(total);
Console.WriteLine(alpha);
