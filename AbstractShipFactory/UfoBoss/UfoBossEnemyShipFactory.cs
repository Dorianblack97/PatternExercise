using AbstractShipFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.UfoBoss;
public class UfoBossEnemyShipFactory : IEnemyShipFactory
{
    public IESEngine addESEngine() => new ESUfoBossEngine();
    public IESWeapon addESGun() => new ESUfoBossGun();
}
