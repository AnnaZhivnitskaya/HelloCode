// УПОРЯДОЧИВАНИЕ ДАННЫХ ВНУТРИ МАССИВА ОТ MIN ДО MAX

// АЛГОРИТМ СОРТИРОВКИ МЕТОДОМ ВЫБОРА (МЕТОДОМ МИН И МАКС)

int[] array = { 2, 7, 6, 1, 2, 4, 9, 6 };

void PrintArray(int[] mnb)
{
    int length = mnb.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{mnb[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++) // от длины отнимаем 1, чтобы количество элементов
                                             // совпало со стартом j
    {
        int minPosition = i; // переменная с мин значением, на начальном этапе = i

        //в этом блоке кода ищем минимальный элемент

        for (int j = i + 1; j < arr.Length; j++)
        // мин ищется в остатке массива, отсекая просмотренную часть i 
        //и начиная со следующей после i позиции
        {
            if (arr[j] < arr[minPosition])

                minPosition = j;
        }

        // эти три строки - стандартный обмен местами двух элементов массива 

        int temp = arr[i]; // временная переменная, куда записываем i
        arr[i] = arr[minPosition]; // на место i записываем значение minPosition
        arr[minPosition] = temp; // на место minPosition записываем значение из temp
    }
}

PrintArray(array);
SelectionSort(array);

PrintArray(array);