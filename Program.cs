/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/
using static System.Console;

string[] stringArray = { "Hello", "    ", "world", "2", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

void PrintStringArr(string[] stringArray)
{
    Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Write($"\"{stringArray[i]}\"");
        if (i != stringArray.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
}

int SearchArrayLengthMin3(string[] stringArray)
{
    int numberOfString = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            numberOfString++;
        }
    }
    return numberOfString;
}

string[] CreateArrayLengthMin3(string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            newStringArray[j] = stringArray[i];
            j++;
        }
    }
    return newStringArray;
}

PrintStringArr(stringArray);
int sizeNewArray = SearchArrayLengthMin3(stringArray);
string[] newStringArray = CreateArrayLengthMin3(stringArray, sizeNewArray);
Write(" --> ");
PrintStringArr(newStringArray);