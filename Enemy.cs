class Enemy
{
    public virtual void EnemyDoDamage(Player character, int amount)
    {
        character.PlayerHP -= amount;
        Console.WriteLine("Enemy gör " + amount + " skada");
    }
}