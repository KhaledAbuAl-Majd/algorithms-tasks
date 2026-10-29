
int[] arr = [6, 5, 3, 1, 8, 7, 2, 4];

Console.WriteLine("Before: ");
Print(arr);

InsertionSort(arr);

Console.WriteLine("After: ");
Print(arr);

void InsertionSort(int[] arr)
{
    var length = arr.Length;

    for (int i = 1; i < length; i++)
    {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && key < arr[j])
        {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = key;

    }
}

void Print(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}