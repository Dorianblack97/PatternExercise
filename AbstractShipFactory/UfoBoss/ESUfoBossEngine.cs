using AbstractShipFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.UfoBoss;
public class ESUfoBossEngine : IESEngine
{
    public override string ToString() => "2000 mph";
}
