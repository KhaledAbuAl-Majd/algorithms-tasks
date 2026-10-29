
int[] arr = [6, 5, 3, 1, 8, 7, 2, 4, 9];

Console.WriteLine("Before: ");
Print(arr);

MergeSort(arr, 0, arr.Length -1 );

Console.WriteLine("After: ");
Print(arr);

void MergeSort(int[] arr, int left, int right)
{
    if (left >= right)
        return;

    int mid = (right - left + 1) / 2 + left;

    //divide

    MergeSort(arr, left, mid - 1);
    MergeSort(arr, mid, right);
    //merge

    Merge(arr, left, mid, right);
}

void Merge(int[] arr, int left, int mid, int right)
{
    int length = right - left + 1;
    int[] temp = new int[length];
    int leftIndex = left;
    int rightIndex = mid;
    //int tempIndex = 0;

    for (int tempIndex = 0; tempIndex < length; tempIndex++)
    {
        var newItem = int.MaxValue;

        if (leftIndex < mid)
        {
            if (rightIndex > right || arr[leftIndex] <= arr[rightIndex])
            {
                newItem = arr[leftIndex++];
            }
            else
            {
                newItem = arr[rightIndex++];
            }
        }
        else
        {
            newItem = arr[rightIndex++];
        }

        temp[tempIndex] = newItem;
    }

    for (int tempIndex = 0; tempIndex < length; tempIndex++)
    {
        arr[left + tempIndex] = temp[tempIndex];
    }

}

void Print(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}