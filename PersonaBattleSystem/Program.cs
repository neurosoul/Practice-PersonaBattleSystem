// dont bully me I'm LEARNING.

/*
Console.WriteLine("Here is your bill, sir... \n > How much is Mr. Krabs' bill?");

int dollas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(dollas + " dollas?!?! Man get this outta my face!");
Console.WriteLine("My apologies, sir... THIS is your bill. \n > How many times more should his true bill be?");

int dollasMult = Convert.ToInt32(Console.ReadLine());
int finalBill = dollas * dollasMult;

Console.WriteLine($"Mr. Krabs views his new bill of ${finalBill}");
Console.WriteLine($"Mr. Krabs screams, and shatters the restaurant. He should not have spent ${finalBill}.");

*/
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;


// actual battle system starts here.
Random eihaDamage = new Random();
Random agiDamage = new Random();
Random knifeDamage = new Random();
Random BulletsFired = new Random();
Random BulletsDamage = new Random();


int enemyHP = 150;
int jokerHP = 200;

do
{
    Console.WriteLine("A Jack Frost is before you! \nWhat will you do? \n > (1) Persona (2) Attack (3) Gun");

    int playerTurn = Convert.ToInt32(Console.ReadLine());

    if (playerTurn == 1)
    {
        Console.WriteLine("Persona! \nAbilities: \n > (4) Eiha (5) Agi");
        int personaChoice = Convert.ToInt32(Console.ReadLine());
        if (personaChoice == 4)
        {
            int eiha = eihaDamage.Next(20, 41);
            Console.WriteLine($"{eiha} Damage!");
            enemyHP -= eiha;
            Console.WriteLine($"{enemyHP} Health remaining!\n");

            enemyAttack();
        }

        else if (personaChoice == 5)
        {
            int agi = agiDamage.Next(40, 61);
            Console.WriteLine($"WEAK! {agi} Damage!");
            enemyHP -= agi;
            Console.WriteLine($"{enemyHP} Health Remaining! \n1 MORE!\n");
        }
    }

    else if (playerTurn == 2)
    {
        int knife = knifeDamage.Next(12, 22);
        Console.WriteLine($"{knife} Damage!");
        enemyHP -= knife;
        Console.WriteLine($"{enemyHP} Health Remaining!\n");

        enemyAttack();
    }

    else if (playerTurn == 3)
    {
        int bullets = BulletsFired.Next(1, 9);
        int gunDamage = BulletsDamage.Next(8, 20);
        int gunDamageTotal = bullets * gunDamage;
        Console.WriteLine($"You fired {bullets} bullets and dealt {gunDamageTotal} Damage!");
        enemyHP -= gunDamageTotal;
        Console.WriteLine($"{enemyHP} Health Remaining!\n");

        enemyAttack();
    }
} while (enemyHP > 0 && jokerHP > 0);



// RESULTS SCREEN
Random xp = new Random();
Random money = new Random();

if (enemyHP <= 0)
{
    int xpGained = xp.Next(50, 71);
    int moneyGained = money.Next(100, 136);
    Console.WriteLine($"Victory!\nXP: {xpGained}\nMONEY:{moneyGained}");
}
else if (jokerHP <= 0)
{
    Console.WriteLine("Defeat...");
};




//ENEMY ATTACK SYSTEM
void enemyAttack()
{ 
    Random enemyAttackRand = new Random();
    Random bufuDamage = new Random();
    Random punchDamage = new Random();
    Random healingHP = new Random();


    int enemyTurn = enemyAttackRand.Next(1, 4);

    if(enemyTurn == 1)
    {
        int bufu = bufuDamage.Next(35, 56);
        Console.WriteLine($"Jack Frost Uses Bufu!\n{bufu} damage!");
        jokerHP -= bufu;
        Console.WriteLine($"You have {jokerHP} HP.\n");
    }

    else if(enemyTurn == 2)
    {
        int enemyPunch = punchDamage.Next(25, 36);
        Console.WriteLine($"Jack Frost Attacks!\n{enemyPunch} damage!");
        jokerHP -= enemyPunch;
        Console.WriteLine($"You have {jokerHP} HP.\n");
    }

    else if(enemyTurn == 3)
    {
        int dia = healingHP.Next(28, 39);
        Console.WriteLine($"Jack Frost Uses Dia!\n{dia} health restored.");
        enemyHP += dia;
        Console.WriteLine($"Jack Frost now has {enemyHP} HP.\n");
    }
};