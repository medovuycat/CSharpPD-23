using MagicGame;
using System;
using System.Xml.Linq;

public class FireMage : Mage
{
    public FireMage(string name, int magicLevel, int health) : base(name, magicLevel, health) { }

    public override void CastAttackSpell(Mage target)
    {
        int damage = MagicLevel * 10;
        target.TakeDamage(damage);
        InvokeOnAttack($"{Name} кидає вогняну кулю на {target.Name}, завдаючи {damage} шкоди.");
    }

    public override void CastDefenseSpell()
    {
        InvokeOnAttack($"{Name} створює вогняний щит для захисту.");
    }
}
