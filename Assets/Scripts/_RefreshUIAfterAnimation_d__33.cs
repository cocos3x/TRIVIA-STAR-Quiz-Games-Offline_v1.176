using UnityEngine;
private sealed class ImageQuizDisplayWord.<RefreshUIAfterAnimation>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.ImageQuiz.ImageQuizDisplayWord <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImageQuizDisplayWord.<RefreshUIAfterAnimation>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        int val_3;
        var val_4;
        val_2 = this;
        val_3 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_2;
        }
        
        this.<>4__this.<AllowErase>k__BackingField = false;
        goto label_3;
        label_0:
        val_4 = 0;
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_5;
        }
        
        val_4 = 1;
        goto label_5;
        label_2:
        mem[69] = 0;
        label_3:
        this.<>4__this.<AllowInput>k__BackingField = false;
        val_4 = 0;
        label_5:
        if((this.<>4__this.IsTilesAnimating()) != false)
        {
                val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = 0;
            return (bool)val_3;
        }
        
        if(val_4 != 0)
        {
                val_2 = 1;
            mem[69] = val_2;
            mem[68] = val_2;
        }
        else
        {
                this.<>4__this.<AllowInput>k__BackingField = true;
            this.<>4__this.<AllowErase>k__BackingField = true;
        }
        
        this.<>4__this.RefreshUI();
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
