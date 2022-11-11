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
    Console.WriteLine("Чётные чиселки: " + index);
    index++;
   }
   else
   {
    index++;
    }
}

// size = 8
// count = 0
// index = 0
// while (index < size) do
//     if (numbers[index > 0]) then
//        count = count + 1 
//     index = index + 1
// print(count)  



