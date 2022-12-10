int rightSize = 3;
int size = 5;
string[] array = new string[size];
string[] arrayLessThenThree = new string[size];

Console.Write("Введите 5 слов, символов или цифр через enter: ");

FillArr(array);
PrintArr(array);
Console.WriteLine();

RightLenght(array, arrayLessThenThree);
PrintArr(arrayLessThenThree);

void RightLenght(string[] arr, string[] arrLessThenThree)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= rightSize)
        {
            arrLessThenThree[count] = arr[i];
            count++;
        }
    }
}

void PrintArr(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FillArr(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

