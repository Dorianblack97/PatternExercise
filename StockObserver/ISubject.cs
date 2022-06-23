using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockObserver;
public interface ISubject
{   
    public void register(IObserver o);
    public void unregister(IObserver o);
    public void notifyObserver();
}
