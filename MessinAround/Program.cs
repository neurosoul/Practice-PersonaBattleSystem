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
using System.Security.Cryptography;



//
Random eihaDamage = new Random();
Random agiDamage = new Random();
Random knifeDamage = new Random();
Random enemyDamage = new Random();


int enemyHP = 150;
int jokerHP = 200;

do
{
    Console.WriteLine("A Jack Frost is before you! \nWhat will you do? \n > (1) Persona (2) Attack ");

    int playerTurn = Convert.ToInt32(Console.ReadLine());

    if (playerTurn == 1)
    {
        Console.WriteLine("Persona! \nAbilities: \n > (3) Eiha (4) Agi");
        int personaChoice = Convert.ToInt32(Console.ReadLine());
        if (personaChoice == 3)
        {
            int eiha = eihaDamage.Next(20, 41);
            Console.WriteLine($"{eiha} Damage!");
            enemyHP -= eiha;
            Console.WriteLine($"{enemyHP} Health remaining!\n");

            int bufu = enemyDamage.Next(35, 56);
            Console.WriteLine($"Jack Frost Uses Bufu!\n{bufu} damage!");
            jokerHP -= bufu;
            Console.WriteLine($"You have {jokerHP} HP.\n");
        }

        else if (personaChoice == 4)
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

        int bufu = enemyDamage.Next(35, 56);
        Console.WriteLine($"Jack Frost Uses Bufu!\n{bufu} damage!");
        jokerHP -= bufu;
        Console.WriteLine($"You have {jokerHP} HP.\n");
    }
} while (enemyHP > 0 && jokerHP > 0);


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