int[] pix1 = new int[ 3 ];
int[] pix2 = new int[ 3 ];
Console.WriteLine("Введите координаты двух точек в пространстве");
for (int i = 0; i < 3; i++)
{
Console.Write( $"pix1[ {i + 1} ] = " );
pix1[i] = Convert.ToInt32(Console.ReadLine());
Console.Write( $"pix2[ {i + 1} ] = " );
pix2[i] = Convert.ToInt32(Console.ReadLine());
}
double distance = Math.Sqrt(Math.Pow(pix1[0]-pix2[0], 2) + Math.Pow(pix1[1]-pix2[1], 2) + Math.Pow(pix1[2]-pix2[2], 2));
Console.Write("Расстояние между точками = ");
Console.WriteLine(distance);
