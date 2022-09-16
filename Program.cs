Console.Clear();

Console.Write("Введите массив строк через пробел:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

PrintArray(array);
Console.WriteLine();
int col = sizeNewArray(array);
PrintArray(GetArray(array, col));

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

string[] GetArray(string[] inNewArr, int size)
{
    string[] NewArray = new string[size];
    size = 0;
    for (int j = 0; j < inNewArr.Length; j++)
    {
        if (inNewArr[j].Length <= 3) 
        {
            NewArray[size] = inNewArr[j];
            size++;
        }    
    }
    return NewArray;
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
