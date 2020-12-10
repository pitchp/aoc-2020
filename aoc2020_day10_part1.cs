using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
        	string test_input = @"";
			string[] raw_arr = day10_input.Split('\n');
			int[] input_arr = new int[raw_arr.Length];
			for (int i = 0; i < raw_arr.Length;i++)
			{
				input_arr[i] = int.Parse(raw_arr[i]);
			}
			
			Array.Sort(input_arr);
			
			
			int onejolt_count = 0;
			int threejolt_count = 1; //device adapter always max+3
			int start_jolt = 0;
			if (input_arr[0] - start_jolt == 1)
			{
				onejolt_count++;
			}
			else if(input_arr[0] - start_jolt == 3)
			{
				threejolt_count++;
			}
			for (int i = 0; i+1 < input_arr.Length; i++)
			{
				
				if (input_arr[i+1] - input_arr[i] == 1)
				{
					onejolt_count++;
				}
				else if (input_arr[i+1] - input_arr[i] == 3)
				{
					threejolt_count++;
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			Console.WriteLine("Day 10 part 1 answer is: " +
			(onejolt_count * threejolt_count));
			
			
			
        }
        
    }
}