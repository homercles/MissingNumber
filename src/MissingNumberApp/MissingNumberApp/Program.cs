using MissingNumberApp.interfaces;
using System;
using System.Linq;

// Handles user interaction and program entry
public class Program
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter numbers separated by commas
        Console.WriteLine("Enter numbers separated by commas (e.g., 3,0,1):");
        string input = Console.ReadLine();

        // Check if the input is empty or whitespace
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        int[] nums;
        try
        {
            // Split the input string by commas, trim spaces, and parse to integers
            nums = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => int.Parse(s.Trim()))
                        .ToArray();
        }
        catch (FormatException)
        {
            // Handle invalid integer input
            Console.WriteLine("All inputs must be valid integers.");
            return;
        }

        // Create an instance of the missing number finder
        IMissingNumberFinder finder = new SumMissingNumberFinder();

        // Find the missing number in the input array
        int missing = finder.FindMissingNumber(nums);

        // If missing is 0, inform the user that there is no missing number
        if (missing == 0)
        {
            Console.WriteLine("There is no Missing Number!!!");
            return;
        }

        // Output the missing number
        Console.WriteLine($"Missing number: {missing}");
    }
}
