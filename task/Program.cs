// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Пример: ["hello","-2","world","=)"] -> [-2,"=)"]

string[] array = { "hello", "-2", "world", "=)" };
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    int count = array[i].Length;
    if (count <= 3)
    {
        
        Console.Write($"{array[i]}");
        if(i < array.Length -1) Console.Write($",");
        
    }
}
Console.Write("]");