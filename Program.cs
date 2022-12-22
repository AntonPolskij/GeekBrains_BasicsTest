void PrintStringArray(string[] array)
{
    foreach (string el in array)
    {
        System.Console.Write(el + " ");
    }
};


string[] Solution(string[] array)
{
    string solutionInString = String.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) solutionInString += (array[i] + ",");
    }

    return solutionInString.Split(',', StringSplitOptions.RemoveEmptyEntries);
}



string[] array = new string[] { "hello", "2", "world", ":-)" };

PrintStringArray(Solution(array));