Console.Clear();

Console.Write("Введите массив строк через пробел:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

PrintArray(array);

void PrintArray(string[] inArray) // печать матрицы
{
    Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} "); 
    }
    Console.Write("]");
}
