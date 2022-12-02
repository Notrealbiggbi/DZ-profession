// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Пример: ["hello","-2","world","=)"] -> [-2,":-)"]

string[] array = { "hello", "-2", "world", ":-)","trololo","wer" };



string[] CountElementsOfArray(string[] array)
{
    
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int count = array[i].Length;
        if (count <= 3)
        {
            newArray[i] = array[i];    
        } 
    }
    newArray = newArray.Where(x => x != null) .ToArray();
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

string[] result = CountElementsOfArray(array);
PrintArray(result);
