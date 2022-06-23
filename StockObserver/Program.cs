using StockObserver;
using System.Text;
using ObserverStock = StockObserver.StockObserver;

Console.OutputEncoding = Encoding.UTF8;

var stockGrabber = new StockGrabber();
var observer1 = new ObserverStock(stockGrabber);

stockGrabber.SetIBMPrice(197.00);
stockGrabber.SetAAPLPrice(677.60);
stockGrabber.SetGOOGPrice(676.40);

var observer2 = new ObserverStock(stockGrabber);

stockGrabber.SetIBMPrice(197.00);
stockGrabber.SetAAPLPrice(677.60);
stockGrabber.SetGOOGPrice(676.40);

stockGrabber.unregister(observer2);

stockGrabber.SetIBMPrice(197.00);
stockGrabber.SetAAPLPrice(677.60);
stockGrabber.SetGOOGPrice(676.40);