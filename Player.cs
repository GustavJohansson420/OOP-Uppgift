class Player
{
    private int playerHP;

    public int PlayerHP
    {
        get { return playerHP; }
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