using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDialog.Observer;
public interface IObserver
{
    void UpdateDigit(int digit);
    void UpdateCall(string number);
}
