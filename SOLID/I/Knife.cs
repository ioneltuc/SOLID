namespace SOLID.I;

public class Knife : IKnife
{
    public int Damage { get; set; }
    public int Range { get; set; }

    public Knife()
    {
        Damage = 50;
    }
    
    public int Attack()
    {
        return Damage;
    }
}