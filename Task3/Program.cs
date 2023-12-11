// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсиюю, не использовать циклы.

int [] CreateArray(int min, int max, int size){
    int [] array = new int [size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ReversArray(int [] array, int size){
    if(size < 0) return;
    Console.Write(array[size] + " ");
    ReversArray(array, size-1);
}

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
Console.WriteLine();
ReversArray(array, size - 1);