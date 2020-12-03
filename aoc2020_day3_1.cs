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
			int tree_count = 0;
			//Console.WriteLine(input_arr[0].Length);
			
			for (int i=0; i < input_arr.Length; i++, counter = counter + 3)
        	{
        		
        		int index = counter % input_arr[i].Length;
        		if (char.Parse(input_arr[i].Substring(index,1)) == '#')
        		{
        			tree_count++;
        		}
        		
        	}
        	
        	Console.WriteLine("Day 3 part 1 answer is : "+tree_count);
        	
        	
        }
    }
}