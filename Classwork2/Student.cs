namespace Classwork2
{
    internal struct Student
    {
        public string Surname { get; set; }

        public int Grade1 { get; set; }

        public int Grade2 { get; set; }

        public int Grade3 { get; set; }

        public readonly int SumOfGrades { get; }


        public Student(string surname, int grade1, int grade2, int grade3)
        {
            Surname = surname;
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
            SumOfGrades = grade1 + grade2 + grade3;
        }

        public void Show()
        {
            Console.WriteLine($"Студент {Surname} имеет оценки {Grade1}, {Grade2}, {Grade3}. Сумма баллов равна {SumOfGrades}");
        }
    }
}
