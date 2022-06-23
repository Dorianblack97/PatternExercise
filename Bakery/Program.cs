// Decorator Pattern

using Bakery;

var chocolate = new ChocolateCake();
Console.WriteLine(chocolate.CakeIt() + $" cost {chocolate.Price}");

var vanilla = new VanillaCake();
var plain = new SayingCakeDecorator(vanilla, "PLAIN");
Console.WriteLine(plain.CakeIt() + $" cost {vanilla.Price}");

vanilla.ResetPrice();
var sprinkles = new SprinklesCakeDecorator(vanilla);
var fancy = new SayingCakeDecorator(sprinkles, "FANCY");
Console.WriteLine(fancy.CakeIt() + $" cost {vanilla.Price}");

chocolate.ResetPrice();
var multiLayered = new MultiLayeredCakeDecorator(chocolate);
sprinkles.SetCake(multiLayered);
var sprinkles1 = new SprinklesCakeDecorator(sprinkles);
var oneOf = new SayingCakeDecorator(sprinkles1, "one of ");
var everything = new SayingCakeDecorator(oneOf, "EVERYTHING ");
Console.WriteLine(everything.CakeIt() + $" cost {chocolate.Price}");

