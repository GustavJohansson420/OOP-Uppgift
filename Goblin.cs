class Goblin
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
}