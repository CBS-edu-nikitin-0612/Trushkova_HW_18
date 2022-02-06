// See https://aka.ms/new-console-template for more information
using AddTask;  //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

NoteBook[] notebooks = new NoteBook[4];

for (int i = 0; i < notebooks.Length; i++)
{
    notebooks[i] = new NoteBook($"producer{i + 1}", (i + 1) * 10, (i + 1) * 1000);
}


Console.WriteLine("\nЗагруженные в базу модели планшетов:");
for (int i = 0; i < notebooks.Length; i++)
{
    notebooks[i].Show();
}
