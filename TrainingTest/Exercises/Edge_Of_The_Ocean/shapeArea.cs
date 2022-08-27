using Xunit;

namespace TrainingTest.Exercises.Edge_Of_The_Ocean; 

public class shapeArea {
    int solution(int n) {
        if (n == 1) {
            return 1;
        }
        return solution(n - 1) + (n - 1) * 4;
    }
    
    [Fact]
    public void Test() {
        Assert.Equal(5, solution(2));
        Assert.Equal(13, solution(3));

    }
    
}