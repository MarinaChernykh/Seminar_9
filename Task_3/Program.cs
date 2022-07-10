//  Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N с определенным шагом

void PrintNumbers(int M, int N, int step)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNumbers(M + step, N, step);
    }
}

PrintNumbers(2, 10, 2);