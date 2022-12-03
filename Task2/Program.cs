Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num/100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(num%10);
}