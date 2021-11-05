public class Blob : Weapon
{
    protected override void DoAttack(Target t)
    {
        t.TakeDamage(5);
    }

    protected override string DamageMessage()
    {
        return "googley";
    }
}
