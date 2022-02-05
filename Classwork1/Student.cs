using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1
{
    internal struct Student
    {
        public string Surname { get; set; }

        public int NumberGroup { get; set; }

        public Student(string surname, int number)
        {
            Surname = surname;
            NumberGroup = number;
        }

        public void Show()
        {
            Console.WriteLine($"Студент {Surname} из группы {NumberGroup}");
        }
    }
}
