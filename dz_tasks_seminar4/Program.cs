
void Zadacha25()
{
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача 25");
Console.WriteLine("Введите первое число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;
for (int i = 1; i < b; i++)
{
    stepen = stepen * a;
}
Console.WriteLine($"Число А в степени В равно: {stepen}");
}


void Zadacha27()
{
// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("______________________");
Console.WriteLine("Задача 27");
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    int current = a % 10;
    a = a / 10;
    sum = sum + current;
    Console.WriteLine($"{current}");
}
Console.WriteLine($"Сумма цифр в числе = {sum}");
}


void Zadacha28()
{
// Задача 29: Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("______________________");
Console.WriteLine("Задача 28");

Random random = new Random();
int size = random.Next(4, 10);    // рандом нужен чтобы задать случайным значением size
int[] numbers = new int[size];   // массив чисел
Console.WriteLine(size);
FillArray(numbers); // вызываем метод заполнения массива
PrintArray(numbers); // вызываем метод печати массива
}


void FillArray(int[] num)  // метод для заполнения массива
{
Random random = new Random();
for (int i = 0; i < num.Length; i++)
{
    num[i] = random.Next(0, 20);
}
}

void PrintArray(int[] num) // метод для печати массива
{
for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + "\t"); // все числа будут выводится в строку с табуляцией
}
Console.WriteLine();
} 

Zadacha25();
Zadacha27();
Zadacha28();