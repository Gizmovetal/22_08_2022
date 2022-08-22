// Пользователю предлагается ввести число элементов массива, после чего генерируется массив из положительных трёхзначных чисел и выводится на экран, определяется и выводится кол-во чётных чисел в массиве.
// Использовал готовые методы с этого и прошлых семинаров. 
// Метод GetNumberFromUser - для ввода кол-ва элементов массива, с проверкой на корректность ввода.
// Метод getArray - для генерации массива.
// getEvenNumber - определяет кол-во чётных числе, его уже написал самостоятельно.

Console.Clear();

int size = GetNumberFromUser("Введите число элементов массива: ","Ошибка ввода!");

int[] array = getArray(size, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int count = getEvenNumber(array);
Console.WriteLine($"Количество чётных числе в массиве -> {count}");

int[] getArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int getEvenNumber(int[] arr)
{   
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {   
        if (arr[i] % 2 == 0) count = count + 1;
    }
    return count;
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