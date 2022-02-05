namespace AddTask
{
    struct NoteBook
    {
        private readonly string _producer;
        private readonly int _model;
        private readonly int _price;

        public NoteBook(string name, int number, int time)
        {
            _producer = name;
            _model = number;
            _price = time;
        }

        public string Producer => _producer;

        public int Model => _model;

        public int Price => _price;

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Модель планшета {_model} производится {_producer} по цене {_price} рублей";
        }
    }
}
