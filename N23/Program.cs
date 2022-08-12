Console.WriteLine("Ввведите натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N+1; i++)
{
Console.Write( $"{i} ^ 3 = " );
Console.WriteLine(Math.Pow(i, 3));
}