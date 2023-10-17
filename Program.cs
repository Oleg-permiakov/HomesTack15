// Проверяет по цифре является ли этот день выходным
Console.WriteLine("Введите число от 1 до 7");
string b = Console.ReadLine();
int a = Convert.ToInt32(b);

if (a == 6 || a == 7) 
{
      Console.WriteLine("Да");
}

 else
{
    Console.WriteLine("Нет");
}
