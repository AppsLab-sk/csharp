using System.Reflection.Metadata.Ecma335;

namespace AppsLab_015_Arrays;

/// <summary>
/// Class ArrayProcessor provides methods for working with integer arrays.
/// </summary>
public class ArrayProcessor
{
    /// <summary>
    /// Returns the first element of the provided array.
    /// If the array is empty, it returns 0.
    /// </summary>
    /// <param name="numbers">Array of integers.</param>
    /// <returns>First element of the array, or 0 if array is empty.</returns>
    public int GetFirstElement(int[] numbers)
    {

        if (numbers.Length == 0) 
         {
           return 0;
         }
        return numbers[0];

    }
    /// <summary>
    /// Returns the last element of the provided array.
    /// If the array is empty, it returns 0.
    /// </summary>
    /// <param name="numbers">Array of integers.</param>
    /// <returns>Last element of the array, or 0 if array is empty.</returns>
    public int GetLastElement(int[] numbers)
    {
        
          
            if (numbers.Length == 0) 
        {
            return -1;
        }
        return numbers.Length - 1;
     }

    /// <summary>
    /// Returns an element at a specific position in the provided array.
    /// If the position is outside of the array range, it returns 0.
    /// </summary>
    /// <param name="numbers">Array of integers.</param>
    /// <param name="position">Position of the desired element.</param>
    /// <returns>Element at the specified position, or 0 if position is out of range.</returns>
    public int GetElementAtPosition(int[] numbers, int position)
    {
        if (position >= 0 && position < numbers.Length)
        {
            return numbers[position];
        }

        return 0;
        
    }
    /// <summary>
    /// Returns the length of the provided array.
    /// </summary>
    /// <param name="numbers">Array of integers.</param>
    /// <returns>Length of the array.</returns>
    public int GetLength(int[] numbers)
    {
        return numbers.Length;
    }
}








