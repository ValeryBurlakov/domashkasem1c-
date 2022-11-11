// напишите программу, которая на вход принимает 2 числа и выдаёт, какое число больше, а какое меньше
// a = 5, b = 10 -> max = 10

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine($"Максимальное число {number1}");
    Console.WriteLine($"А минимальное число {number2}");
}
else
{
    Console.WriteLine($"Максимальное число {number2}");
    Console.WriteLine($"А минимальное число {number1}");
}
// $"Квадрат числа {number} равен {square}"