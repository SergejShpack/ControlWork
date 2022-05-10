

string[] arrayString = { "hello", "2", "world", ":-)", ":-(" };

int lessLength = 3;


int countWordsLengthLessGivenIntLen(string[] arrStr, int intLen)
{
    int count = 0;
    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length <= intLen) count++;
    }
    return count;
}

string[] fillArraytWordsLengthLessGivenIntLen(string[] arrStr, int intLen)
{
    int index = 0;
    string[] resultArray = new string[countWordsLengthLessGivenIntLen(arrStr, intLen)];

    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length <= intLen)
        {
            resultArray[index] = arrStr[i];
            index++;
        }
    }

    return resultArray;
}

void printArray(string[] arrStr)
{
    for (int i = 0; i < arrStr.Length; i++)
        Console.Write(arrStr[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("В массиве:");
printArray(arrayString);
Console.WriteLine(countWordsLengthLessGivenIntLen(arrayString, lessLength) + " Где количество символов меньше или равно  " + lessLength);
printArray(fillArraytWordsLengthLessGivenIntLen(arrayString, lessLength));
