[System.Serializable]
public class Warrior
{
    public int exp;
    public int lv;
    public int Exp
    {
        get
        {
            return lv * 10;
        }
        set
        {
            exp = value;
        }
    }
}