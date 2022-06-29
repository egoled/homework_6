// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] InputNumbers(int countM)
{
    int[] MNumber = new int[countM];
    for (int i = 0; i < countM; i++)
    {
        MNumber[i] = prompt($"Введите {i + 1} из {countM} чисел ");
    }
    return MNumber;
}
int GetPositiveElements(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}


int M = prompt("Введите количество чисел, из которых состоит массив  ");
int[] newarray = InputNumbers(M);
Console.WriteLine($"Вы ввели {GetPositiveElements(newarray)} положительных чисел");
