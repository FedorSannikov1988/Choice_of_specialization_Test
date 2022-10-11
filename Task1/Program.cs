/*
Напишите программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнеия алгоритма. При решении не рекомендуется пользоваться коллекциями
лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
*/

int CalculationNeedDimensionArray(string[] arrayString, int longWords)
{
    string Byffer = String.Empty;

    int CountDimension = 0;

    for (int i = 0; i < arrayString.Length; i++)
    {
        Byffer = arrayString[i];

        if (Byffer.Length <= longWords)
        {
            CountDimension++;
        }
    }

    return CountDimension;
}

string[] СreateSortStringArray(string[] arrayString, int longWords)
{
    string[] SortStringArray = new string[
        CalculationNeedDimensionArray(arrayString: arrayString, longWords: longWords)
    ];

    string Byffer = String.Empty;

    int CountElementNewArray = 0;

    for (int i = 0; i < arrayString.Length; i++)
    {
        Byffer = arrayString[i];

        if (Byffer.Length <= longWords)
        {
            SortStringArray[CountElementNewArray] = Byffer;

            CountElementNewArray++;
        }
    }

    return SortStringArray;
}

void PrintStringArray(string[] arrayString)
{
    for (int i = 0; i < arrayString.Length; i++)
    {
        System.Console.Write($"{arrayString[i]}\t");
    }
}