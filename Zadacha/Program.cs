// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using static System.Console;
Clear();
string[] Array = new string[4] {"Hello", "2", "world", ":-)"};
string[] SecondArray = new string[Array.Length];
FinishArray(Array, SecondArray);
PrintArray(SecondArray);




void FinishArray(string[] Inarray1, string[] InArray2)
{
    int count = 0;
    for (int i = 0; i < Inarray1.Length; i++)
    {
    if(Inarray1[i].Length <= 3)
        {
        InArray2[count] = Inarray1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}