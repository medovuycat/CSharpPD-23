using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterMage : Mage
{
    public WaterMage(string name, int magicLevel, int health)
        : base(name, magicLevel, health)
    {
    }

    public override void CastAttackSpell(Mage target)
    {
        int damage = MagicLevel * 8;
        Console.WriteLine($"{Name} кидає водяний вибух на {target.Name}, завдаючи {damage} шкоди!");
        target.TakeDamage(damage);
    }

    public override void CastDefenseSpell()
    {
        Console.WriteLine($"{Name} оточують себе водяним щитом!");
    }
}

