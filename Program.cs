using static System.Console;
Clear();
Write("Введите символы через пробел: ");
string[] firstArray = GetArray(ReadLine()!);
PrintArray(firstArray);
WriteLine();
string[] secondArray = new string[firstArray.Length];
ArrayCompare(firstArray, secondArray);
PrintArray(secondArray);

string[] GetArray(string line)
{
          string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
          string[] arr = new string[lineArray.Length];
          for (int i = 0; i < lineArray.Length; i++)
          {
                    arr[i] = Convert.ToString(lineArray[i]);
          }
          return arr;
}

void ArrayCompare(string[] inArray, string[] inArray1)
{
          int count = 0;
          for (int i = 0; i < inArray.Length; i++)
          {
                    if (inArray[i].Length <= 3)
                    {
                              inArray1[count] = inArray[i];
                              count++;
                    }
          }
}

void PrintArray(string[] inArray2)
{
    for (int i = 0; i < inArray2.Length; i++)
    {
        Write($"{inArray2[i]} ");
    }
}