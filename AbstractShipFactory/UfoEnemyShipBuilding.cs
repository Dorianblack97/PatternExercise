using AbstractShipFactory.Abstract;
using AbstractShipFactory.Ufo;
using AbstractShipFactory.UfoBoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory;
public class UfoEnemyShipBuilding : EnemyShipBuilding
{
    protected override EnemyShip makeEnemyShip(string typeOfShip)
    {
        EnemyShip theEnemyShip = null;
        if (typeOfShip.Equals("UFO"))
        {
            var shipPartsFactory = new UfoEnemyShipFactory();
            theEnemyShip = new UfoEnemyShip(shipPartsFactory);
            theEnemyShip.setName("UFO Grunt Ship");
        }
        else if (typeOfShip.Equals("UFO BOSS"))
        {
            var shipPartsFactory = new UfoBossEnemyShipFactory();
            theEnemyShip = new UfoBossEnemyShip(shipPartsFactory);
            theEnemyShip.setName("UFO BOSS Ship");
        }
        return theEnemyShip;
    }
}
