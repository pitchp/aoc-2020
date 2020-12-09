using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aoc2020_day9u : MonoBehaviour {

	void Start () {
		string day9_input = @"";
		string[] raw_arr = day9_input.Split('\n');
		long[] input_arr = new long[raw_arr.Length];
		for (int i = 0; i < input_arr.Length; i++)
		{
			input_arr[i] = long.Parse(raw_arr[i]);
		}
		long sum_for_p2 = 0;
		for (int i = 0; i < input_arr.Length; i++)
		{

			long[] set = new long[25];
		 	System.Array.Copy(input_arr,i,set,0,25);
			long sum = input_arr[i+25];
			int n = set.Length;
			if (isSubsetSum(set, n, sum, 0) == false)
			{
				Debug.Log("Day 9 part 1 answer is: " + sum);
				sum_for_p2 = sum;
				break;
			}	
		}
		//part 2
		int index_for_p2 = System.Array.IndexOf(input_arr,sum_for_p2);
		int complete_flag = 0;
		for (int i = 0; i < input_arr.Length; i++)
		{
			for (int j = index_for_p2; j != i+1;)
			{
				int set_length = input_arr.Length - i - (input_arr.Length - j);
				long[] set = new long[set_length];
				System.Array.Copy(input_arr,i,set,0,set_length);
				if (sum(set) > sum_for_p2)
				{
					j--;
				}
				else if (sum(set) < sum_for_p2)
				{
					break;
				}
				else if (sum(set) == sum_for_p2)
				{
					System.Array.Sort(set);
					long p2_sum = set[0] + set[set_length-1];
					Debug.Log("Day 9 part 2 answer is: " + p2_sum);
					complete_flag++;
					break;
				}
			}
			if (complete_flag == 1)
			{
				break;
			}
		}
	}
	// isSubsetSum from geeksforgeeks.org -> modified for this problem
	static bool isSubsetSum(long[] set, int n, long sum, int element)
    {
        if (sum == 0 && element == 2)
            return true;
        if (n == 0 || element > 2)
            return false;
 
        if (set[n - 1] > sum)
            return isSubsetSum(set, n - 1, sum, element);
 
        return isSubsetSum(set, n - 1, sum, element) 
          || isSubsetSum(set, n - 1, sum - set[n - 1], element+1);
    }
	// Uh.. where is Linq in Unity ?
	static long sum(long[] array)
	{
		long result = 0;
		for (int i = 0; i < array.Length; i++)
		{
			result += array[i];
		}
		return result;
	}
}
