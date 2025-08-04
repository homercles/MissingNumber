# MissingNumberApp

A C# console application that finds the **smallest missing non-negative integer** from a user-provided array. The solution is designed using SOLID principles, with extensibility and testability in mind.

---

## Requirements
```In C# create a console app that finds the Missing Number using SOLID principles
Description: Given an array containing numbers taken from the range 0 to n, find the one number that is missing from the array.

 Input:
An array of integers number where nums contains n distinct numbers from the range 0 to n.

Output:
Return the missing number.

Examples:
Input: [3, 0, 1]
Output: 2

Input: [9, 6, 4, 2, 3, 5, 7, 0, 1]
Output: 8 

```

---

## Features

- Accepts a comma-separated list of integers from the user.
- Finds the smallest missing non-negative integer in the array.
- Handles invalid input and edge cases (empty, null, duplicates, negatives).
- Includes comprehensive unit tests using xUnit.
- Follows SOLID principles with clear separation of concerns.

---

## Project Structure

```
+-- src
|   +-- MissingNumberApp
|   |   +-- Interfaces
|   |   |   +-- IMissingNumberFinder.cs
|   |   +-- MissingNumberApp.csproj
|   |   +-- Program.cs
|   |   +-- SumMissingNumberFinder.cs
|   +-- MissingNumberApp.Tests
|   |   +-- MissingNumberApp.Tests.csproj
|   |   +-- SumMissingNumberFinderTests.cs
+-- README.md


```


---

## How It Works

1. **User Input:**  
   The app prompts the user to enter numbers separated by commas (e.g., `3,0,1`).

2. **Validation:**  
   - Checks for empty input.
   - Parses and validates each number.
   - Handles invalid or non-integer input gracefully.

3. **Missing Number Logic:**  
   - Uses `SumMissingNumberFinder` (implementing `IMissingNumberFinder`) to find the smallest missing non-negative integer.
   - Internally, a `HashSet` is used for efficient lookups.

4. **Output:**  
   - Displays the missing number, or a message if no number is missing (i.e., the sequence is complete).

---

## Example

```
❯  dotnet run MissingNumberApp                                                            
Enter numbers separated by commas (e.g., 3,0,1):
3,0,1
Missing number: 2

```

## Unit Tests

All unit tests are contained withing the MissingNumberApp.Tests project and implemented using xUnit
