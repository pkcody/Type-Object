using UnityEngine;

// Type Object (but for unity using scriptable objects is better)
public abstract class Weapon : MonoBehaviour
{
    public void Attack(Target target)
    {
            DoAttack(target);
            Debug.Log(target);
            Debug.Log("You " + DamageMessage());
    }

    protected abstract void DoAttack(Target target);
    protected virtual string DamageMessage() { return "hit"; }
}
