﻿// 1. Метод ничего не принимает и ничего не возвращает

/*void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); // так вызывается метод*/

// 2. Метод что-то принимает, но ничего не возвращает

/*void Method2(string msg) //метод принимает на входе какую-то строку
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");*/

// 2.1. Когда используются именованные сообщения

void Method21(string msg, int count) // сообщение и счетчик, сколько раз показ текст
{
    int i = 0; //вводим переменную
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);