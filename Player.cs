class Player
{
    private int playerHP;
    private int points;

    public int PlayerHP
    {
        get { return playerHP; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public Player(int hp)
    {
        playerHP = hp;
    }

    public void PlayerTakeDamage(int amount)
    {
        playerHP -= amount;
    }
}