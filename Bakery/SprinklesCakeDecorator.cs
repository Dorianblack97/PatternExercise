using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery;
public class SprinklesCakeDecorator : DecoratorCake
{
    public SprinklesCakeDecorator(Cake cake) : base(cake)
    {
    }
    public override string CakeIt()
    {
        _cake.Price += 2 + Price;
        if (_cake is not null) return _cake.CakeIt() + "with sprinkles ";
        else return string.Empty;
    }
}
