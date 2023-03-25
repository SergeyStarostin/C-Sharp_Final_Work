# Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
# Примеры:

  [“hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]

  [“1234”, “1567”, “-2”, computer science”] -> [“-2]

  [“Russia”, “Denmark”, “Kazan”] - > [ ]

# Алгоритм решения:
![Блок-схема](https://github.com/SergeyStarostin/C-Sharp_Final_Work/blob/main/diagram/diagram.PNG)

# Описание методов:

 1.	InputNumber - Метод получение числа от пользователя, используется для ввода количества элементов массива и длины элементов. Существует проверка на ввод целых чисел.*
 2.	InputString - Метод получения строк от пользователя, используется для заполнения массивов.
 3.	CreateUserArray - Метод создания пользователем одномерного массива из строк, количество которых задал пользователь.
 4.	SearchElemens - Метод поиска элементов пользовательского массива определенной длины.
 5.	CreateArray - Метод создания одномерного массива из строковых элементов. Используется для создания массива из отсортированных элементов.
 6.	FillArray - Метод заполнения массива элементами, длина которых не превышает заданной пользователем.
 7.	PrintArray - Метод вывода одномерного массива из строковых элементов в консоль.
