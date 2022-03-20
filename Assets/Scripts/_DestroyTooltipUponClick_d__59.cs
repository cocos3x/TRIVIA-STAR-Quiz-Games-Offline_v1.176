using UnityEngine;
private sealed class PuzzleCollectionUIController.<DestroyTooltipUponClick>d__59 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PuzzleCollectionUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PuzzleCollectionUIController.<DestroyTooltipUponClick>d__59(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        var val_4;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            if(UnityEngine.Input.touchCount <= 0)
        {
                if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
            goto label_4;
        }
        
        }
        
            if((this.<>4__this) != 0)
        {
                this.<>4__this.DestroyTooltip();
            val_4 = this.<>4__this;
            this.<>4__this.StopCoroutine(routine:  this.<>4__this.destroyTooltipUponClick);
        }
        else
        {
                0.DestroyTooltip();
            val_4 = 80;
            0.StopCoroutine(routine:  4);
        }
        
            mem[80] = 0;
        }
        
        label_4:
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = 0;
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
