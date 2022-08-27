using Xunit;

namespace TrainingTest.Arcade.Intro.Smooth_Sailing; 

public class AllLongestStrings {
    
    string[] solution(string[] inputArray) {
        List<string> result = new List<string>();
        int longest = 0;
        foreach (var str in inputArray) {
            if (str.Length == longest) {
                result.Add(str);
            }
            else {
                if (str.Length > longest) {
                    result.Clear();
                    result.Add(str);
                    longest = str.Length;
                }
            }
        }
        return result.ToArray();
    }

    [Fact]
    public void Test() {
        Assert.Equal(new string[] {"aba", "vcd", "aba"}, solution(new string[] { "aba", "aa", "ad", "vcd", "aba"}));
       

    }

}