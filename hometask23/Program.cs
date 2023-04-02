void KubN(int num)
{
    int index = 1;
    while (index <= num)
    {
    int res = index*index*index;
    Console.Write($"{res}, ");
    index++;     
    }
    Console.WriteLine(".");
}
Console.Write("введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1) 
{
    Console.Write($"{number} -> ");
    KubN(number);
}
else
{
    Console.WriteLine($"{number} невозможное значение");
}