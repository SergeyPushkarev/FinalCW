
string[] FilterArray(string[] array)
{
    int sizeFilteredArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) sizeFilteredArray++;
    }

    string[] filteredArray = new string[sizeFilteredArray];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            filteredArray[count] = array[i];
            count++;
        }
    }
    return filteredArray;
}

void ReadArray(string[] array)
{
    System.Console.Write("[");
   for (int i = 0; i < array.Length; i++)
   {
        System.Console.Write(array[i]);
        if(i < array.Length-1) System.Console.Write(", ");
   }
    System.Console.Write("]");
}

string[] arrayStr = new string[5];
for (int i = 0; i < arrayStr.Length; i++)
{
    System.Console.Write($"Введите {i+1} строку: ");
    arrayStr[i] = System.Console.ReadLine()!;
}

System.Console.Write("Текущий массив: ");
ReadArray(arrayStr);

System.Console.WriteLine();
string[] filteredArray =  FilterArray(arrayStr);
System.Console.Write("Отфильтрованный массив: ");
ReadArray(filteredArray);