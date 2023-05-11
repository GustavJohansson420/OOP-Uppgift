class Jätte : Enemy
{
    private int jätteHP;

    public int JätteHP
    {
        get { return jätteHP; }
        set { jätteHP = value; }
    }

    public Jätte(int hp)
    {
        jätteHP = hp;
    }

    public void JätteTakeDamage(int amount)
    {
        jätteHP -= amount;
    }
    public override void EnemyDoDamage(Player character, int amount)
    {
        character.PlayerHP -= amount;
        Console.WriteLine("Jätte gör " + amount + " skada");
    }
}