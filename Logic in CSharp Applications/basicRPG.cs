//Basic RPG combat simulator using RNG
    //Starts by prompting players to name their hero/villain.
    //Hero & monster fight with RNG-based attack values until one health value reaches 0.

Random random = new Random();

Console.Write("Welcome to The Gilchrst Chronicles.\nWhat will your hero's name be for this quest? ");
string heroName = Console.ReadLine();
if (heroName=="")
{
    heroName="Hero";
}
Console.Write("What is the name of their rival? ");
string monsterName = Console.ReadLine();
if (monsterName=="")
{
    monsterName="Monster";
}

int ATK = random.Next(1, 10);
int heroHP = 10;
int monsterHP = 10;
int turn = 0;

do
{
    turn++;
    ATK = random.Next(1, 10);
    if (turn%2!=0) //Player turn
    {
        monsterHP-=ATK;
        Console.WriteLine($"{monsterName} was damaged and lost {ATK} health ({monsterHP} HP)");
    }
    else //Monster turn
    {
        heroHP-=ATK;
        Console.WriteLine($"{heroName} was damaged and lost {ATK} health ({heroHP} HP)");
    }


} while (heroHP>0 && monsterHP>0);

if (heroHP<=0)
{
    Console.WriteLine($"{heroName} loses.");
}
else
{
    Console.WriteLine($"{heroName} wins!");
}


//TO-DO for sequel:
    //Add continue loop
        //Level up after fights
            //amount of fights needed to level up is determined based on current level
            //lose level on loss
        //Stats: Health, Strength, and Speed
            //User picks stat to Increase/Decrease on win/loss
        //Save stats & level to txt file
    //different monster types
        //bad, badder, worse, boss
        //rare chance for helpful encounter
    //Fight menu: Choose to attack, use item, or flee
        //items
            //heal
            //instant win
