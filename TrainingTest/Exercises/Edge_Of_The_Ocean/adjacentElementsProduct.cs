using Xunit;

namespace TrainingTest.Exercises.Edge_Of_The_Ocean; 

public class adjacentElementsProduct {
    
    int solution(int[] inputArray) {
        int biggest = inputArray[0] * inputArray[1];
        for (int i = 0; i < inputArray.Length -1; i++) {
            if (inputArray[i] * inputArray[i + 1] > biggest) {
                biggest = inputArray[i] * inputArray[i + 1];
            }
        }

        return biggest;
    }

    [Fact]
    public void Test() {
        Assert.Equal(21, solution(new int[] { 3, 6, -2, -5, 7, 3 }));

    }
    
}