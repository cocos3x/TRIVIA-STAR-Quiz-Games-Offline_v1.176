using UnityEngine;
private sealed class WordBow.<ReDraw>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.TwistyArrow.WordBow <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordBow.<ReDraw>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SLC.Minigames.TwistyArrow.WordBow val_2;
        int val_3;
        var val_4;
        UnityEngine.UI.Image val_5;
        val_2 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = val_2;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if(val_2 != 0)
        {
                val_4 = val_2;
            val_5 = this.<>4__this.bowImage;
        }
        else
        {
                val_4 = 12;
            val_5 = 0;
        }
        
        val_5.sprite = this.<>4__this.drawnSprite;
        val_3 = 0;
        this.<>4__this.staticArrow.SetActive(value:  true);
        return (bool)val_3;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
