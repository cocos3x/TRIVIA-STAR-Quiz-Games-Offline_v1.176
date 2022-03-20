using UnityEngine;
private sealed class WordHuntEvent.<>c__DisplayClass92_0
{
    // Fields
    public LineWord wordLine;
    
    // Methods
    public WordHuntEvent.<>c__DisplayClass92_0()
    {
    
    }
    internal bool <GetEventWordsAvailableInLevel>b__0(string x)
    {
        if(this.wordLine != 0)
        {
                return System.String.op_Equality(a:  x, b:  this.wordLine.answer);
        }
        
        return System.String.op_Equality(a:  x, b:  this.wordLine.answer);
    }

}
