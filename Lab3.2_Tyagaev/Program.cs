//Lab 3.2. Номер: 12. Уровень: Высокий.
int n = 0;
do
{
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine());
    if ((n >= -5) && (n <= 5) && (n != 0)) Console.WriteLine($"число {n} лежит в итервале от -5 до 5");
    else if (n == 0) Console.WriteLine("Цикл окончен");
    else Console.WriteLine($"число {n} не лежит в итервале от -5 до 5");
}
while (n != 0);