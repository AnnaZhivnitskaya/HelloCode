﻿// Имеется одномерный массив array из n элементов
// Необходимо найти элемент массива, значение которого равно find

int[] array = {15, 32, 83, 6, 35, 6, 17, 78, 39};

int n = array.Length; //где Length - это метод, считывающий длину массива (кол-во элементов))

int find = 6; // вводим переменную find, которую надо найти и задаем любое значение из массива

int index = 0; //вводим счетчик index и устанавливаем его в позицию 0, т.е в начальный элемент массива

while (index < n)
{
if (array[index] == find) //если элемент index совпадает (==) с find
{
    Console.WriteLine(index);
    break;
}
//index = index + 1; укороченный вариант написания на след строке
index++;
}