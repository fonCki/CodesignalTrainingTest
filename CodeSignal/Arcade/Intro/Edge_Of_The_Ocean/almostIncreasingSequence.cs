using Xunit;

namespace TrainingTest.Exercises.Edge_Of_The_Ocean; 

public class matrixElementsSum {
    bool solution(int[] sequence) {
        int count = 0;
        for (int i = 0; i < sequence.Length - 1; i++) {
            if (sequence[i] >= sequence[i + 1]) {
                count++;
                if (i > 0 && i < sequence.Length - 2 && sequence[i - 1] >= sequence[i + 1] && sequence[i] >= sequence[i + 2]) {
                    return false;
                }
            }
        }
        return count <= 1;
    }
    
    [Fact]
    public void Test() {
        Assert.False(solution(new int[] { 1, 3, 2, 1}));
        Assert.True(solution(new int[] { 1, 3, 2}));
       

    }
    
}