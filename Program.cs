string[] inputArray = new string[] { "apple", "banana", "car", "dog", "elephant", "fox" };
int newArraySize = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        newArraySize++;
    }
}
string[] newArray = new string[newArraySize];
int index = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        newArray[index] = inputArray[i];
        index++;
    }
}
Console.WriteLine("New array:");
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}