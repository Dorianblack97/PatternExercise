using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockObserver;
public class StockGrabber : ISubject
{
    private List<IObserver> observers;
    private double ibmPrice;
    private double aaplPrice;
    private double googPrice;

    public StockGrabber()
    {
        observers = new List<IObserver>();
    }
    public void notifyObserver()
    {
        foreach (IObserver observer in observers)
        {
            observer.update(ibmPrice, aaplPrice, googPrice);
        }
    }
    public void register(IObserver newObserver) => observers.Add(newObserver);
    public void unregister(IObserver deleteObserver)
    {
        Console.WriteLine($"\nObserver {observers.IndexOf(deleteObserver)} deleted");
        observers.Remove(deleteObserver);
    }

    public void SetIBMPrice(double newIBMPrice)
    {
        this.ibmPrice = newIBMPrice;
        notifyObserver();
    }
    public void SetAAPLPrice(double newAAPLPrice)
    {
        this.aaplPrice = newAAPLPrice;
        notifyObserver();
    }
    public void SetGOOGPrice(double newGOOGPrice)
    {
        this.googPrice = newGOOGPrice;
        notifyObserver();
    }
}
