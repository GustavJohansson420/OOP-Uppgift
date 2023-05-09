class Program
{
    public static void Main()
    {
        bool goblinActive;
        bool jätteActive;
        Random rnd = new Random();
        Player player = new Player(100);
        Goblin goblin = new Goblin(50);
        Jätte jätte = new Jätte(150);
        Console.WriteLine("NPC: Hej");
        Console.WriteLine("Tryck k för att gå vidare");
        string playerInput1 = Console.ReadLine();
        if(playerInput1 == "k")
        {
            Console.WriteLine("NPC: Du ska slåss mot monster, välj monster:");
            Console.WriteLine("NPC: Vill du slåss mot Goblin?");
            Console.WriteLine("tryck j för ja tryck n för nej");
            string playerInput2 = Console.ReadLine();
            if(playerInput2 == "j")
            {
                goblinActive = true;
                Console.WriteLine("ja");
            }
            else if(playerInput2 == "n")
            {
                goblinActive = false;
                Console.WriteLine("nej");
            }
            else
            {
                Console.WriteLine("Fel, börja om och försök igen");
            }
            Console.WriteLine("NPC: Vill du slåss mot Jätte?");
            Console.WriteLine("tryck j för ja tryck n för nej");
            string playerInput3 = Console.ReadLine();
            if(playerInput3 == "j")
            {
                jätteActive = true;
                Console.WriteLine("ja");
            }
            else if(playerInput3 == "n")
            {
                jätteActive = false;
                Console.WriteLine("nej");
            }
            else
            {
                Console.WriteLine("Fel, börja om och försök igen");
            }
            Console.WriteLine("NPC: Nu är det dags att slåss!");
            Console.WriteLine("NPC: Du börjar att attackera");
            int attack1 = rnd.Next(10, 20);
            if (goblinActive = true)
            {
                goblin.GoblinTakeDamage(attack1);
            }
        }
        else
        {
            Console.WriteLine("Fel, börja om och försök igen");
        }

    }
}