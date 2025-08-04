using MissingNumberApp.interfaces;
using Xunit;

namespace MissingNumberApp.Tests
{
    public class SumMissingNumberFinderTests
    {
        /// <summary>
        /// Tests that FindMissingNumber returns the expected result for various input arrays.
        /// </summary>
        /// <param name="nums">The input array of numbers.</param>
        /// <param name="expected">The expected missing number.</param>
        [Theory]
        [InlineData(new int[] { 3, 0, 1 }, 2)]
        [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 0, 1, 2, 4, 5 }, 3)]
        [InlineData(new int[] { 1, 1, 3, 4 }, 0)]
        [InlineData(new int[] { 7, 1, 3, 4, 5, 2, 1, 8, 11, 0 }, 6)]
        [InlineData(new int[] { 8, 1, 0, 4, 5, 2, 1, 8, 11, 0 }, 3)]
        [InlineData(new int[] { 1, 1, 1, 2, 4, 4, 0 }, 3)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 1)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 0)]
        [InlineData(new int[] { -3, -2, -1, 0, 1, 2 }, 3)]

        public void FindMissingNumber_ReturnsExpectedResult(int[] nums, int expected)
        {
            var finder = new SumMissingNumberFinder();
            int result = finder.FindMissingNumber(nums);

            Assert.Equal(expected, result);

        }

        /// <summary>
        /// Tests that FindMissingNumber returns zero when the input array is empty.
        /// </summary>
        [Fact]
        public void FindMissingNumber_EmptyArray_ReturnsZero()
        {
            // Arrange
            var finder = new SumMissingNumberFinder();
            int[] nums = new int[0];
            // Act
            int result = finder.FindMissingNumber(nums);
            // Assert
            Assert.Equal(0, result);
        }

        /// <summary>
        /// Tests that FindMissingNumber throws an ArgumentNullException when the input is null.
        /// </summary>
        [Fact]
        public void FindMissingNumber_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            var finder = new SumMissingNumberFinder();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => finder.FindMissingNumber(null));
        }

    }
}