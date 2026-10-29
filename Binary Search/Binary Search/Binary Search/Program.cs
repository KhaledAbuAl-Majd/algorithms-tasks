
int[] arr = [6, 5, 3, 1, 8, 7, 2, 4];

arr.Sort();

Console.WriteLine("array: ");
Print(arr);

Console.Write("\nEnter number you want to find?: ");
var number = Convert.ToInt32(Console.ReadLine());

var index = BinarySearch(arr, number);

if (index == -1)
    Console.WriteLine("\nNumber not found");
else
    Console.WriteLine($"\nNumber founed at index: {index}");

int BinarySearch(int[] arr, int number)
{
    int start = 0;
    int end = arr.Length - 1;
    int middle = -1;

    while (start <= end)
    {
        middle = start + (end - start) / 2;

        if (arr[middle] == number)
        {
            return middle;
        }
        else if (number < arr[middle])
        {
            end = middle - 1;
        }
        else
        {
            start = middle + 1;
        }
    }

    return -1;
}

void Print(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}