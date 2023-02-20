// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <99 || number > 999)
{
    Console.WriteLine("Ошибка! ВВедите трехзначное число");
}
else
{
    int digit2 = (number / 10) % 10;
    Console.WriteLine($"{number} вторая цифра: {digit2}");
}


