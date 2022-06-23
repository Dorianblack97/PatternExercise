using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StockObserver;
public class StockObserver : IObserver
{
    private double ibmPrice;
    private double aaplPrice;
    private double googPrice;
    
    private static int observerIDTracker = 0;
    private int observerID;

    private ISubject stockGrabber;

    public StockObserver(ISubject stockGrabber)
    {
        this.stockGrabber = stockGrabber;
        this.observerID = ++observerIDTracker;
        Console.WriteLine($"\nNew Observer {observerID} added to Subject");
        stockGrabber.register(this);
    }
    public void update(double ibmPrice, double aaplPrice, double googPrice)
    {
        this.ibmPrice = ibmPrice;
        this.aaplPrice = aaplPrice;
        this.googPrice = googPrice;
        printThePrices();
    }

    private void printThePrices()
    {
        Console.WriteLine($"\nObserver {observerID} : \nIBM {ibmPrice:C2}, \nAAPL {aaplPrice:C2}, \nGOOG {googPrice:C2}");
    }
}
