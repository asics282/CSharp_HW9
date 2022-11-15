// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"
void Main()
{
    Console.Clear();
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write($"N = {n} -> "); EvenSequence(n);
    Console.Write("Для завершения работы нажмите Enter");
    Console.ReadLine();
}

void EvenSequence(int n)
{
    if (n%2 == 0)
    Console.Write($"{n} ");
    if (n <= 1) return;
    n--;
    EvenSequence(n);
}
Main();

