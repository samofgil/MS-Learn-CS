//Program Choice (1-3)
    //Lets the user choose between accessing three projects
    //Each program focuses on while-loops/input validation in different ways

string? readResult1;
bool validEntry1 = false;
Console.Write("Choose Program 1, Program 2, or Program 3 by typing \"1\", \"2\" or \"3\": ");
do
{
    readResult1 = Console.ReadLine();
     if (readResult1 != null)
        {
                if (readResult1=="1" || readResult1=="2" || readResult1=="3")
                {
                    validEntry1 = true;
                }
                else
                {
                    Console.WriteLine($"Sorry, there is no Program {readResult1}.\nPlease input either \"1\", \"2\" or \"3\" for your choice or we'll be here for a while.");
                }
        }
} while(validEntry1 == false);


//Code Project 1: Write Code That Validates Integer Input
    //Waits for user to enter valid integer with value between 5 and 10.
    //Gives feedback for bad input.
if (readResult1=="1")
{
    Console.WriteLine("Code Project 1: Integer Input Validation.\n");
    string? readResult;
    bool validEntry = false;
    Console.WriteLine("Enter an integer value between 5 and 10.");
    do
    {
        int numericValue = 0;
        bool validNumber = false;

        readResult = Console.ReadLine();
        if (readResult != null)
        {
            validNumber = int.TryParse(readResult, out numericValue);
            if (validNumber)
            {
                if (numericValue>5 && numericValue<10)
                {
                    validEntry = true;
                }
                else if (numericValue<=5 || numericValue>=10)
                {
                    Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");

                }
                else
                {
                    Console.WriteLine($"You entered input is invalid, please try again.");
                }
            }

        }
    } while (validEntry == false);

    Console.WriteLine($"Your input value ({readResult}) has been accepted.");
}


//Code Project 2: Write Code That Validates String Input
    //Waits for user to enter valid role name as input.
    //Gives feedback for bad input.
else if (readResult1=="2")
{
    Console.WriteLine("Code Project 2: String Input Validation.\n");
    string? readResult;
    bool validEntry = false;
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    do
    {

        readResult = Console.ReadLine();

        if (readResult != null)
        {
                if (readResult.Trim().ToLower()=="administrator" || readResult.Trim().ToLower()=="manager" || readResult.Trim().ToLower()=="user")
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                }

        }
    } while (validEntry == false);

    Console.WriteLine($"Your input value ({readResult}) has been accepted.");
}


//Code Project 3: Write Code That Processes the Contents of a String Array
    //Scans for sentences in a string array by detecting the locations of punctuation.
    //Creates and prints new string to terminal for each sentence detected.
else if (readResult1=="3")
{
    Console.WriteLine("Code Project 3: String Array Validation.\n");
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};
    int periodLocation = 0;
    string myString = "";
    for (int i=0; i<myStrings.Length; i++)
    {
        string mySentence = "";
        myString = myStrings[i];
        periodLocation=myString.IndexOf(".");
        while (periodLocation!=-1)
        {
            Console.Write(myString.Remove(periodLocation));
            myString=myString.Substring(periodLocation+1);
            myString=myString.TrimStart();
            periodLocation=myString.IndexOf(".");
            Console.WriteLine(mySentence);
        }
        mySentence = myString.Trim();
        Console.WriteLine(mySentence);
    }
}
    
