//Randomly generates a total cost and tells User their "total" along with a discount
  //Discount value is based on the total cost being less than or equal to 1000.
//<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
double price = 0;
Random randomNum = new Random();
price = randomNum.Next(2000);
Console.WriteLine($"Your total today is ${price}, so you are eligible for a ${(price>1000 ? 100 : 50)} discount. ");
Console.Write($"Your current updated total comes out to ${price-(price>1000 ? 100 : 50)}. ");
if (price<1000) {Console.WriteLine($"Add ${1000-price} more to your shopping cart's total to receive an additional $50 off from this order.");}
