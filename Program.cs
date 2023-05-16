using System.IO;

class Program
{
    public static void Main()
    {
        bool goblinActive = false;
        bool jätteActive = false;
        Random rnd = new Random();
        Player player = new Player(100);
        Enemy goblin = new Goblin(100);
        Enemy jätte = new Jätte(75);
        player.PlayerState = "I huvudmeny";
        Console.WriteLine("NPC: Hej, följ med mig till staden");
        Console.WriteLine("Tryck k för att gå till staden");
        string playerInput1 = Console.ReadLine();
        if(playerInput1 == "k")
        {
            player.PlayerState = "i staden";
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
            if (goblinActive == false && jätteActive == false)
            {
                Console.WriteLine("NPC: Du är en feg jävel, sånna accepterar jag inte och därför dödar jag dig");
                player.PlayerTakeDamage(100);
            }
            else
            {
                Console.WriteLine("NPC: Nu är det dags att slåss!");
                Console.WriteLine("NPC: Du börjar att attackera");
            }
            while (player.PlayerHP > 0)
            {
                player.PlayerState = "I strid";
                Console.WriteLine("tryck a för att attackera");
                string attackinput1 = Console.ReadLine();
                if (attackinput1 == "a")
                {
                    int attack1 = rnd.Next(15, 20);
                    if (jätteActive == true)
                    {
                        player.PlayerDoDamage(jätte, attack1 / 2);
                    }
                    else if (goblinActive == true)
                    {
                        player.PlayerDoDamage(goblin, attack1 * 2);
                    }
                    Console.WriteLine("Nu attackera din fiende");
                    if (goblinActive == true)
                    {
                        goblin.EnemyDoDamage(player, rnd.Next(1, 20));
                    }
                    if (jätteActive == true)
                    {
                        jätte.EnemyDoDamage(player, rnd.Next(5, 10));
                    }
                    if(goblin.EnemyHP <= 0)
                    {
                        Console.WriteLine("Du dödade en goblin och fick en poäng men en ny goblin spawnade");
                        goblin.EnemyHP = 100;
                        player.Points += 1;
                        Console.WriteLine("Snurra hjulet för att få tillbaka hp eller kanske förlora hp");
                        Console.WriteLine("tryck k för att snurra hjulet");
                        string snurraHjuletInput = Console.ReadLine();
                        if(snurraHjuletInput == "k")
                        {
                            int hjulSnurr = rnd.Next(-30, 50);
                            player.PlayerHP += hjulSnurr;
                            Console.WriteLine("Du fick " + hjulSnurr + " hp");
                        }

                    }
                    if(jätte.EnemyHP <= 0)
                    {
                        Console.WriteLine("Du dödade en jätte och fick en poäng men en ny jätte spawnade");
                        jätte.EnemyHP = 75;
                        player.Points += 1;
                        Console.WriteLine("Snurra hjulet för att få tillbaka hp eller kanske förlora hp");
                        Console.WriteLine("tryck k för att snurra hjulet");
                        string snurraHjuletInput = Console.ReadLine();
                        if(snurraHjuletInput == "k")
                        {
                            int hjulSnurr = rnd.Next(-30, 50);
                            player.PlayerHP += hjulSnurr;
                            Console.WriteLine("Du fick " + hjulSnurr + " hp");
                        }
                    }
                    Console.WriteLine("Ditt hp: " + player.PlayerHP);
                    Console.WriteLine("Jättens hp: " + jätte.EnemyHP);
                    Console.WriteLine("Goblins hp: " + goblin.EnemyHP);
                }
                else
                {
                    Console.WriteLine("Fel, börja om och försök igen");
                    player.PlayerTakeDamage(100);
                }
            }
            player.PlayerState = "död";
            Console.WriteLine("Du är nu " + player.PlayerState);
            StreamWriter sw = new StreamWriter("DinPoäng.txt");
            try
            {
                sw.WriteLine("Din poäng: " + player.Points);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Det blev något fel med filen");
            }

        }
        else
        {
            Console.WriteLine("Fel, börja om och försök igen");
        }

    }
}