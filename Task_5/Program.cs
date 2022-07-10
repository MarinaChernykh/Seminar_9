// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

int Multi(int A, int B)
{
    if (B == 0) return 1;
    else return A * Multi(A, B - 1);
}


Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multi(A, B));