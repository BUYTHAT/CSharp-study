class Knight
{
    static int hp = 10;
    static int attack = 200;

    Knight(int hp, int attack)
    {
        
    }

    static public int Test()
    {
        return hp + attack;
    }
}

Knight knight = new Knight(130, 2)
    knight.Test()