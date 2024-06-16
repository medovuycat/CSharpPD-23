using System;

public delegate void MageAction(string message);

public abstract class Mage
{
    public string Name { get; private set; }
    public int MagicLevel { get; private set; }
    public int Health { get; private set; }

    public event MageAction OnAttack;
    public event MageAction OnHealthChanged;

    public Mage(string name, int magicLevel, int health)
    {
        Name = name;
        MagicLevel = magicLevel;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Health = 0;
            OnHealthChanged?.Invoke($"{Name} вмирає.");
        }
        else
        {
            OnHealthChanged?.Invoke($"{Name} тепер має {Health} здоров'я.");
        }
    }

    public abstract void CastAttackSpell(Mage target);
    public abstract void CastDefenseSpell();

    public bool IsAlive()
    {
        return Health > 0;
    }

    protected void InvokeOnAttack(string message)
    {
        OnAttack?.Invoke(message);
    }
}
