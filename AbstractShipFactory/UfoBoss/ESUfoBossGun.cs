using AbstractShipFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.UfoBoss;
public class ESUfoBossGun : IESWeapon
{
    public override string ToString() => "40 damage";
}
