using MagicGame;
using System;

class Program
{
    static void Main()
    {
        Mage fireMage = new FireMage("FireMage", 5, 100);
        Mage waterMage = new WaterMage("WaterMage", 5, 100);

        fireMage.OnAttack += Console.WriteLine;
        fireMage.OnHealthChanged += Console.WriteLine;
        waterMage.OnAttack += Console.WriteLine;
        waterMage.OnHealthChanged += Console.WriteLine;

        while (fireMage.IsAlive() && waterMage.IsAlive())
        {
            fireMage.CastAttackSpell(waterMage);
            if (waterMage.IsAlive())
            {
                waterMage.CastAttackSpell(fireMage);
            }
        }

        Console.WriteLine();
        if (fireMage.IsAlive())
        {
            Console.WriteLine($"{fireMage.Name} переміг!");
        }
        else if (waterMage.IsAlive())
        {
            Console.WriteLine($"{waterMage.Name} переміг!");
        }
        else
        {
            Console.WriteLine("Обидва мага загинули!");
        }
    }
}
