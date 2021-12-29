int[] array = new int[8];
string EvenNumbers(int[] array)
{
    string arr = string.Empty;
    string arr1 = string.Empty;
    
    for (int m = 0; m < array.Length; m++)
    {
        array[m] = new Random().Next(-10, 11);
    }
    for (int m = 0; m < array.Length; m++)
    {
        arr += $"{array[m]}  ";
    }
    for (int m = 0; m < array.Length; m++)
    {
        if (array[m] % 2 == 0)
        {
            arr1 += $"{array[m]}  ";
        }
    }
    return $"[{arr}] -> [{arr1}]";
}
Console.WriteLine(EvenNumbers(array));
