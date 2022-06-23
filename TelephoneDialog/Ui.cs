using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDialog.Observer;

namespace TelephoneDialog;
public class Ui : IObserver
{
    public void UpdateCall(string number) => Console.WriteLine($"Number dialing {number}");
    public void UpdateDigit(int digit) => Console.WriteLine($"Pressing: {digit}");
}
