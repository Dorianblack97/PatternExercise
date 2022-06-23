using AbstractShipFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShipFactory.Ufo;
public class ESUfoEngine : IESEngine
{
    public override string ToString() => "1000 mph";
}
