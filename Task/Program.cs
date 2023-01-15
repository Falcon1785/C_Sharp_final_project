// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] arr_1 = new string[7] {"gday", "55", "hello", "world", "shoes", "777", "hq"};
string[] arr_2 = new string[arr_1.Length];
void ConvertArr(string[] arr_1, string[] arr_2)
{
    int count = 0;
    for (int i = 0; i < arr_1.Length; i++)
    {
    if(arr_1[i].Length <= 3)
        {
        arr_2[count] = arr_1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ConvertArr(arr_1, arr_2);
PrintArray(arr_2);