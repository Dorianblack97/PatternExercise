using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery;
public class SayingCakeDecorator : DecoratorCake
{
    private string _says;
    public SayingCakeDecorator(Cake cake, string says) : base(cake)
    {
        _says = says;
    }
    public override string CakeIt()
    {
        Price += _cake.Price;
        return _cake.CakeIt() + $"with saying: {_says} ";
    }
}
