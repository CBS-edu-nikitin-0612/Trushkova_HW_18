namespace Classwork1
{
    internal static class Students
    {
        //Выбор студентов по номеру группы
        public static Student[] FindByNumberGroup (int number, Student[] students1)
        {
            Student[] students2 = students1.Where(x => IsFind(x, number)).ToArray();
            if (students2.Length == 0) throw new Exception("Такого номера группы не существует");
            return students2;
        }

        //Проверка подходит ли студент по номеру группы
        private static bool IsFind(Student student, int number)
        {
            if (student.NumberGroup == number) return true;
            else return false;
        }

        public static void ShowGroup(Student[] students1)
        {
            foreach (Student student in students1)
                student.Show();
        }
    }
}
