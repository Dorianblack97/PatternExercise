using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.Abstract;
public interface IEnemyShipFactory
{
    public IESWeapon addESGun();
    public IESEngine addESEngine();
}
