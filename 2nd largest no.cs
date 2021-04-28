using System.IO;
using System;

public class program
{
    public static void Main()
    {
        int[] array= {2,55,6,9,46,34};
        Array.Sort(array);
        Console.WriteLine("Second Highest Value in Array:" +array[array.Length-2]);
    }
}