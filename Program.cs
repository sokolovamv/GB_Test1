Console.Clear();

Console.Write("Введите массив строк через пробел:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .ToArray();
PrintArray(array); // вывод входного массива
Console.WriteLine(); 
int col = sizeNewArray(array); // размерность нового массива
PrintArray(GetArray(array, col)); // вывод выходного массива

int sizeNewArray(string[] inNewArray) // подсчет количества элементов входного массива, длина которых меньше или равна 3
{
    int count = 0;
    for (int i = 0; i < inNewArray.Length; i++)
    {
        if (inNewArray[i].Length <= 3) 
        {
            count++; // счетчик размерности выходного массива
        }    
    }
    return count;
}

string[] GetArray(string[] inNewArr, int size) // формирование выходного массива
{
    string[] NewArray = new string[size];
    size = 0; // обнуляем размерность для поочердного заполнения выходного массива
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

void PrintArray(string[] inArray) // печать массива
{
    Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} "); 
    }
    Console.Write("]");
}
