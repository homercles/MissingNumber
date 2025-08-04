using MissingNumberApp.interfaces;

public class SumMissingNumberFinder : IMissingNumberFinder
{
    
    ///<summary>
    /// Finds the missing number in an array containing numbers from 0 to n with one missing.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The missing number in the sequence. or 0 if there isn't one</returns>
    /// <exception cref="ArgumentNullException">Thrown when nums is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when no missing number is found.</exception>
    public int FindMissingNumber(int[] nums)
    {
        if (nums == null)
            throw new ArgumentNullException(nameof(nums));

        var set = new HashSet<int>(nums);
        for (int i = 0; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
                return i;
        }
        throw new InvalidOperationException("No  number found.");
    }
}
