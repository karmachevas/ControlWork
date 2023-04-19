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

// Тело решения

string[] A = {"213", "mass", "1000", "yeah", "yes", "ooooops", "no", "1007"};
string[] B = new string[CountArray(A, 3)];
int count = 0;
for (int i = 0; i < A.Length; i++)
{
    if (A[i].Length <= 3)
        {
            B[count] = A[i];
            count++;
        }
}

// Вывод в консоль

Console.Clear(); 
Console.WriteLine("Начальный массив");
PrintArray(A);
Console.WriteLine("Полученный массив");
PrintArray(B);
