namespace Classwork2
{
    internal static class Students
    { 
        //Вывод информации о группе студентов
        public static void ShowGroup(Student[] students1)
        {
            foreach (Student student in students1)
                student.Show();
        }

        //Сортировка массива студентов по сумме баллов (метод вставки)
        public static Student[] SortingStudents(Student[] students)
        {
            for (int i = 1; i < students.Length; i++)
            {
                Student studentDop = students[i];
                int j = i;
                while (j > 0 && students[j - 1].SumOfGrades > studentDop.SumOfGrades)
                {
                    students[j] = students[j - 1];
                    --j;
                }
                students[j] = studentDop;
            }
            return students;
        }
    }
}
