public class Finale:Battle
{

    public Finale(int shield, int transport, int guns, int defense, int artillery) :base(shield, transport, guns, defense, artillery)
    {

    }

    private bool _victory = false;

    public int odds;
    public Battle ship = new Battle(5,5,5,5,5);
    public Battle enemy = new Battle(5,0,5,5,5);

    public override void StartGame()
    {

        string input;
        NotSafe();
        ScanPerimeter();
        Console.Clear();

        GiveInstructions();

        while(!_victory)
        {

        ship = new Battle(5,5,5,5,5);
        enemy = new Battle(5,0,5,5,5);

        while (ship.GetShield() != 0 && ship.GetTransport() != 0 && enemy.GetShield() != 0)
        {
        Console.WriteLine(enemy.GetShield());
        ship.CheckInventory();
        Console.WriteLine("1. Deploy Gun Ship");   
        Console.WriteLine("2. Deply Defense Ship");
        Console.WriteLine("3. Fire Artillery");
        input = Console.ReadLine();
        if (input == "1")
        {
            int number = GetEnemyMove();
            if(ship.GetGuns() == 0)
            {
                DisplayMessage("There's no more gun ships. Send something else.", 50);
                Console.Clear();
            }
            else
            {
            ship.SetGuns(ship.GetGuns() - 1);

            if (number == 1)
            {
                DisplayMessage("Enemy Ship sent out a gun ship as well. Both were destroyed in the fight.", 50);
            }
            else if (number == 2)
            {
                enemy.SetShield(enemy.GetShield() - 1);
                ship.SetTransport(ship.GetTransport() - 1);
                DisplayMessage("Enemy Ship sent out a defense ship. A transport unit escaped, and the enemy ship took a hit.", 50);
            }
            else if (number == 3)
            {
                ship.SetShield(ship.GetShield() - 1);
                DisplayMessage("Enemy Ship fired thier artillery. You took a hit.", 50);
            }
            }
        }

        if (input == "2")
        {
            int number = GetEnemyMove();
            if(ship.GetDefense() == 0)
            {
                DisplayMessage("There's no more defense ships. Send something else.", 50);
                Console.Clear();
            }
            else
            {
            ship.SetDefense(ship.GetDefense() - 1);

            if (number == 1)
            {
                ship.SetShield(ship.GetShield() - 1);
                DisplayMessage("Enemy Ship sent out a gun ship. You took a hit.", 50);
            }
            else if (number == 2)
            {
                DisplayMessage("Enemy Ship sent out a defense ship as well. Both ships were destroyed.", 50);
            }
            else if (number == 3)
            {
                enemy.SetShield(enemy.GetShield() - 1);
                ship.SetTransport(ship.GetTransport() - 1);
                DisplayMessage("Enemy Ship fired their artillery. A transport unit escaped.", 50);
            }
            }
        }

        if (input == "3")
        {
            int number = GetEnemyMove();
            if(ship.GetArtillery() == 0)
            {
                DisplayMessage("There's no more artillery ammunition. Send something else.", 50);
                Console.Clear();
            }

            else
            {
            ship.SetArtillery(ship.GetArtillery() - 1);

            if (number == 1)
            {
                ship.SetTransport(ship.GetTransport() - 1);
                enemy.SetShield(enemy.GetShield() - 1);
                DisplayMessage("Enemy Ship sent out a gun ship. A transport unit escaped.", 50);
            }
            else if (number == 2)
            {
                ship.SetShield(ship.GetShield() - 1);
                DisplayMessage("Enemy Ship sent out a defense ship. You took a hit.", 50);
            }
            else if (number == 3)
            {
                enemy.SetShield(enemy.GetShield() - 1);
                ship.SetShield(ship.GetShield() - 1);
                ship.SetTransport(ship.GetTransport() - 1);
                DisplayMessage("Enemy Ship fired their artillery as well. Both ships took a hit, but a transport unit escaped.", 50);
            }
            }
        }

        Console.Clear();
        }

        if (ship.GetShield() == 0)
        {
            DisplayMessage("Shield levels depleted", 50);
            DisplayMessage("Prepare for self destruction", 50);
            Console.Clear();
            DisplayQuery("Let's try that again", 30);
            Dots();
            Console.Clear();
        }

        else if (ship.GetTransport() == 0)
        {
            DisplayMessage("They all made it out. You did it Officer, you're a hero.", 50);
            Console.Clear();
            DisplayMessage("The End", 70);
            _victory = true;
        }

        else
        {
            DisplayMessage("Enemy ship destroyed! Waahooo!", 50);
            Console.Clear();
            DisplayMessage("The End", 70);
            _victory = true;
        }
    }
    }

    public int GetEnemyMove()
    {
        bool hasAmmo = false;
        while (!hasAmmo)
        {

        Random number = new Random();
        odds = number.Next(1, 4);

        if (odds == 1)
        if (enemy.GetGuns() == 0)
        {
            hasAmmo = false;
        }
        else
        {
            enemy.SetGuns(enemy.GetGuns() - 1);
            hasAmmo = true;
        }

        if (odds == 2)
        if (enemy.GetDefense() == 0)
        {
            hasAmmo = false;
        }
        {
            enemy.SetDefense(enemy.GetDefense() - 1);
            hasAmmo = true;
        }

        if (odds == 3)
        if (enemy.GetArtillery() == 0)
        {
            hasAmmo = false;
        }
        {
            enemy.SetArtillery(enemy.GetArtillery() - 1);
            hasAmmo = true;
        }
        }
        return odds;
    }
}