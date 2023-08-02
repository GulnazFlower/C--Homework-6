// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            count ++;
        }
    }
    return(count);
}

int[] GenerateArray(int size)
{
    int [] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
         array[i] = GetInput($"Введите {i + 1}-е число: ");
    }
    return array;
}

int GetInput(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите количество чисел: ");
int[] array = GenerateArray(size);
Console.Write($"{String.Join(",", array)} -> ");
GetNumbers(array);
Console.Write($"{GetNumbers(array)}");
Console.WriteLine();