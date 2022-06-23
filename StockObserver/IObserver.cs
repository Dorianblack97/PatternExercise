namespace StockObserver;

public interface IObserver
{
    public void update(double ibmPrice, double aaplPrice, double googPrice);
}