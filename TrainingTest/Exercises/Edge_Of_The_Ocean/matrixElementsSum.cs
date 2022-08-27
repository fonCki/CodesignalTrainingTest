using Xunit;

namespace TrainingTest.Exercises; 

public class FreeRomCodeBots {
    int Solution(int[][] matrix) {
        int total = 0;
        for (int j = 0; j < matrix[0].Length; j++) {
            for (int i = 0; i < matrix.Length; i++) {
                if (matrix[i][j] == 0) {
                    break;
                }
                total+=matrix[i][j];
            }
        }

        return total;
    }
    
    [Fact]
    public void Test() {
        Assert.Equal(9, Solution(new int[][] { new int[] { 0, 1, 1, 2 }, new int[] { 0, 5, 0, 0 }, new int[] { 2, 0, 3, 3 } }));
        Assert.Equal(9, Solution(new int[][] { new int[] { 1, 1, 1, 0 }, new int[] { 0, 5, 0, 1 }, new int[] { 2, 1, 3, 10 } }));

    }

}