class Enemy
{
    private int enemyHP;
    public int EnemyHP
    {
        get { return enemyHP; }
        set { enemyHP = value; }
    }
    
    public virtual void EnemyDoDamage(Player character, int amount)
    {
        character.PlayerHP -= amount;
        Console.WriteLine("Enemy gör " + amount + " skada");
    }
}