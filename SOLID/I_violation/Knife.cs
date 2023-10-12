namespace SOLID.I_violation;

public class Knife : IWeapon
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

    public void Reload()
    {
        //Un cutit nu poate fi incarcat,
        //interfata trebuie segregata
        throw new NotImplementedException();
    }
}