using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    struct NoteBook
    {
        private string _producer;
        private int _model;
        private int _price;

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
