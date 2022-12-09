// Нахождение факториала с помощью рекурсии
// Факториал это нахождение произведения чисел от 1 до заданного
// 5! = 1 * 2 * 3 * 4 * 5

// int Factorial(int n) // функция нахождения факториала, принимающая число n 
// {
//     {
//         // 1! = 1
//         // 0! = 1

//         if (n == 1) 
//         return 1;
       
//         else
//         return n * Factorial(n - 1);
//     }

// }
// Console.WriteLine(Factorial(5));


//Флгоритм для вывода факториала по порядку

double Factorial(int n) 

    {
        if (n == 1) 
        return 1;
       
        else
        return n * Factorial(n - 1);
    }
        for(int i = 1; i < 40; i++)     
    {    
        Console.WriteLine($"{i!} {Factorial(i)}"); //выводим числа по порядку (i!) и значение факториала
    }
