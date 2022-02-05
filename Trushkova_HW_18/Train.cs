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

        private static int ReadFromConsole(string name)
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
    }
}
