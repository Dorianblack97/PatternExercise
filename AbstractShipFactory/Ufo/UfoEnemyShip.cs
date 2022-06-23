using AbstractShipFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.Ufo;
public class UfoEnemyShip : EnemyShip
{
    IEnemyShipFactory shipFactory;

    public UfoEnemyShip(IEnemyShipFactory shipFactory)
    {
        this.shipFactory = shipFactory;
    }
    public override void makeShip()
    {
        Console.WriteLine($"Making enemy ship {getName()}");

        weapon = shipFactory.addESGun();
        engine = shipFactory.addESEngine();
    }
}
