// # Задача:

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

string [] CreateUserArray(int size) // Метод создания пользователем одномерного массива из строк.
{
    string[] array = new string[size];
    int element = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputString($"Введите {element} элемент массива: ");
        element++;
    }
    return array;
}

int SearchElements(string[] array, int max) // Метод поиска элементов массива.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= max) count++;
    }
    return count;
}

string[] CreateArray(int size) // Метод создания одномерного массива.
{
    string[] array = new string[size];
    return array;
}

string[] FillArray(string[] newArray, string[] array, int max) // Метод заполнения массива элементами.
{
    int j = 0;
    for (int k = 0; k < array.Length; k++)
    {
        
        if (array[k].Length <= max)
        {
            newArray[j] = array[k];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array) // Метод вывода одномерного массива в консоль.
{
    Console.Write("{ ");
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("}");
    Console.WriteLine();
}