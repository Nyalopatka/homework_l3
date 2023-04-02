//принимает 5 значное число и проверяет палиндром или нет
void Paralindrom(int num)
{
if (9999 < num && num < 100000)
{
    int n1 = num / 10000;
    int n2 = (num / 1000) % 10;
    int n3 = (num / 100) % 10 ;
    int n4 = (num / 10) % 10;
    int n5 = (num % 10);
    if (n1 == n5 && n2 == n4)
    {
         Console.WriteLine($"число {num} является палиндромом");
    }
    else 
    {
    Console.WriteLine($"число {num} не является палиндромом");
    }
}  
else 
{
    Console.WriteLine($"число {num} не пятизначное ");
}
} 
Console.Write("введите  пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Paralindrom(number);