using UnityEngine;
private sealed class WordHuntEvent.<>c__DisplayClass87_0
{
    // Fields
    public string wordFound;
    
    // Methods
    public WordHuntEvent.<>c__DisplayClass87_0()
    {
    
    }
    internal bool <EventWordContainedInWord>b__0(string x)
    {
        return System.String.op_Equality(a:  x, b:  this.wordFound);
    }

}
