Console.WriteLine("Введите колличество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] number = new int[num];
Random A = new Random();
for (int i = 0; i < number.Length; i++)
{
    number[i] = A.Next(0,100);
}
Console.WriteLine(string.Join(" ", number));
