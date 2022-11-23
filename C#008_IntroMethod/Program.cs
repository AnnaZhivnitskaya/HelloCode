// Нахождение максимума из девяти чисел

//вводим функцию "found_max" с аргументами arg1, arg2, arg3, 
//которая будет возвращать значение 
int found_max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 16; //задаем переменные, сразу присваивая им имена,
int b1 = 7; // которые делят их на три группы: 1, 2 и 3
int c1 = 32;
int a2 = 17;
int b2 = 7120;
int c2 = 3;
int a3 = 1;
int b3 = 27;
int c3 = 12;

int max1 = found_max(a1, b1, c1); //задаем переменную "мах1", которую приравниваем
//к результатам работы функции "found_max" и привсаиваем значения 
// для переменных arg1, arg2, arg3
int max2 = found_max(a2, b2, c2);
int max3 = found_max(a3, b3, c3);
int max_all = found_max(max1, max2, max3);

//if (b1 > max) max = b1;
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

Console.WriteLine(max_all);