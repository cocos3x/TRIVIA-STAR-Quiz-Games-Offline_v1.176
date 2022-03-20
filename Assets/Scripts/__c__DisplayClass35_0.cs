using UnityEngine;
private sealed class WFOManagerGameplay.<>c__DisplayClass35_0
{
    // Fields
    public string word;
    
    // Methods
    public WFOManagerGameplay.<>c__DisplayClass35_0()
    {
    
    }
    internal bool <OnValidWordSubmitted>b__0(LineWord lineword)
    {
        string val_1 = lineword.answer.ToLower();
        string val_2 = this.word.ToLower();
        return System.String.op_Equality(a:  lineword.answer, b:  this.word);
    }

}
