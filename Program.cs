using System.IO;

class Program
{
    public static void Main()
    {
        bool goblinActive = false;
        bool jätteActive = false;
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
            while (player.PlayerHP > 0)
            {
                Console.WriteLine("tryck a för att attackera");
                string attackinput1 = Console.ReadLine();
                if (attackinput1 == "a")
                {
                    int attack1 = rnd.Next(15, 20);
                    if (jätteActive == true)
                    {
                        Console.WriteLine("Du gör " + attack1 + " skada på jätte");
                        jätte.JätteTakeDamage(attack1);
                    }
                    else if (goblinActive == true)
                    {
                        Console.WriteLine("Du gör " + attack1 + " skada på goblin");
                        goblin.GoblinTakeDamage(attack1);
                    }
                    Console.WriteLine("Nu attackera din fiende");
                    if (goblinActive == true)
                    {
                        int goblinAttack1 = rnd.Next(1, 20);
                        Console.WriteLine("Goblin gör " + goblinAttack1 + " skada");
                        player.PlayerTakeDamage(goblinAttack1);
                    }
                    if (jätteActive == true)
                    {
                        int jätteAttack1 = rnd.Next(5, 10);
                        Console.WriteLine("Jätte gör " + jätteAttack1 + " skada");
                        player.PlayerTakeDamage(jätteAttack1);
                    }
                    if(goblin.GoblinHP <= 0)
                    {
                        Console.WriteLine("Du dödade en goblin och fick en poäng men en ny goblin spawnade");
                        goblin.GoblinHP = 50;
                        player.Points += 1;
                    }
                    if(jätte.JätteHP <= 0)
                    {
                        Console.WriteLine("Du dödade en jätte och fick en poäng men en ny jätte spawnade");
                        jätte.JätteHP = 150;
                        player.Points += 1;
                    }
                    Console.WriteLine("Ditt hp: " + player.PlayerHP);
                    Console.WriteLine("Jättens hp: " + jätte.JätteHP);
                    Console.WriteLine("Goblins hp: " + goblin.GoblinHP);
                }
                else
                {
                    Console.WriteLine("Fel, börja om och försök igen");
                    player.PlayerTakeDamage(100);
                }
            }
            Console.WriteLine("Du dog");
            StreamWriter sw = new StreamWriter("DinPoäng.txt");
            sw.WriteLine("Din poäng: " + player.Points);
            sw.Close();

        }
        else
        {
            Console.WriteLine("Fel, börja om och försök igen");
        }

    }
}