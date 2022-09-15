Console.WriteLine("Введите пятизначное число ");
 int num = int.Parse(Console.ReadLine());
 int a = 0;
 int b = 0;
 int c = 0;
 int d = 0;
if (num > 9999 && num < 100000)
{
a = num / 10000;
b = num / 1000 % 10;
c = num / 10 % 10;
d = num % 10;
if (a == d && b == c)
Console.Write( num + " -> " + " да");
else 
Console.Write( num + " -> " + " нет");
}


else Console.Write( "Введите пятизначное число ");
