// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.


int NumberSum(int N)
{
    if (N / 10 == 0) return N % 10;
    else return N % 10 + NumberSum(N / 10);
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {NumberSum(N)}");


// Либо вот так:

int NumberSum2(int N)
{
    int sum = 0;
    if (N != 0)
    {
        sum += NumberSum2(N / 10) + N % 10;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр = {NumberSum(567)}");
