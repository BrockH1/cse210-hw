public class Sequences:Methods
{
    Help help = new Help();
    Start start = new Start();
    Sneak sneak = new Sneak();
    Finale finale = new Finale(5,5,5,5,5);

    public override void StartGame()
    {
        start.Sequence();
        if (start.MakeDecision())
        {
            Console.Clear();
            help.Convo1();
        }
        else
        {
            finale.StartGame();
        }

        finale.StartGame();
    }

    public override void GiveInstructions()
    {
    }
}