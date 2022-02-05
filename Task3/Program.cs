// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, Teacher!");

static void ClassTaker(MyClass myClass)
{
    myClass.change = "изменено";
}

static void StruktTaker(MyStruct myStruct)
{
    myStruct.change = "изменено";
}

MyClass myClass = new ();

//Можно без вызова конструктора
MyStruct myStruct;

myClass.change = "не изменено";
myStruct.change = "не изменено";

//Поменяет поле, так как MyClass ссылочный тип 
ClassTaker(myClass);
Console.WriteLine($"Поле класса MyClass {myClass.change}");

//Не поменяет поле, так как MyStruct значимый тип 
StruktTaker(myStruct);
Console.WriteLine($"Поле класса MyStruct {myStruct.change}");