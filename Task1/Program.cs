// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Используйте рекурсию, не использовать циклы.

void NaturNum(int m,int n){
    if (m < 0 || n < 0){
    Console.WriteLine("Некоректный ввод, число должно быть положительным.");
    return;
    }
    if(m > n) return;
    Console.Write(m + " ");
    NaturNum(m+1, n);
}

Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n){
        int t = m;
        m = n;
        n = t;
    }
NaturNum(m,n);