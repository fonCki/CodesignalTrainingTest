using Xunit;

namespace TrainingTest.Arcade.Intro.Smooth_Sailing; 

public class commonCharacterCount {
    
    public int solution(String s1, String s2) {
        int count = 0;
        String s1Lower = s1.ToLower();
        String s2Lower = s2.ToLower();
        for (int i = 0; i < s1Lower.Length; i++) {
            for (int j = 0; j < s2Lower.Length; j++) {
                if (s1Lower[i] == s2Lower[j] ) {
                    count++;
                    s2Lower = s2Lower.Substring(0,j) + s2Lower.Substring(j + 1);
                    break;
                }
            }
        }
        return count;
    }

    [Fact]
    public void Test1() {
        Assert.Equal(3, solution("aabcc", "adcaa"));
    }
    
}