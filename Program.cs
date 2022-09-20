﻿Console.Clear();
Console.WriteLine("Экзамен");
    /*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
    длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
    либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, 
    лучше обойтись исключительно массивами.*/
string[] array = { "Rus", "QA", "number", "163", "Hello world!", "qwe" };
string[] result = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) result[i] = array[i];
    else result[i] = string.Empty;
    if (result[i] != string.Empty) Console.Write($"{result[i]} ");
}
