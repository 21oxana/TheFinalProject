/* Написать программу, которая из имеющегося массива строк формирует массив 
из строк, длина которых меньше либо равна 3 символа.
 Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. */

string[] array1 = new string[4] {"hello", "2", "world", ":-)"}; //массив задан на старте с примером из задания
string[] array2 = new string[array1.Length];

void SelectionArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int  index = 0; index < array1.Length; index++)
    {
    if(array1[index].Length <= 3)
        {
        array2[count] = array1[index];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine();
}
SelectionArray(array1, array2);
PrintArray(array2);
