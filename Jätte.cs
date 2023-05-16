class Jätte : Enemy
{
    public Jätte(int hp)
    {
        EnemyHP = hp;
    }

    public override void EnemyDoDamage(Player character, int amount)
    {
        character.PlayerHP -= amount;
        Console.WriteLine("Jätte gör " + amount + " skada");
    }
}