using MagicGame;
using System;
using System.Xml.Linq;

public class WaterMage : Mage
{
    public WaterMage(string name, int magicLevel, int health) : base(name, magicLevel, health) { }

    public override void CastAttackSpell(Mage target)
    {
        int damage = MagicLevel * 8;
        target.TakeDamage(damage);
        InvokeOnAttack($"{Name} кидає водяний вибух на {target.Name}, завдаючи {damage} шкоди.");
    }

    public override void CastDefenseSpell()
    {
        InvokeOnAttack($"{Name} створює водяний щит для захисту.");
    }
}

