using System.ComponentModel;
using System.Threading.Tasks;
using System;

internal class Program
{
    //given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

    //For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

    //Given A = [1, 2, 3], the function should return 4.

    //Given A = [−1, −3], the function should return 1.
    
    private static void Main(string[] args)
    {
        Console.WriteLine(FindSmallestPositive(new int[] { 7, 7, -2, 5, -3, 1 }));
    }
    
    public static int FindSmallestPositive(int[] A)
    {    
        if (A.Max() < 1)
        {
            return 1;
        }
        A = A.Distinct().ToArray();
        Array.Sort(A);
        int aux = 0;

        for (int i = 1; i < A.Length + 1; i++)
        {
            if (!A.Contains(i))
            {
                return i;
            }
            aux = i;
        }
        return ++aux;
    }
}
