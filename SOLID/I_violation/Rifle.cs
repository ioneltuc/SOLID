namespace SOLID.I_violation;

public class Rifle : IWeapon
{
    public int Damage { get; set; }
    public int Range { get; set; }
    public int MagazineBulletsCount { get; set; }
    public int CurrentBulletsCount { get; set; }

    public Rifle()
    {
        Damage = 100;
        MagazineBulletsCount = 30;
    }
    
    public int Attack()
    {
        CurrentBulletsCount--;
        return Damage;
    }

    public void Reload()
    {
        CurrentBulletsCount = MagazineBulletsCount;
    }
}