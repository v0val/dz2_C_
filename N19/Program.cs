m1:
Console.WriteLine("Введите 5-ти значное число");
string? a = Console.ReadLine();
if (a.Length != 5)
{
Console.WriteLine("число не является пятизначным, попробуйте еще раз");
goto m1;
}
else
{
if (a[0] == a[4] && a[1] == a[3])
{
Console.WriteLine("число палиндром");
}
else
{
Console.WriteLine("число не палиндром");
}
}