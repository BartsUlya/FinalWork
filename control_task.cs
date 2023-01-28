string[] inputArray = new string[4] { "Hello", "2", "world", ":-)" };

PrintArray(SortInputArray(inputArray));

string[] SortInputArray(string[] inputArray)
{
    string[] outputArray = new string[inputArray.Length];
    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[j] = inputArray[i];
            j++;
        }
    }
    Array.Resize(ref outputArray, j);
    return outputArray;
}

void PrintArray(string[] outputArray)
{
    for (int i = 0; i < outputArray.Length; i++)
    {
        Console.Write(outputArray[i] + " ");
    }
    Console.WriteLine();
}
