// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
int result = -1;
if (num >= 100)
{
while (num > 999)
{
num = num / 10;
}
result = num % 10;
}
return result; 
}

Console.Write("Введите трехзначное число: ");
int num1 = int.Parse(Console.ReadLine());

if (ThirdDigit(num1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Третья цифра это: {ThirdDigit(num1)}");