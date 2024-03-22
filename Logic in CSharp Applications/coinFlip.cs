//Simple coin flip program using the conditional operator.
Console.WriteLine("\nHello. Press enter to flip a coin. Type Q and press enter to exit.");
Random coin = new Random();
while(Console.ReadLine().ToUpper()!="Q")
{
  Console.Write((coin.Next(2) == 0) ? "Heads. " : "Tails. ");
}
