// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N

void PrintNumbers(int N, int counter)
{
    if (counter <= N)
    {
        Console.WriteLine(counter);
        PrintNumbers(N, counter + 1);
    }
}

PrintNumbers(10, 1);


// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1

void PrintNumbersReversed(int N)
{
    if (N!=0)
    {
        Console.WriteLine(N);
        PrintNumbersReversed(N-1);
    }
}

PrintNumbersReversed(5);