// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, Teacher!");

Train[] trains = new Train[4];

for (int i = 0; i < trains.Length; i++)
{
    trains[i] = Train.MakeTrain(i);
}

trains = Trains.SortingNumTrain(trains);
Console.WriteLine("\nЗагруженные в базу поезда:");
for (int i = 0; i < trains.Length; i++)
{    
    trains[i].Show();
}

Console.WriteLine("\nВведите номер поезда для поиска по загруженной базе:");
int numberTrain = Convert.ToInt32(Console.ReadLine());

int? hasTrainIndex = Trains.HasTrain(numberTrain, trains);

if (hasTrainIndex.HasValue)
    trains[hasTrainIndex.Value].Show();
else
    Console.WriteLine("Такого поезда нет");
