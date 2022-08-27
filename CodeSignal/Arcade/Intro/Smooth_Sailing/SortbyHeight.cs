using Xunit;

namespace TrainingTest.Arcade.Intro.Smooth_Sailing; 

public class SortbyHeight {
    
    int[] solution(int[] a) {
        int[] newArray = new int[a.Length];
        var sortedArray = a.OrderBy(x=> x).Where(x => x != -1).ToList();

        for (int i = 0; i < a.Length; i++) {
            if (a[i] != -1) {
                newArray[i] = sortedArray.First();
                sortedArray.RemoveAt(0);
            } else {
                newArray[i] = -1;
            }
            
        }
        return newArray;
}
    
    
    [Fact]
    public void Test() {
        Assert.Equal(new int[] {-1,150,160,170,-1,-1,180,190}, solution(new int[] {-1,150,190,170,-1,-1,160,180}));
    }
}