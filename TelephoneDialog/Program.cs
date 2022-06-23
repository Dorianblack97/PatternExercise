// Observer Pattern

using TelephoneDialog;

Console.WriteLine("Enter a value: \n");
var telephone = new Telephone();
var ui = new Ui();
telephone.Attach(ui);
while (true)
{
    //var key1 = Console.ReadKey().Key;
    //key1 switch
    //{
    //    ConsoleKey.Decimal => Console.WriteLine("1"),
    //    ConsoleKey.Enter => Console.WriteLine("3"),
    //    _ => Console.WriteLine("default")
    //};
    var keyString = Console.ReadLine();
    var key = keyString.First();
    if (char.IsDigit(key))
    {
        var result = Int32.Parse(keyString);
        telephone.AddDigit(result);
    }
    else if (key == 'c')
    {
        telephone.NotifyCall();
    }    
}
