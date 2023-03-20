// #1 
/*
string myString = "noon";
Reverse(myString);
static void Reverse( string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    if (s.Equals(new string(charArray)))
    {
        Console.WriteLine("Is a Palindrome");
    }
    else
    {
        Console.WriteLine("Is NOT a Palindrome");
    }
}
*/
// #2 
/*
var money = 537;
counter(money);
static void counter(int money)
{
    int count = 0;
    count +=  money /50;    count +=  money %50 /20;   count +=  money %50 %20 /10;   count +=  money %50 %20 %10 /5;    count +=  money %5;
    Console.WriteLine(count);
}
*/
//#3
/*
int[] numArray = {-3,-1,-2,1,2,3,4,5,7};
NotContains(numArray);
int NotContains(int[] arr)
{
    var min = 0;
    Array.Sort(arr);
    if (arr.Max() <1) 
    {
        Console.WriteLine(1);
        return 1;
    }
    for (int i = 0; i < arr.Length; i++)
    {  
        // Console.WriteLine(arr[i]);
        if (arr[i] < 0)
        {
            continue;
        }
        if (i != arr.Length - 1 && arr[i] +1 == arr[i+1])
        {
            continue;
        }
        else if (i == arr.Length - 1)
        {
            min = arr[i] + 1;
            Console.WriteLine(min);
        }
        else
        {  
            min = arr[i] + 1;
            Console.WriteLine(min);
            break;
        }
    }
    return 5;
}
*/
//#4
/*
string sequence = "()()(())((()))((())())";
static void IsCorrect(string s)
{
    int size = s.Length;
    var count = 0;
    bool isProperly = true;
    if (size %2 ==1)
    {
        isProperly = false;
    }
    for (int i = 0; i < size; i++)
    {   
        if (s[i].ToString().Equals("("))
        {
            count++;
            continue;
        }
        else
        {
            count--;
            if (count < 0)
            {
                isProperly = false;
                break;
            }
            continue;
        }
    }
    if (count != 0)
    {
        isProperly = false;
    }
    Console.WriteLine(isProperly);
}
IsCorrect(sequence);
*/
//#5
/*
int stairCount = 6;
int oneStep = 1;
int twoStep = 1;
int count = 0;
for (int i = 0; i < stairCount -1; i++)
{
    count = oneStep;
    oneStep += twoStep;
    twoStep = count;
    if (i == stairCount -2){
    Console.WriteLine(oneStep);
    }
}   
*/

