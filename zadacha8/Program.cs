// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= numberA)
{
   int result = index % 2;
   if(result != 1)
   {
    Console.WriteLine("Чётные числа: " + index);
    index++;
   }
   else
   {
    index++;
    }
}




