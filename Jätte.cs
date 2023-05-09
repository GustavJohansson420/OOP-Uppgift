class Jätte
{
    private int jätteHP;

    public int JätteHP
    {
        get { return jätteHP; }
    }

    public Jätte(int hp)
    {
        jätteHP = hp;
    }

    public void JätteTakeDamage(int amount)
    {
        jätteHP -= amount;
    }
}