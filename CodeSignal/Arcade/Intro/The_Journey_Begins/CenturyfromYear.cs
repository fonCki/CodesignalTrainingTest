namespace TrainingTest.Exercises.The_Journey_Begins; 

public class CenturyfromYear {
    
    int solution(int year) {
        int cent = (int) year / 100;
        if (year % 100 == 0) {
            return cent;
        } 
        return cent + 1;
    }

    
    
}