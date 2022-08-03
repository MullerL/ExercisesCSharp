using System.ComponentModel;
using System.Threading.Tasks;
using System;

internal class Program
{
    /*
    Write a function solution that, given an array A of N integers, 
    returns the largest integer K > 0 such that both values K and -K(the opposite number) exist in array A.
    If there is no such integer, the function should return 0. 
    Examples: 
    1. Given A = [3, 2, -2, 5, -3], the function should return 3 (both 3 and -3 exist in array A). 
    2. Given A = [1, 1, 2, -1, 2, -1], the function should return 1 (both 1 and -1 exist in array A). 
    3. Given A = [1, 2, 3, -4], the function should return 0 (there is no such K for which both values K and -K exist in array A). 
    */
    private static void Main(string[] args)
    {
        Console.WriteLine(FindOppositeNumber(new int[] { 3, 7, 7, -2, 5, -3, 1, -1 }));
    }

    public static int FindOppositeNumber(int[] A)
    {
        int num = 0;
        while (A.Max() > 0)
        {
            num = A.Max();
            if (A.Contains(-num))
            {
                return num;
            }
            else
            {
                A = A.Except(new int[] { num }).ToArray();
            }
        }
        return 0;
    }
}
