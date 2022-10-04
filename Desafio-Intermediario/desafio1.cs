using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    	Array.Sort(num);//oderna array
		// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i=0;i<n;i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int countMaior = -1;
		int count = 1;
        for (int i=1;i<=nums.Length;i++)
        {
			if ( i < nums.Length && nums[i] == nums[i-count] )
				count++;
			 else if ( count > countMaior ) 
				major = nums[i-1];
				countMaior = count;
				
        }
        return major;
    }
}