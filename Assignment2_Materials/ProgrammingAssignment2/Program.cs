﻿using System;
using LinkedLists;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
		// holds the list of input numbers
		static UnsortedLinkedList<int> values = new UnsortedLinkedList<int>();

		/// <summary>
		/// Programming Assignment 2
		/// </summary>
		/// <param name="args">command-line args</param>
		static void Main(string[] args)
		{
		
			Console.WriteLine("pick your numbers");
			// loop while there's more input

            string input = Console.ReadLine();
			while (input[0] != 'q')
			{


				// extract input values from string
				BuildLinkedListFromString(input);

				// Add your code between this comment
				int currInt;
				currInt = GetValue();
				int count;
				count = 0;
				int sum;
				sum = 0;

				while (currInt != -1)
				{
					count++;
					sum = sum + count;
                    currInt = GetValue();
                }

				if (currInt == -1)
				{
					Console.WriteLine(count + " " + sum);
				}

				// and the comment below. You can of
				// course add more space between the
				// comments as needed



				// Don't add or modify any code below
				// this comment
				input = Console.ReadLine();
			}
		}
		
		/// <summary>
		/// Builds a linked list of input values from provided string
		/// </summary>
		/// <param name="input">input string</param>
		/// <returns>linked list of values</returns>
		static void BuildLinkedListFromString(string input)
		{
			// find first space in string
			int spaceIndex = input.IndexOf(' ');

			// loop while there are more spaces in string
			while (spaceIndex != -1)
			{
				// add value to list
				int value = int.Parse(input.Substring(0, spaceIndex));
				values.Add(value);

				// move along string and find next space in string
				input = input.Substring(spaceIndex + 1);
				spaceIndex = input.IndexOf(' ');
			}

			// add final node to list
			int finalValue = int.Parse(input);
			values.Add(finalValue);
		}

		/// <summary>
		/// Get a value from the linked list. If the linked
		/// list is empty, returns -1
		/// </summary>
		/// <returns>value or -1 if list is empty</returns>
		static int GetValue()
		{
			// check for empty list
			int GetValue;
			if (values.Count > 0)
			{
				// save value at front of list
				GetValue = values.Head.Value;

				// move along list
				values.Remove(GetValue);
			}
			else
			{
				// empty list
				GetValue = -1;
			}
			return GetValue;
		}
	}
}
