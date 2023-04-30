// Создание функций и методов

int CountArray(string[] array, int N)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= N)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void FillArray(string[] arrayA, string[] arrayB, int N)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= N)
            {
                arrayB[count] = arrayA[i];
                count++;
            }
    }
}


// Тело решения

string[] A = {"213", "mass", "1000", "yeah", "yes", "ooooops", "no", "1007"};
string[] B = new string[CountArray(A, 3)];


// Вывод в консоль

Console.Clear(); 
Console.WriteLine("Начальный массив");
PrintArray(A);
FillArray(A, B, 3);
Console.WriteLine("Полученный массив");
PrintArray(B);
