int found_max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//  индексы     0   1   2   3   4  5   6   7   8
int[] array = {15, 312, 83, 41, 35, 6, 17, 78, 39}; //задаем массив с названием array 

array[0] = 12; //Обращение к массиву и присвоение нулевому элементу значение 12
//в строке 11 мы ПЕРЕНАЗНАЧИЛИ ЗНАЧЕНИЕ элемента [0]
//Console.WriteLine(array[0]); // обращение к массиву и получение 
                              //значения числа с заданным индексом
int max = found_max(
found_max(array[0], array[1], array[2]),
found_max(array[3], array[4], array[5]),
found_max(array[6], array[7], array[8]));

Console.WriteLine(max);