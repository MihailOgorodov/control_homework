using static System.Console;
Clear();

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

void PrintArray(string[] inArray2)
{
    for (int i = 0; i < inArray2.Length; i++)
    {
        Write($"{inArray2[i]} ");
    }
}
