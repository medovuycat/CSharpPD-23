using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Mage : ISpell
{
    public string Name { get; private set; }
    public int MagicLevel { get; private set; }
    public int Health { get; private set; }

    public Mage(string name, int magicLevel, int health)
    {
        Name = name;
        MagicLevel = magicLevel;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }

    public abstract void CastAttackSpell(Mage target);
    public abstract void CastDefenseSpell();

    public bool IsAlive()
    {
        return Health > 0;
    }

    public override string ToString()
    {
        return $"{Name} (Level: {MagicLevel}, Health: {Health})";
    }
}
