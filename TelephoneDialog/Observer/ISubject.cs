namespace TelephoneDialog.Observer;

public interface ISubject
{
    // Attach an observer to the subject.
    void Attach(IObserver observer);

    // Detach an observer to the subject.
    void Detach(IObserver observer);

    // Notify all observer about an event.
    void NotifyDigit();
    void NotifyCall();
}