int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// converts value1 to decimal, then divides by value 3 - then rounds up and converts to int by using Convert.ToInt32 method.
decimal value4 = (decimal)value1;
var result0 = value4 / value2;
int result1 = Convert.ToInt32(result0);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//converts value3 to decimal value then performs division and assigns value to result2.
decimal value5 = (decimal)value3;
var result2 = value2 / value5;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//converts value1 to float value then performs division and assigns value to result3.
float value6 = (float)value1;
var result3 = value3 / value6;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

/*
Preffered method below:
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

The Convert class is best for converting the fractional decimal numbers into whole integer numbers
Convert.ToInt32() rounds up the way you would expect.

int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/
