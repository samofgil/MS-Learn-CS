//Greets user differently based on their level and admin/manager status.
    //Uses RNG to determine both factors on runtime.

Random random = new Random();
int level = random.Next(1, 111);
string permission = "Admin|Manager";

if (random.Next(2)==1)
{
    permission = "Manager";
}

if (permission.Contains("Admin"))
{
    Console.WriteLine($"(Level {level} Administrator)");
    if (level>55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine($"(Level {level} Manager)");
    if (level>55)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}   
