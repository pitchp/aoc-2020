using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main() 
        {
            string input = @".........#.#.#.........#.#.....
...#......#...#.....#.....#....
#.....#.....#.....#.#........#.
......#..#......#.......#......
.#..........#.............#...#
............#..##.......##...##
....#.....#..#....#............
.#..#.........#....#.#....#....
#.#...#...##..##.#..##..#....#.
.#.......#.#...#..........#....
...#...#........##...#..#.....#
..................#..........#.
.....#.##..............#.......
........#....##..##....#.......
...#.....#.##..........#...##..
.......#.#....#............#...
..............#......#......#..
#.......#...........#........##
.......#.......##......#.......
................#....##...#.#.#
#.......#....................#.
.##.#..##..#..#.#.....#.....#..
#...#............#......##....#
.#....##.#......#.#......#..#..
..........#........#.#.#.......
...#...#..........#..#....#....
..#.#...#...#...##...##......#.
......#...#........#.......###.
....#...............#.###...#.#
..................#.....#..#.#.
.#...#..#..........#........#..
#..........##................##
...#.....#...#......#.#......#.
......#..........#.#......#..#.
..#......#.....................
............#.........##.......
......#.......#........#.......
#.#...#...........#.......#....
.#.#........#.#.#....#........#
#.....##........#.#.....#.#....
.#...#..........##...#.....#..#
.........#....###............#.
..#...#..............#.#.#.....
.....#.#.#..#.#.#.###......#.#.
.#.##...#.......###..#.........
.....##....#.##..#.##..#.......
..#...........##......#..#.....
................##...#.........
##.....................#..#.###
...#..#....#...........#.......
.#.............##.#.....#.#....
.......#.#.#....##..#....#...#.
...##..#..........#....#.......
....##......#.........#........
.##....#...........#.#.......#.
...#...#.##.......#.#..........
..#.........#.##...........#...
....#.##........#.......#...##.
...................#..#..#...##
#...#......###..##.#..###......
#.............#.#........#...#.
...#...#..#..#..............#..
#.....#..#...#...#......#.#..#.
...##.............#........##.#
......#.#.........#.#....#...#.
........##............#...#....
............#.#...#......#.....
...#...........#...#...........
.........#.#......#............
....#.............#..#.....#..#
#.....#...........#.....#.#.#.#
.............#.....##......#...
...................###.#......#
#.##.....#...#..#..#...#....#..
............#.....#....#.#.....
#....#..#..........#....#..#...
..........##..................#
....#.......###..#......###....
.......#...#.##.##..#....##....
...##...............#.....#...#
#...........#...#......#..#..#.
..##....#.......#...#.....#....
.......##..............#.##..#.
.#......#..........#.......#...
....##...................#.#..#
......#....###................#
.#........#...........#........
.#.....##....#..##...........#.
##..............##...#.......#.
......#..........#..........##.
..#.....#.#.........####....#..
.............#......#......#...
..#.............#...........##.
#.#...#........#..........##...
...#....#.....#.....#.....##...
......#........................
......#..#...#......#.....#....
......#....##.....#....#.......
#.#......#.##..#...............
..........#.#.##..##..#........
......#.#..#....###.#..........
........................#....#.
#.#.............#....#.....##.#
.#.#..........#.......#..#....#
..#...#......#..#..#...#.#...#.
...#.##...###..................
........#.#...........#...#....
........#..........#....#......
#....#........#.......##.....#.
......###...##...#......#......
............#.......#.....##..#
....#..#.......##......#.......
#............##................
...............#..#......#...#.
.#....##...#......#............
#...#................#.........
..#....#..#........##......#...
....#....###......##.#.......#.
......#.#..#.#..#....#..#......
....#..........#..#..#.........
.#..#.......#......#........#..
.......#..#..#............#....
.............#...#....#..#.....
..............#.#.#.........#..
#.....##.......#....#..........
...#.....#......#..............
...##.#..#.#........#..##....#.
.......#.#.....##..#...........
.....#.#....#..................
.#......#.###..............##..
..#....#...#..#...##...##....#.
..........##..#...#..#.........
..#............#........#.#...#
.........................#.#.#.
......#........#.#..#......##.#
#.#......#..#.........#........
.....#........#......#...#.#...
........##....##....#.#........
....#....#.#...#...##....#..#..
#.............#.....#..........
#............##..#............#
..#.#......#........#..........
.#......#......#.#.##.##.......
..#.....#..........#......##...
...#......#...#.##....#.....##.
......#......#...........#.#...
....#........#..#..#........#.#
....#.........#.....#...#.#.#..
....#.....###........#.........
.............##........#.#.....
...#............#........#.#.#.
......#....#.......#.#.........
.....#................#........
.#....#..#.#.............#...#.
#..##...#............#......#..
...#..#........................
.#.#...........#.......#.......
#....###............##.........
...##....#.#............##.....
.........####......#........#..
.....#.......#.#...............
.......#...#.###..#....#...#..#
...#.....##..#....#..#.#...###.
.............#........#.#.#..#.
................#..........##..
.......####..##..##........##.#
..#......#..#..#.#.##..........
#....#........#....#...###.#.#.
........##........##.....#.....
...........#.#...........#....#
#.............#...........#....
...#.........#...#....#.....#..
..##......#...#...............#
.............#.........#....#..
..#...........#..#........#.##.
.#.#......#.............##...#.
.#......#.....##.#..#..#.......
....##......#..................
.#.#..##............#....#....#
........#...##.............#..#
........#....##.....#......###.
.........#....#.#..............
#.....#........................
.#..#....#.....#......#.###..#.
..........#...#....##....#..#..
...#.#.#...##..#..#......#..#.#
#............#.....#....#......
#.###...#.#......###..#....#..#
...#.###........#......#....#..
..#.##...#.........#.#.........
............##.................
....#..........#.#.#.#.#....#..
...##.#...#.......#.......##..#
....##.#........#....#...#.....
.............#.#....#...#.....#
...#......................##...
..#...#.....#.....#........#..#
..#..#.......#....#..##.....#..
..#..#.#.......................
.......##..#....#....#..#......
....#......##....#............#
.#...#..#..#.##...#.#...#......
.....#......#....#.........#...
.##......##.........#....#.....
#...........#...##.....#......#
.....#.#.......#.........#.....
.........#..........#..####.##.
............#..#......#.#......
.#.............#........#.#....
......#......#...#..#....#####.
.........##.#..##...###..#....#
....#.#....#.#..#.........#....
..#.............#...##...##....
........#..........#.##..#....#
.....#...#..##........#.#..#...
##..#.#.....#............#.....
.............#........##...##..
#......####.....##.............
..##.....##....###..#.#....#...
......##.##.#...#..#.#..##.....
......#.................#......
#.....#.#...#......#.#....#....
....#.#........#..............#
##........#.......##.#...##...#
..#..................#.#....#..
...........#..........#.#.....#
........##.#.....#......#..#..#
.....#....#..#.....#.........##
#.#..#..#...#......#..........#
#...##.....#..#.#.......#.##...
..#....##...............#......
#..........#.#.........#.#....#
..............#......#....#....
.....#...........#...#...#...#.
...#......#....#....#..........
.#..........#.#....##..##....#.
..............#.........#.#....
.......#.....#.....#...##....#.
##.#.........#....#.....#.#....
....#..#......#................
......##.....#.......##........
.....##...#........#...#...#...
..#...#...#..#..#.#......#..#..
....#...#.......#..............
....#..#.........###........#..
....#.............##..#........
..........##.#.......##..##....
#.##..................#.....#..
#........#........#.....#......
.#...#......#..................
#....##.##......#...#.........#
......#.##..##................#
............#.........##.......
..........####.#........#.....#
.##...#...#....#..#............
.#.##...#..#...#......#......##
.....#.#....#..###......#.#.#..
...#.......................##..
......................#.......#
..#....#.........#..#.#.....#..
.#....#..#....#...#............
..........#...##.....#.#..#....
........#..#..#....#...#...#...
.....#......#.#................
.....#...........#...#.........
.....#...##..#.#....#..#.....#.
#.......#.............##.......
................#....#.#..#....
.#..##...#.#........#......#.#.
.#.##..........#...............
....##......#....#........#....
....#..#....#.##.#.............
.......#..#......##.#.....#....
.......#.....#.............#...
.....#....#.......#............
........#.#...##..##..##.......
#.........##....##...##........
........#..#.#..........###.#..
..........................#.#..
#.....#.......#..#........#....
...##.....#.......#......#.....
.#.#..#...........#...........#
.....##..#........#...####.....
.#.#...##.#.#..#..#.#..#.......
..#.##.#...#.#.#...#..#........
............#..........#..#....
...............#..##.#.........
.............#.....#....#......
...##..##......##..........#...
..#.......#....#..........#...#
.##................#.#.#.......
.....##.....#..#.....#.........
......#.#.......#......#..#....
.....#.....#........#.......##.
......#.......##......#...#...#
....#...........###.........#..
...#.....#.........##........#.
..#.....#..............#.......
....#.......#...#....#....#..##
......#...........#...........#
.##......#......#.#.....#.##...
....#..##......#...#..#.#.###..
.......#.#....#......#..#......
..........#........#...........
#.##.........#.#.#...#...#.#...
.#......###.....#....#.#....#..
...................##..#.......
....#..#..............#.#.....#
#..................#.....#.....
...........##.##.......#..#.#..
........#.#......#...........#.
#..#.......#...#...........#.#.
......##...........#...........
.........#.#........#........#.
#......#....#.#.....#..#.......
............#..#.....##...#....
.#......#..#......#.........#..
.......#...#.........#.##.....#
........................#..#...
.###..............#.#..#.......
.....#.........#.......#......#
..##..##....#.....#.......#.#..
...###.#..#.##............#....";
			string[] input_arr = input.Split('\n');
			int counter = 0;
			int tree_count = SlopeCheck(input_arr,3,1);
			
			
			/*
			for (int i=0; i < input_arr.Length; i++, counter = counter + 3)
        	{
        		
        		int index = counter % input_arr[i].Length;
        		if (char.Parse(input_arr[i].Substring(index,1)) == '#')
        		{
        			tree_count++;
        		}
        		
        	}
        	*/
        	Console.WriteLine("Day 3 part 1 answer is : "+tree_count);
        	
        	int p2_count1 = SlopeCheck(input_arr,1,1);
        	int p2_count2 = SlopeCheck(input_arr,3,1);
        	int p2_count3 = SlopeCheck(input_arr,5,1);
        	int p2_count4 = SlopeCheck(input_arr,7,1);
        	int p2_count5 = SlopeCheck(input_arr,1,2);
        	
        	Console.WriteLine("Day 3 part 2 answer is : "+p2_count1*p2_count2*p2_count3*p2_count4*p2_count5);
        }
        
        
        public static int SlopeCheck(string[] array, int counter_add, int row_add)
        {
        	
        	int counter = 0;
        	int tree_count = 0;
        	for (int i = 0; i < array.Length; i = i + row_add, counter = counter + counter_add)
        	{
        		
        		int index = counter % array[0].Length;
        		if (char.Parse(array[i].Substring(index,1)) == '#')
        		{
        			tree_count++;
        		}
        		
        		
        	}		
        	return tree_count;
        }
    }
}