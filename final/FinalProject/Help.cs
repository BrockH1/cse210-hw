public class Help:Start
{

    Sneak sneak = new Sneak();
    public override void Convo1()
    {
        DisplayMessage("Okay, first thing I need you to do is get access to my unit's security cameras.", 50);
        DisplayOptions("You're clearly more capable than I am. Why don't you do it?", "May I ask why that's necessary?", "Fine. But I'll need your help.", "This is making me nervous already.");
        GetResponse();
        DisplayResponse("Because I won't have access to a terminal.", "Because I won't have access to a terminal.", "Sure thing. Just give me a minute.", "Trust me, I'd much rather be in your shoes than mine right now.");
        DisplayMessage("I'll get you to the security's firewall, but you'll have to breach it yourself. Let me know when it's done.", 50);
        Console.Clear();
        HackingGame(_code3, 600, 20, 75);
        DisplayOptions("I'm in.", "Done.", "What's next?", "Ready.");
        DisplayMessage("Okay, I hooked up my phone to your terminal, so I can talk on the move. You should soon be seeing security footage of the basement, where the captain is.", 50);
        DisplayMessage("Watch to see where he goes.", 50);
        sneak.GiveInstructions();
        sneak.StartGame();
        


    }
}