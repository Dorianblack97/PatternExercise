using AbstractShipFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.Ufo;
public class UfoEnemyShipFactory : IEnemyShipFactory
{
    public IESEngine addESEngine() => new ESUfoEngine();
    public IESWeapon addESGun() => new ESUfoGun();
}
