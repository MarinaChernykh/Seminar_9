// // Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N


void PrintNumbers(int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNumbers(M + 1, N);
    }
}

PrintNumbers(2, 5);