class Player
{
    private int playerHP;
    private int points;
    private string playerState;

    public int PlayerHP
    {
        get { return playerHP; }
        set { playerHP = value; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public string PlayerState
    {
        get { return playerState; }
        set { playerState = value; }
    }

    public Player(int hp)
    {
        playerHP = hp;
    }

    public void PlayerTakeDamage(int amount)
    {
        playerHP -= amount;
    }
    
    public void PlayerDoDamage(Enemy enemyCharacter, int amount)
    {
        enemyCharacter.EnemyHP -= amount;
        Console.WriteLine("Du gör " + amount + " skada");
    }
}