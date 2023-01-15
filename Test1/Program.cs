Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 0; i <= (number2 -1); i++)
{
    result *= number1;
}
Console.Write(result);
