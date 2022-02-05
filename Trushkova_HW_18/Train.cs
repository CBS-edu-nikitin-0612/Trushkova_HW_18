namespace Task2
{
    struct Train
    {
        private string _nameStation;
        private int _numberTrain;
        private int _time;

        public Train(string name, int number, int time)
        {
            _nameStation = name;
            _numberTrain = number;
            _time = time;
        }

        public string NameStation => _nameStation;

        public int NumberTrain => _numberTrain;

        public int Time => _time;

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Поезд {_numberTrain} отправляется со станции {_nameStation} в {_time} часов";
        }

        public static Train MakeTrain(int i)
        {
            int numberTrain = ReadFromConsole($"номер {i + 1}-го поезда");
            int time = ReadFromConsole($"время прибытия {i + 1}-го поезда");
            Console.WriteLine($"Введите название станции для {i + 1}-го поезда:");
            string? nameStation = Console.ReadLine();
            if (nameStation != null)
                return new Train(nameStation, numberTrain, time);
            else
            {
                Console.WriteLine("Имя станции не задано");
                return new Train();
            }
        }

        public static int ReadFromConsole(string name)
        {
            int parametr;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Введите {name}:");
                    parametr = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {

                }
            }
            return parametr;
        }

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
