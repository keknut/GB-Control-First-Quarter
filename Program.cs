﻿/*  Написать программу, которая из имеющегося массива строк формирует
    массив из строк, длина которых меньше либо равна 3 символа.
    Первоначальный массив можно ввести с клавиатуры,
    либо задать на старте выполнения алгоритма.
    При решении не рекомендуется пользоваться коллекциями,
    лучше обойтись исключительно массивами. */


/*  Метод выводит массив строк в консоль
    Input: string[]
    Output: null */

void PrintArray(string[] array){
    Console.WriteLine("-------------------");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"[{i}]: {array[i]}");
    }
}

/*  Метод считает количество элементов в массиве строк,
    в которых не больше трёх символов
    Input: string[]
    Output: int */

int NumberWordsThreeChar(string[] array){
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i].Length <= 3){
            number++;
        }
    }
    return number;
}

/*  Метод проверяет, есть ли в исходном массиве элементы состоящие из трёх
    и менее символов. Если есть, помещает элемент в новый массив.
    Input: string[], string[]
    Output: null */

void FillArrayWordsThreeChar(string[] primaryArray, string[] fillArray){
    int j = 0;
    for (int i = 0; i < primaryArray.GetLength(0); i++)
    {
        if(primaryArray[i].Length <= 3){
            fillArray[j] = primaryArray[i];
            j++;
        }
    }
}



Console.WriteLine("Program starting...\nChoose option: \n1. Manual entry of strings\n2. Use prepared data\n   Type Q to exit");
char answerQuestion = char.Parse(Console.ReadLine());

switch (answerQuestion)
{
    case '1':
        Console.WriteLine("\nHow many words will be in the array?");
        int numberWords = int.Parse(Console.ReadLine());
        string[] arrayManual = new string[numberWords];
        break;
    case '2':
        string[] arrayPrepared = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
        Console.WriteLine("\nPrimary array");
        PrintArray(arrayPrepared);
        string[] arrayFinally = new string[NumberWordsThreeChar(arrayPrepared)];
        FillArrayWordsThreeChar(arrayPrepared, arrayFinally);
        Console.WriteLine("\nNew array");
        PrintArray(arrayFinally);
        break;
    case 'Q':
        Console.WriteLine("Program shutdown");
        break;
    case 'q':
        Console.WriteLine("Program shutdown");
        break;
}