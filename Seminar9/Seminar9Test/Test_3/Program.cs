// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. 
//Определите, является ли ваша строка допустимой.

//Method
bool CheckBrackets(string str)
{
    Console.WriteLine(str);

    Stack<char> brackets = new Stack<char>();

    foreach (char sym in str)
    {
        switch (sym)
        {
            case '(' or '{' or '[':
                brackets.Push(sym);
                break;
            case ']':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '[') return false;
                break;
            case ')':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '(') return false;
                break;
            case '}':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '{') return false;         
                break;
            default:
                break;
        }
    }
    if (brackets.Count > 0) return false;
    return true;
}

string testStr = "()";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "(){}[]";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "(]";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "()[]{()}";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();