using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.Abstract;
public abstract class EnemyShip
{
    private string name;
    internal IESWeapon weapon;
    internal IESEngine engine;

    public string getName() => name;
    public void setName(string newName) => name = newName;

    public abstract void makeShip();
    public void followHeroShip() => Console.WriteLine($"{name} is following the hero at {engine.ToString()}");
    public void displayEnemyShip() => Console.WriteLine($"{name} is on the screen");
    public void enemyShipShoots() => Console.WriteLine($"{name} attacks and does {weapon.ToString()}");

    public override string ToString()
    {
        return $"The {name} has top speed of {engine.ToString()} and an attack power of {weapon.ToString()}";
    }
}
