using UnityEngine;
private sealed class Alphabet2Manager.<>c__DisplayClass142_0
{
    // Fields
    public string word;
    public int letterIndex;
    
    // Methods
    public Alphabet2Manager.<>c__DisplayClass142_0()
    {
    
    }
    internal bool <HasCollectedWordAtIndex>b__0(string x)
    {
        if((x.StartsWith(value:  this.word)) == false)
        {
                return false;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Skip<System.Char>(source:  x, count:  this.word.m_stringLength);
        TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Char>(source:  x);
        string val_4 = x + (this.letterIndex << 1);
        val_4 = val_4 + 16;
        return val_4.Equals(obj:  '1');
    }

}
