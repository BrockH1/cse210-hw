public class Sequences:Methods
{
    Help help = new Help();
    Beginning beginning = new Beginning();
    Finale finale = new Finale(5,5,5,5,5);

    public override void StartGame()
    {
        beginning.Sequence();
        if (beginning.MakeDecision())
        {

            Console.Clear();
            help.Convo1();

            finale.StartGame();
        }
        else
        {
            Console.Clear();
            DisplayMessage("10 minutes later...", 30);
            Blink("INCOMING MISSLES");
            Console.Clear();
            DisplayMessage("Prepare for impact", 30);
            Console.Clear();
            Thread.Sleep(1000);
            DisplayMessage("You died.", 30);
            Console.Clear();
            Thread.Sleep(1000);
            DisplayMessage("The End.", 70);

        }
    }

    public override void GiveInstructions()
    {
    }
}