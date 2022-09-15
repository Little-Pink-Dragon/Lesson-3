Console.Write("Введите координату X1 ");
 int x1 = int.Parse(Console.ReadLine());
 Console.Write("Введите координату X2  ");
 int x2 = int.Parse(Console.ReadLine());
 Console.Write("Введите координату Y1  ");
 int y1 = int.Parse(Console.ReadLine());
 Console.Write("Введите координату Y2  ");
 int y2 = int.Parse(Console.ReadLine());
 Console.Write("Введите координату Z1  ");
 int z1 = int.Parse(Console.ReadLine());
 Console.Write("Введите координату Z2  ");
 int z2 = int.Parse(Console.ReadLine());
 double distance = 0;
 {
 distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
distance = Math.Round (distance, 2 );
 }
 Console.Write("A" + (x1,y1,z1) + "; " + "B" + (x2,y2,z2) + " -> " + distance);
