using AnimalGameStore.Controller;
using AnimalGameStore.Services;

GameControllerServices gameControllerServices = new();
GameController gameController = new(gameControllerServices);

Console.Write($"\rEnter fossil name to search: ");
string FossilName = Console.ReadLine()!;
var result = gameController.GetFossilByName(FossilName);

Console.WriteLine($"Results for fossil name {FossilName}: \n");
Console.Write($"{result.Value}\n");
Console.ReadLine();