//Data Conversion & Casting
    //Program Choice Menu (1-2)
string? readResult1;
bool validEntry1 = false;
Console.Write("Please choose Program 1, or Program 2 by typing either \"1\" or \"2\" (Alternatively, Q will quit the application): ");
do
{
    readResult1 = Console.ReadLine();
     if (readResult1 != null)
        {
                if (readResult1=="1" || readResult1=="2")
                {
                    validEntry1 = true;
                }
                else if (readResult1.ToLower()=="q")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Sorry, there is no Program {readResult1} this time.\nPlease input either \"1\" or \"2\" for your choice or we'll be here for a while.");
                }
        }
} while(validEntry1 == false);


//Program 1
    //Combines string array values as both strings and integers.
if (readResult1 == "1")
{
    string[] values = { "12.3", "45", "ABC", "11", "DEF" };

    decimal tempValue = 0;
    string finalString = "";
    decimal finalValue = 0;

    foreach (string value in values)
    {
        Console.Write($"{value} ");
        if (decimal.TryParse(value, out tempValue))
        {
            finalValue += tempValue;
        }
        else
        {
            finalString+=value;
        }
    }

    Console.WriteLine($"\nMessage: {finalString}\nTotal: {finalValue}");
}


//Program 2
    //Performs division with different numeric types.
else if (readResult1 == "2")
{
    int value1 = 11;
    decimal value2 = 6.2m;
    float value3 = 4.3f;
    int result1 = 0;
    decimal result2 = 0;
    float result3 = 0;
    validEntry1 = false;
    Console.WriteLine("\nHello, would you like to run Equation 1 (int division), Equation 2 (decimal division), or Equation 3 (float division)? Please respond in a single digit.");
    do
    {
        readResult1 = Console.ReadLine();
        if (readResult1 != null)
            {
                    if (readResult1=="1" || readResult1=="2" || readResult1=="3" | readResult1=="99")
                    {
                        validEntry1 = true;
                    }
                    else
                    {
                        Console.Write($"Sorry, there is no \"Equation {readResult1}\" at this time.\nPlease input either simply \"1\" or \"2\" or \"3\" for your choice. \n Equation ");
                    }
            }
    } while(validEntry1 == false);

    switch (readResult1)
    {
        case "1":
            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            result1=Convert.ToInt32(value1/value2);
            Console.WriteLine($"\nResult 1: Divide {value1} by {value2}, display the result as an int: {result1}");
            break;
        case "2":
            // Your code here to set result2
            result2=(decimal)value2/(decimal)value3;
            Console.WriteLine($"\nResult 2: Divide {value2} by {value3}, display the result as a decimal: {result2}");
            break;
        case "3":
            // Your code here to set result3
            result3=(float)value3/(float)value1;
            Console.WriteLine($"\nResult 3: Divide {value3} by {value1}, display the result as a float: {result3}");
            break;
        case "99":
            //debug
            result1=Convert.ToInt32(value1/value2);
            Console.WriteLine($"\nResult 1: Divide {value1} by {value2}, display the result as an int: {result1}");
            result2=(decimal)value2/(decimal)value3;
            Console.WriteLine($"Result 2: Divide {value2} by {value3}, display the result as a decimal: {result2}");
            result3=(float)value3/(float)value1;
            Console.WriteLine($"Result 3: Divide {value3} by {value1}, display the result as a float: {result3}");
            break;

    }
}

//TO-DO: let user input string values for both programs.
