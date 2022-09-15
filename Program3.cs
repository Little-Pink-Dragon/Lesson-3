Console.Write("Введите любое число больше 0 ");
 int N = int.Parse(Console.ReadLine());
 int i = 1;
 if (N > 0)
 {
    Console.Write(N + " -> ");
 while (i <= N)
 {
 Console.Write(Math.Pow (i, 3) + ", ");
 i++;
 }
 }
 else Console.Write("Введите число больше 0");
