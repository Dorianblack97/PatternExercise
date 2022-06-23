using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery;
public abstract class DecoratorCake : Cake
{
    protected Cake _cake;
    public DecoratorCake(Cake cake)
    {
        _cake = cake;
    }
    public void SetCake(Cake cake) => _cake = cake;
    public override string CakeIt()
    {
        if (_cake is not null) return _cake.CakeIt();
        else return string.Empty;
    }
}
