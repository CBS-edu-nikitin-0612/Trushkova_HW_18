// See https://aka.ms/new-console-template for more information
using Classwork1; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

Student[] students = new Student[]
{
    new Student("Ivanov", 123),
    new Student("Petrov", 124),
    new Student("Sosnov", 126),
    new Student("Sidorov", 123),
    new Student("Ivanova", 126),
    new Student("Sidorova", 124),
};

Students.ShowGroup(students);

while (true)
{
    try
    {
        Console.WriteLine("\nВведите номер группы:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            //Выбор студентов по номеру группы
            Student[] studentsGroup = Students.FindByNumberGroup(number, students);
            //Вывод информации о выбранной группе студентов
            Students.ShowGroup(studentsGroup);            
        }
        else
        {
            throw new Exception("Номер должен быть натуральным числом");
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message.ToString());
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}


