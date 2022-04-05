/*  Написать программу, которая из имеющегося массива строк формирует
    массив из строк, длина которых меньше либо равна 3 символа.
    Первоначальный массив можно ввести с клавиатуры,
    либо задать на старте выполнения алгоритма.
    При решении не рекомендуется пользоваться коллекциями,
    лучше обойтись исключительно массивами. */

void PrintArray(string[] array){
    Console.WriteLine("Primary array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine(array[i]);
    }
}    
Console.WriteLine("Program starting...\nChoose option: \n1. Manual entry of strings\n2. Use prepared data\n   Type Q to exit");
char answerQuestion = char.Parse(Console.ReadLine());

switch (answerQuestion)
{
    case '1':
        Console.WriteLine("First method");
        break;
    case '2':
        string[] array = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
        break;
    case 'Q':
        Console.WriteLine("Program shutdown");
        break;
    case 'q':
        Console.WriteLine("Program shutdown");
        break;
}