using Xunit;

namespace TrainingTest.Arcade.Intro.Smooth_Sailing; 

public class IsLucky {
    
    bool solution(int n) {
        string numberAsString = n.ToString();
        
        string firstHalf = numberAsString.Substring(0, numberAsString.Length / 2);
        string secondHalf = numberAsString.Substring(numberAsString.Length / 2);
        int firstHalfSum = 0;
        int secondHalfSum = 0;

        for (int i = 0; i < firstHalf.Length; i++) {
            firstHalfSum += int.Parse(firstHalf[i].ToString());
            secondHalfSum += int.Parse(secondHalf[i].ToString());
        }
        return firstHalfSum == secondHalfSum;
    }
    
    
    [Fact]
    public void Test() {
        Assert.Equal(true, solution(9366));
    }
    
}