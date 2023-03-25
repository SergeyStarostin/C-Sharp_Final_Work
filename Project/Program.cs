﻿// # Задача:

// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// # Примеры:

// [“hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]
// [“1234”, “1567”, “-2”, computer science”] -> [“-2]
// [“Russia”, “Denmark”, “Kazan”] - > [ ]











int InputNumber (string message) // Метод получение числа от пользователя.
{
    Console.Write(message);
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) return value;
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

string InputString(string message) // Метод получения строки от пользователя.
{
    Console.Write($"{message}");
    return Console.ReadLine();
}