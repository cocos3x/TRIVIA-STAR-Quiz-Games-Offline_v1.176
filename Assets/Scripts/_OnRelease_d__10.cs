using UnityEngine;
private sealed class WordBow.<OnRelease>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.TwistyArrow.WordBow <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordBow.<OnRelease>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        object val_5;
        UnityEngine.UI.Image val_6;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = val_5;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                val_5 = this.<>4__this;
            val_6 = this.<>4__this.bowImage;
        }
        else
        {
                val_5 = 12;
            val_6 = 0;
        }
        
        val_4 = 0;
        val_6.sprite = this.<>4__this.releasedSprite;
        System.Collections.IEnumerator val_2 = this.<>4__this.ReDraw();
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        return (bool)val_4;
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
