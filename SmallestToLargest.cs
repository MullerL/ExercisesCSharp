using System.ComponentModel;
using System.Threading.Tasks;
using System;

internal class Program
{
    /*
    An online shop sells T-shirts of three sizes: S (small), M (medium) and L (large). 
    Write a function solution that, given a string T of length N containing letters S, M and L, 
    returns a sorted string T by T-shirt sizes from the smallest to the largest. 
    Examples: 
    1. Given T = "MSSLS", the function should return "SSSML". 
    2. Given T = "LLMS", the function should return "SMLL'. 
    3. Given T = "SMS", the function should return "SSM". 
    */
    private static void Main(string[] args)
    {
        Console.WriteLine(SmallestToLargest("SLMS"));
    }
    public static string SmallestToLargest(string T)
    {
        char[] characters = T.ToArray();
        Array.Sort(characters);
        Array.Reverse(characters);
        return new string(characters);
    }
}
