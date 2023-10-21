// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

using System.Xml.XPath;

string[]arrayOne = {"Hello","2","world",":-)"};

int LengthArray(string[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
           count ++;   
        } 
    }    
    return count;    
}  

void SortArray(string[]array,string[]result)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
           result[count] = array[i];
           count ++;   
        } 
    } 
}       

void PrintArray(string[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("''"+ array[i] +"''");
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

PrintArray(arrayOne);
Console.Write(" -> ");
int res = LengthArray(arrayOne);
string[]result = new string[res];
SortArray(arrayOne,result);
PrintArray(result);

