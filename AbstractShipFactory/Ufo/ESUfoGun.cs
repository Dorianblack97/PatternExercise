using AbstractShipFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.Ufo;
public class ESUfoGun : IESWeapon
{
    public override string ToString() => "20 damage";
}
