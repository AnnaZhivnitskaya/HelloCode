//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” маленькими “с”

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали "
+ "вместо нашего милого Винценгероде, вы бы взяли приступом  "
+ "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// Чтобы обратиться к какому-либо символу строки, надо обратиться к нему по его номеру
// в строке. Нумерация начинается с нуля.

string Replase(string text, char oldValue, char newValue)
{
    string newText = String.Empty; //вводим ПУСТУЮ строку
    int length = text.Length; // вводим переменную длины строки
    for(int i = 0; i < length; i++) //счетчик знаков в длине строки
    {
        if(text[i] == oldValue) // если знак в старом тексте (text[i]) соответствует oldValue 
        newText = newText + $"{newValue}"; // то в строку newText помещаем значение newValue
        
        else 
        newText = newText + $"{text[i]}"; // иначе в строку newText помещаем значение text[i]
    }
    return newText;
}
string newText = Replase(text, ' ', '|'); // строку newText преобразовываем с помощью функции Replase
                                          // и здесь указываем значения для oldValue и newValue
Console.WriteLine(newText);

Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);