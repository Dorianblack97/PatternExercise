using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery;
public class VanillaCake : BaseCake
{
    public VanillaCake()
    {
        Price = 8;
    }
    public override void ResetPrice() => Price = 8;
    public override string CakeIt() => "Vanilla cake ";
    
}
