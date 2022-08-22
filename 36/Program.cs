// Пользователю предлагается ввести число элементов массива, после чего генерируется массив из положительных чисел(0-1000cd) и выводится на экран, определяется и выводится сумма элементов находящихся на чётных позициях.
// Использовал готовые методы с этого и прошлых семинаров. 
// Метод GetNumberFromUser - для ввода кол-ва элементов массива, с проверкой на корректность ввода.
// Метод getArray - для генерации массива.
// getSum - определяет сумму чисел находящихся на чётных позициях, его уже написал самостоятельно.

Console.Clear();

int size = GetNumberFromUser("Введите число элементов массива: ","Ошибка ввода!");

int[] array = getArray(size, 0, 1000);
Console.WriteLine(String.Join(" ", array));

int sum = getSum(array);
Console.WriteLine($"Сумма чисел находящихся на чётных позициях -> {sum}");

int[] getArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int getSum(int[] arr)
{   
    int sum = 0;
    for (int i = 1; i<arr.Length; i = i + 2)
    {   
    sum = sum + arr[i];
    }
    return sum;
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