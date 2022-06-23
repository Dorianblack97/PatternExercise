// Command Pattern

using SquareManipulationSystem;
using SquareManipulationSystem.Commands;

var Manipulator = new ManipulationSystem();
var CommandList = new List<ICommand>();
CommandList.Add(new CreateSquare(Manipulator, 1, 2));
CommandList.Add(new CreateSquare(Manipulator, 3, 4));
CommandList.Add(new MoveSquare(Manipulator, 2, 55, 77));
CommandList.Add(new MoveSquare(Manipulator, 3, 55, 77));
CommandList.Add(new ScaleSquare(Manipulator, 3, 4));
CommandList.Add(new RedoLastCommand(Manipulator));
CommandList.Add(new UndoLastCommand(Manipulator));
CommandList.Add(new ScaleSquare(Manipulator, 1, 10));
CommandList.Add(new UndoLastCommand(Manipulator));
CommandList.Add(new RedoLastCommand(Manipulator));
CommandList.Add(new ScaleSquare(Manipulator, 3, 5));
CommandList.Add(new UndoLastCommand(Manipulator));
CommandList.Add(new CreateSquare(Manipulator, 2, 4));
CommandList.Add(new UndoLastCommand(Manipulator));
CommandList.Add(new PrintSquare(Manipulator));



foreach (var command in CommandList)
{
    command.Execute();
}

foreach (var command in Manipulator.History)
{
    Console.WriteLine(command.Item1);
}


