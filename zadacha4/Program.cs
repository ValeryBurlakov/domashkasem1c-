// напишите программу, которая принимает 3 числа и выводит максимальное из них
// 2, 3, 7 -> 7
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxnumber = 0;
if((number1 > number2) && (number1 > number3))
{  
    maxnumber = number1;
}
else if ((number2 > number1) && (number2 > number3))
{
    maxnumber = number2;
}
else if ((number3 > number1) && (number3 > number2))
{
    maxnumber = number3;
}
Console.WriteLine("Максимальное число: " + maxnumber);