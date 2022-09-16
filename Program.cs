Console.Clear();

Console.Write("Введите массив строк через пробел:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

PrintArray(array);
Console.WriteLine();
int col = sizeNewArray(array);

int sizeNewArray(string[] inNewArray)
{
    int count = 0;
    for (int i = 0; i < inNewArray.Length; i++)
    {
        if (inNewArray[i].Length <= 3) 
        {
            count++;
        }    
    }
    return count;
}

void PrintArray(string[] inArray) // печать матрицы
{
    Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} "); 
    }
    Console.Write("]");
}
