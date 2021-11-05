public class LavaBlob : Weapon
{
    protected override void DoAttack(Target t)
    {
        t.TakeDamage(2);
    }

    protected override string DamageMessage()
    {
        return "ooglyee";
    }
}

