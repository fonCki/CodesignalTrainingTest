using Xunit;

namespace TrainingTest.Exercises.The_Journey_Begins; 

public class ChechPalindrome {
    bool solution(string inputString) {
        int length = inputString.Length;
        for (int i = 0; i < length / 2; i++) {
            if (inputString[i] != inputString[length - i - 1]) {
                return false;
            }
        }
        return true;
    }

    [Fact]
    public void Test1() {
        Assert.True(solution("a"));
        Assert.True(solution("aba"));
        Assert.False(solution("allam"));
        Assert.True(solution("abbba"));
    }
    
}