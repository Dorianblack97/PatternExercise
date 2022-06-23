using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery;
public class MultiLayeredCakeDecorator : DecoratorCake
{
    public MultiLayeredCakeDecorator(Cake cake) : base(cake)
    {
    }
    public override string CakeIt()
    {
        _cake.Price += 5 + Price;
        if (_cake is not null) return "Multi layered cake " + _cake.CakeIt();
        else return string.Empty;
    }
}
