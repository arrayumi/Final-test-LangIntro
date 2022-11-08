//метод для распечатки массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

//метод для превращения имеющегося массива в новый, каждый элемент которого состоит из <=3 символов
string[] ArrayThreeSymbols(string[] array)
{
    int newLength = default;   // вычисляем длину нового массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) newLength++;
    }

    string[] newArray = new string[newLength];  //создаем новый массив

    int j = 0;                              //объявляем счетчик для элементов нового массива
    for (int i = 0; i < array.Length; i++) //проходим по первому массиву и вписываем нужные элементы в новый
    {
        if (array[i].Length < 4) { newArray[j] = array[i]; j++; }
    }
    return newArray;
}

//Запрашиваем у пользователя длину массива и создаем строковый массив
Console.Write("Введите длину массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[arrSize];
//Запрашиваем у пользователя элементы массива
for (int i = 0; i < arrSize; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    arr[i] = Console.ReadLine();
}

//печатаем массив с которым будем работать
PrintArray(arr);

//трансформируем его с помощью метода в новый массив, печатаем
string[] newArr = (ArrayThreeSymbols(arr));
PrintArray(newArr);