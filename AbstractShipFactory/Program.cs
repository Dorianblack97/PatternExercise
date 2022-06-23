using AbstractShipFactory;
using AbstractShipFactory.Abstract;

EnemyShipBuilding MakeUFOs = new UfoEnemyShipBuilding();

EnemyShip theGrunt = MakeUFOs.orderTheShip("UFO");
Console.WriteLine(theGrunt + "\n");

EnemyShip theBoss = MakeUFOs.orderTheShip("UFO BOSS");
Console.WriteLine(theBoss + "\n");
