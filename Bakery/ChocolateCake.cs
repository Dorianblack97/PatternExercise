using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery;
public class ChocolateCake : BaseCake
{
    public ChocolateCake()
    {
        Price = 10;
    }
    public override void ResetPrice() => Price = 10;    
    public override string CakeIt() => "Chocolate cake ";
}
