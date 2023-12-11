// Напишите программу вычесления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Akkerman(int n,int m){
    if (n == 0) return m + 1;
    else if (m == 0) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1,Akkerman(n, m - 1));
}

Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
if(m < 0 || n < 0){
    Console.WriteLine("Некоректный ввод, числа должны быть положительными.");
} else {
    int akkerman = Akkerman(n, m);
    Console.WriteLine($"Функция Аккермана равна {akkerman}");
}