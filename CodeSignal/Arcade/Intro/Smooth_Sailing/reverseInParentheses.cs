using System.Text;

namespace TrainingTest.Arcade.Intro.Smooth_Sailing; 

public class reverseInParentheses {
    string solution(string inputString) {
        var stack = new Stack<char>();
        var sb = new StringBuilder();
        foreach (var c in inputString) {
            if (c == ')') {
                while (stack.Peek() != '(') {
                    sb.Append(stack.Pop());
                }
                stack.Pop();
            } else {
                stack.Push(c);
            }
        }
        while (stack.Count > 0) {
            sb.Append(stack.Pop());
        }
        return sb.ToString();

    }
    
}