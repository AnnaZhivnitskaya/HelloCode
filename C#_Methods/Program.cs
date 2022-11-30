// 1. Метод ничего не принимает и ничего не возвращает

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

/*void Method21(string msg, int count) // сообщение и счетчик, сколько раз показ текст
{
    int i = 0; //вводим переменную
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); или
Method21(msg:"Текст", count: 4); или
Method21(count: 4, msg:"Новый Текст"); при вызове такого метода не обязательно вводить аргументы по порядку  */

// Метод ничего не принимает,но что-то возвращает

/*int Method3()
{
    return DateTime.Now.Year;
}
int date = Method3();
Console.WriteLine(date);*/

//4. Метод что-то принимает и что-то возвращает

string Method4(int count, string text) //может отдавать и принимать любой тип данных//
{
    int i = 0;
    string result = string.Empty; // string result = ""; присваиваем переменной resurlt 
                                    // пустая строка
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(3, "asd");

Console.WriteLine(res);