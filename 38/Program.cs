// Не знаю верно ли я монял задание "Задать массив вещественных чисел".  Я задал массивы типа double. 
// Пользователю предлагается ввести число элементов массива, после чего генерируется массив из положительных чисел (0-1000) и выводится на экран, определяется максимальный и минимальный элемент, выводится результат вычитания max - min.
// Использовал готовые методы с этого и прошлых семинаров. 
// Метод GetNumberFromUser - для ввода кол-ва элементов массива, с проверкой на корректность ввода.
// Метод getArray - для генерации массива
// getMax, getMin - определяет максимальное и минимальное значение.

Console.Clear();

int size = GetNumberFromUser("Введите число элементов массива: ","Ошибка ввода!");

double[] array = getArray(size, 0, 1000);
Console.WriteLine(String.Join(" ", array));

double max = getMax(array);
double min = getMin(array);
double diff = max - min;

Console.WriteLine($"Разность максимального и минимального элементов -> {max} - {min} = {diff}");

double[] getArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

double getMax(double[] arr)
{   
    double max = arr[0];
    for (int i = 0; i<arr.Length; i++)
    {   
        if (arr[i]>max) max = arr[i];
    }
    return max;
}

double getMin(double[] arr)
{   
    double min = arr[0];
    for (int i = 0; i<arr.Length; i++)
    {   
        if (arr[i]<min) min = arr[i];
    }
    return min;
}

int GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}