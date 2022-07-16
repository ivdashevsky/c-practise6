//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("\nВведите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
if (M <= 0) 
{ 
    Console.WriteLine("Число не соответствует количеству элементов массива"); 
}
else
{
    int[] arr = new int[M];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"\nВведите число {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine($"Кол-во чисел > 0: {count}");
}
