//Good old FizzBuzz
  //For each i in 1-100, prints "fizz" if i is divisible by 3, and "buzz" if i is divisible by 5.

for (int i=0; i<=100; i++)
{
    Console.Write(i);
    if (i%3==0 && i%5==0)
    {
        Console.Write("\tFizzBuzz!");
    }
    else if (i%3==0)
    {
        Console.Write("\tFizz");
    }
    else if (i%5==0)
    {
        Console.Write("\tBuzz");
    }
    Console.WriteLine();
}
