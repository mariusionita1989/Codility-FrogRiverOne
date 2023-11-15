using Codility_FrogRiverOne;

namespace Codility_FrogRiverOneTests
{
    public class SolutionTests
    {
        [Fact]
        public void FrogCanJump_EarliestTime_ReturnsExpectedResult()
        {
            // Arrange
            Solution solution = new Solution();
            int X = 5;
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };

            // Act
            int result = solution.solution(X, A);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void FrogNeverJumps_ReturnsMinusOne()
        {
            // Arrange
            Solution solution = new Solution();
            int X = 5;
            int[] A = { 1, 2, 3, 4, 5 };

            // Act
            int result = solution.solution(X, A);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void FrogNeverJumpsOutOfRange_ReturnsMinusTwo()
        {
            // Arrange
            Solution solution = new Solution();
            int X = 5;
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Act
            int result = solution.solution(X, A);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void FrogCanJumpWithMinimumInput_ReturnsEarliestTime()
        {
            // Arrange
            Solution solution = new Solution();
            int X = 1;
            int[] A = { 1 };

            // Act
            int result = solution.solution(X, A);

            // Assert
            Assert.Equal(0, result);
        }
    }
}