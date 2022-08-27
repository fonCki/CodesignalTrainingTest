using Xunit;

namespace TrainingTest.Exercises.Edge_Of_The_Ocean; 

public class MakeArrayConsecutive2 {
    int solution(int[] statues) {
        Array.Sort(statues);
        return (statues[statues.Length-1] - statues[0]) - (statues.Length-1);
        
    }
    
    [Fact]
    public void Test() {
        Assert.Equal(3, solution(new int[] { 6, 2, 3, 8}));
       

    }
    
}