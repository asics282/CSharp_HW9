// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    Console.Clear();
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    int result = FunctionAckermann(m, n);
    Console.WriteLine($"m = {m}, n = {n} -> A({m}, {n}) {result}");

    Console.Write("Для завершения работы нажмите Enter");
    Console.ReadLine();
}

int FunctionAckermann(int m, int n)
{
    if (m == 0) 
    {return n + 1;}
    else if (n == 0 && m > 0) {return FunctionAckermann(m - 1, 1);}
    else {return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));}
}

Main();