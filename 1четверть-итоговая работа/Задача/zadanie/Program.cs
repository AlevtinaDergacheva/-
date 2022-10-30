// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры либо
// задать на старте выполнения алгоритма.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

for (int i=0; i < array.Length; i++)
      array[i] = Console.ReadLine();


string[] result = FindStrArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindStrArray(string[] input, int n) 
{
    string[] output = new string[CountStrArray(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountStrArray(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }

    return count;
}

