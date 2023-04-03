public class Battle:Battlestats
{

    public Battle(int shield, int transport, int guns, int defense, int artillery) :base(shield, transport, guns, defense, artillery)
    {
        
    }
    public void CheckInventory()
    {
        Console.Clear();
        Console.WriteLine($"Shield Level: {GetShield()}");
        Console.WriteLine($"Artillery Ammo: {GetArtillery()}");
        Console.WriteLine($"Gunships: {GetGuns()}");
        Console.WriteLine($"Defensive Ships: {GetDefense()}");
        Console.WriteLine($"Transport Units: {GetTransport()}");
        Console.WriteLine();
    }

    public override void GiveInstructions()
    {
        Console.WriteLine("This activity is essentially rock paper scissors but with a few extra rules.");
        Console.WriteLine("Gun Ships: Is destroyed by artillery, but can fly past defense ships.");
        Console.WriteLine("Defense Ships: Can absorb artillery fire, but gun ships easily pass them.");
        Console.WriteLine("Artillery: Takes out gun ships, but shots are absorbed by defense ships. If both you and your enemy fire their artillery, both ships will take a hit and a transport ship will escape.");
        Console.WriteLine();
        Console.WriteLine("Your objective is to send out all of the transport units before your ship is destroyed.");
        Console.WriteLine("When you win a round, you send out automatically send out a transport unit.\n");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }

    public override void StartGame()
    {
        
    }
}