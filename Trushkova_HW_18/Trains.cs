namespace Task2
{
    internal static class Trains
    {
        //Проверка содержится ли поезд в массиве поездов
        public static int? HasTrain(int numberTrain, Train[] trains)
        {
            int? hasTrainIndex = null;

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].NumberTrain == numberTrain)
                {
                    hasTrainIndex = i;
                    break;
                }
            }
            return hasTrainIndex;
        }

        //Сортировка массива поездов по номеру поезда (метод вставки)
        public static Train[] SortingNumTrain(Train[] trains)
        {
            for (int i = 1; i < trains.Length; i++)
            {
                Train trainDop = trains[i];
                int j = i;
                while (j > 0 && trains[j - 1].NumberTrain > trainDop.NumberTrain)
                {
                    trains[j] = trains[j - 1];
                    --j;
                }
                trains[j] = trainDop;
            }
            return trains;
        }
    }
}
