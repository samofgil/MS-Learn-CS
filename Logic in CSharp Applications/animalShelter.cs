//Animal Shelter Database & Info Menu
//Array-based database with 6 variables per entry
//Looping menu with nine choices
//User can add/edit entries
//Can also display entries using criteria


// the ourAnimals array will store the following:
using System.Security.Cryptography.X509Certificates;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

string tempTrait ="XXX";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}


//Menu Display
do
{
    Console.Clear();
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine(" 9. Display all gorillas with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.ToLower()=="exit")
        {
            break;
        }
        menuSelection = readResult.ToLower();
    }
    /*
    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");
    readResult = Console.ReadLine();
    */
    switch(menuSelection)
    {
        case "1":
            Console.WriteLine("");
            for (int i=0; i<maxPets; i++)
            {
                if (ourAnimals[i,0]!="ID #: ")
                {
                    for (int j=0; j<=5; j++)
                    {
                        Console.WriteLine($"{ourAnimals[i,j]}");
                    }
                    Console.WriteLine("");
                }

            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            Console.WriteLine();
            string anotherPet = "y";
            int petCount = 0;

            for (int i=0; i<maxPets; i++)
            {
                if (ourAnimals[i,0]!="ID #: ")
                {
                    petCount++;
                }
            }
            if (petCount<maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We are able to hold {(maxPets-petCount)} more.");
            }
            while (anotherPet=="y" && petCount < maxPets)
            {
                bool validEntry = false;
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' 'cat' or 'gorilla' to begin a new entry.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat" && animalSpecies != "gorilla")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                do
                {
                    int tempAge=0;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out tempAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);
                do
                {
                    Console.Write("Please enter the pet's nickname: ");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "TBD";
                        }
                    }
                } while (animalNickname == "");

                do
                {
                    Console.WriteLine("Please enter a physical description of the pet.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");
                do
                {
                    Console.WriteLine("Please enter a description of the pet's personality.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                petCount++;
                if (petCount<maxPets)
                {
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;

        case "3":
            Console.WriteLine();
            bool flagAgesComplete = true;
            bool flagPhysicalComplete = true;
            for (int i=0; i<maxPets; i++)
            {
                if ((ourAnimals[i,3].Contains("TBD")) && (ourAnimals[i,5]=="Personality: tbd"))
                {
                    Console.WriteLine($"Animal ({ourAnimals[i, 0]}) has no associated nickname nor personality description.");
                    flagAgesComplete=false;
                    flagPhysicalComplete = false;
                }
                else if (ourAnimals[i,3].Contains("TBD"))
                {
                    Console.WriteLine($"Animal ({ourAnimals[i, 0]}) does not have an associated nickname.");
                    flagAgesComplete=false;
                }
                else if ((ourAnimals[i,5]=="Personality: tbd"))
                {
                    Console.WriteLine($"Animal ({ourAnimals[i, 0]}) does not have a personality description.");
                    flagPhysicalComplete = false;
                }
            }
            if (flagAgesComplete && flagPhysicalComplete)
            {
                Console.WriteLine($"All nicknames and personality descriptions are complete.");
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            Console.WriteLine();
            bool flagNamesComplete = true;
            bool flagPersonalityComplete = true;
            for (int i=0; i<maxPets; i++)
            {
                if ((ourAnimals[i,2].Contains("?")) && (ourAnimals[i,4]=="Physical description: tbd"))
                {
                    Console.WriteLine($"Animal ({ourAnimals[i, 0]}) has no associated age nor physical description.");
                    flagNamesComplete=false;
                    flagPersonalityComplete = false;
                }
                else if (ourAnimals[i,2].Contains("?"))
                {
                    Console.WriteLine($"Animal ({ourAnimals[i, 0]}) does not have an associated age.");
                    flagNamesComplete=false;
                }
                else if ((ourAnimals[i,4]=="Physical description: tbd"))
                {
                    Console.WriteLine($"Animal ({ourAnimals[i, 0]}) does not have a physical description.");
                    flagPersonalityComplete = false;
                }
            }
            if (flagNamesComplete && flagPersonalityComplete)
            {
                Console.WriteLine($"All ages and physical descriptions are complete.");
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("Edit - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("Edit - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            do
            {
                Console.WriteLine("Please enter the specified pyhysical characteristic for cats.");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    tempTrait = readResult.ToLower();
                    if (tempTrait == "")
                    {
                        tempTrait = "XX";
                        break;
                    }
                }
            } while (tempTrait == "XXX");

            for (int i=0; i<maxPets; i++)
            {
                if (ourAnimals[i,4].Contains(tempTrait.ToLower()) && (ourAnimals[i, 0].StartsWith("ID #: c")))
                {
                    Console.WriteLine(ourAnimals[i, 3]);
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            do
            {
                Console.WriteLine("Please enter the specified pyhysical characteristic for dogs.");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    tempTrait = readResult.ToLower();
                    if (tempTrait == "")
                    {
                        tempTrait = "XX";
                        break;
                    }
                }
            } while (tempTrait == "XXX");

            for (int i=0; i<maxPets; i++)
            {
                if (ourAnimals[i,4].Contains(tempTrait.ToLower()) && (ourAnimals[i, 0].StartsWith("ID #: d")))
                {
                    Console.WriteLine(ourAnimals[i, 3]);
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "9":
            do
            {
                Console.WriteLine("Please enter the specified pyhysical characteristic for gorillas.");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    tempTrait = readResult.ToLower();
                    if (tempTrait == "")
                    {
                        tempTrait = "XX";
                        break;
                    }
                }
            } while (tempTrait == "XXX");

            for (int i=0; i<maxPets; i++)
            {
                if (ourAnimals[i,4].Contains(tempTrait.ToLower()) && (ourAnimals[i, 0].StartsWith("ID #: g")))
                {
                    Console.WriteLine(ourAnimals[i, 3]);
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:
            Console.WriteLine("Please enter a valid number choice (1-8).");
            break;
    }

} while(true);

/*
Part 1: Structure
COMPLETE:   Code review: review the contents of the Program.cs file.
COMPLETE:   Sample data: convert the if-elseif-else structure to switch-case structure that improves readability.
COMPLETE:   Menu loop: enclose the main menu and menu item selection in a loop that iterates until the user enters "exit".
COMPLETE:   Menu selections: write the code for a switch-case structure that establishes separate code branches for each menu option.
COMPLETE:   Code branches: write placeholder within the menu item branches that provides user feedback until app features are developed.
COMPLETE:   Verification test: perform verification tests for the code that you develop in this exercise.

Part 2: Display ourAnimals array info
COMPLETE:   Outer loop: build the outer loop that iterates through the animals in the ourAnimals array.
COMPLETE:   Data check: write code that checks for existing pet data and displays the pet ID if data exists for a pet.
COMPLETE:   Inner loop: build an inner loop that displays all of the pet characteristics for pets with data assigned.
COMPLETE:   Verification test: perform verification tests for the code that you develop in this exercise.

Part 3: Input Control
COMPLETE:   Calculate petCount: write code that counts the number of pets in the ourAnimals array that have assigned data.
COMPLETE:   Conditional messages: write code to display message output when petCount is less than maxPets.
COMPLETE:   Outer loop: build a loop structure that will be used for entering new ourAnimals array data.
COMPLETE:   Exit criteria: write code that evaluates the exit condition for the "enter new ourAnimals array data" loop.
COMPLETE:   Verification test: perform verification tests for the code you develop in this exercise.

Personal additions:
COMPLETE:   Implement options 3 & 4 (ensure completeness)
   TO-DO:   Implement options 5 & 6 (edit entries)
COMPLETE:   Implement options 7 & 8 (Search Engine/Display under criteria)
COMPLETE:   Add Gorillas to the shelter's capabilities (joining cats & dogs)
*/
