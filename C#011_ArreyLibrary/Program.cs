﻿// Задан массив с N элементами. Необходимо найти элемент find, используя Генератор
// псевдослучайных чисел

void FillArray(int[] collection) //здесь мы описываем функцию заполнения массива
// название функции FillArray, название массива collection
{
    int length = collection.Length; // задаем длинну массива
    int index = 0; //вводим переменную

    while (index < length) // до тех пор, пока значение переменной меньше длины массива
    {
        collection[index] = new Random().Next(1, 10); //этой переменной присваивается 
                                          //рандомное число в диапазоне от 1 до (10-1)
    
        index++; //значение переменной увеличивается на +1
    }
}
int[] array = new int [10]; 
// создаем массив с именем array, которое присваиваем (=) 
//новому массиву, в котором будет 10 элементов

void PrintArray(int[] col) // здесь описываем функцию вывода на экран массива col
{
    int count = col.Length; // задаем длинну массива
    int position = 0; //вводим переменную

     while (position < count) // до тех пор, пока значение переменной меньше длины массива
    {
        Console.WriteLine (col[position]); // выводим на экран найденную переменную массива
    
        position++; //значение переменной увеличивается на +1
    }
}

FillArray(array); // запускаем функцию заполнения массива
PrintArray(array); // запускаем функцию вывода на экран массива