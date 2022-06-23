using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDialog.Observer;

namespace TelephoneDialog;
public class Telephone : ISubject
{
    public int Digit { get; set; }
    public StringBuilder Number;

    public List<IObserver> _observers = new List<IObserver>();
    public Telephone()
    {
        Number = new StringBuilder();
    }

    public void AddDigit(int digit)
    {
        Digit = digit;
        NotifyDigit();
        Number.Append(Digit);        
    }

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    public void NotifyDigit() => _observers.ForEach(observer => observer.UpdateDigit(Digit));
    public void NotifyCall()
    {
        _observers.ForEach(observer => observer.UpdateCall(Number.ToString()));
        Number.Clear();
    }
}
