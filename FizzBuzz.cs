//asigns value of 1 to i, checks if i is less than or equal to 100, increments i by 1.
for (int i = 1; i <= 100; i++) {
  //checks to see if i is evenly divisible by 3 & 5, then prints i with the term FizzBuzz.
    if ((i % 3 == 0) && (i % 5 == 0)){
        Console.WriteLine($"{i}-FizzBuzz");
    }
    //checks to see if i is evenly divisible by 3, then prints i with the term Fizz.
    else if (i % 3 == 0) {
        Console.WriteLine($"{i}-Fizz");
    }
    //checks to see if i is evenly divisible by 5, then prints i with the term Buzz.
    else if (i % 5 == 0){
        Console.WriteLine($"{i}-Buzz");
    }
  //prints i if none of the conditions above are met.
    else{
    Console.WriteLine(i);
    }
}
