// See https://aka.ms/new-console-template for more information
using Classwork2;  //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

Random random = new Random();

//Создание массива студентов
Student[] students = new Student[]
{
    new Student("Ivanov", random.Next(1, 19), random.Next(1, 19), random.Next(1, 19)),
    new Student("Petrov", random.Next(1, 19), random.Next(1, 19), random.Next(1, 19)),
    new Student("Sosnov", random.Next(1, 19), random.Next(1, 19), random.Next(1, 19)),
    new Student("Sidorov", random.Next(1, 19), random.Next(1, 19), random.Next(1, 19)),
    new Student("Ivanova", random.Next(1, 19), random.Next(1, 19), random.Next(1, 19)),
    new Student("Sidorova", random.Next(1, 19), random.Next(1, 19), random.Next(1, 19)),
};

//Вывод на экран информации о студентах
Students.ShowGroup(Students.SortingStudents(students));


