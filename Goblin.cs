class Goblin : Enemy
{
    private int goblinHP;

    public int GoblinHP
    {
        get { return goblinHP; }
        set { goblinHP = value; }
    }

    public Goblin(int hp)
    {
        goblinHP = hp;
    }
    public void GoblinTakeDamage(int amount)
    {
        goblinHP -= amount;
    }
    public override void EnemyDoDamage(Player character, int amount)
    {
        character.PlayerHP -= amount;
        Console.WriteLine("Goblin gör " + amount + " skada");
    }
}