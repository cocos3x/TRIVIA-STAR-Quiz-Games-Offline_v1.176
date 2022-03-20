using UnityEngine;
private sealed class WGDailyChallengeWordRegion.<CalculateCellSizeNextFrame>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGDailyChallengeWordRegion <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGDailyChallengeWordRegion.<CalculateCellSizeNextFrame>d__39(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_8;
        object val_9;
        float val_10;
        var val_11;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_9 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_8 = 1;
            this.<>1__state = val_8;
            this.<>2__current = val_9;
            return (bool)val_8;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                float val_2 = this.<>4__this.CalculateCellSizeForLines();
            val_10 = this.<>4__this;
        }
        else
        {
                float val_3 = 0.CalculateCellSizeForLines();
            val_10 = 0;
        }
        
        List.Enumerator<T> val_4 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        if(val_6 != 0)
        {
                mem2[0] = val_10;
        }
        else
        {
                mem[16] = val_10;
        }
        
        val_6.SetLineWidth();
        val_6.ReBuild();
        val_6.MakeVisible(visible:  true);
        goto label_12;
        label_7:
        Dispose();
        val_11 = 0;
        UnityEngine.Transform val_7 = this.<>4__this.transform;
        if((this.<>4__this) != 0)
        {
                if(null != null)
        {
                this.<>4__this = 0;
        }
        
            val_11 = this.<>4__this;
        }
        
        val_8 = 0;
        UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  0);
        return (bool)val_8;
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
