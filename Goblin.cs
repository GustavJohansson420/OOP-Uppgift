class Goblin : Enemy
{
    public Goblin(int hp)
    {
        EnemyHP = hp;
    }

    public override void EnemyDoDamage(Player character, int amount)
    {
        character.PlayerHP -= amount;
        Console.WriteLine("Goblin gör " + amount + " skada");
    }
}