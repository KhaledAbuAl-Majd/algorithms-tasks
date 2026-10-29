
int[] arr = [6, 5, 3, 1, 8, 7, 2, 4];

Console.WriteLine("Before: ");
Print(arr);

SelectionSort(arr);

Console.WriteLine("After: ");
Print(arr);

void SelectionSort(int[] arr)
{
    var length = arr.Length;

    for (int i = 0; i < length - 1; i++)
    {
        int smallest = i;
        for (int j = i + 1; j < length; j++)
        {
            if (arr[j] < arr[smallest])
            {
                smallest = j;
            }
        }

        (arr[i], arr[smallest]) = (arr[smallest], arr[i]);
    }
}

void Print(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}