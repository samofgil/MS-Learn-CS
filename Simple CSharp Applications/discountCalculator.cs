Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration<=10)
{
    if (daysUntilExpiration<1)
    {
        Console.WriteLine($"Your subscription has expired.");
        return;
    }

    else if (daysUntilExpiration==1)
    {
        Console.WriteLine($"Your subscription expires in a day.");
        discountPercentage=20;
    }

    else if (daysUntilExpiration<=5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
        discountPercentage=10;
    }
    else
    {
        Console.WriteLine($"Your subscription will expire soon. Renew now!");
        return;
    }

    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

