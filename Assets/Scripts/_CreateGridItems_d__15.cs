using UnityEngine;
private sealed class UIListViewController.<CreateGridItems>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIListViewController <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIListViewController.<CreateGridItems>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_8;
        int val_9;
        System.Collections.Generic.List<UnityEngine.GameObject> val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        this.<>4__this.ToggleLoadingPopup(state:  true);
        val_9 = 0;
        this.<i>5__2 = val_9;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        goto label_5;
        label_14:
        if((this.<i>5__2) >= 0)
        {
            goto label_12;
        }
        
        val_10 = this.<>4__this.memberGridItems;
        if(0 <= (this.<i>5__2))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_1 = R1 + ((this.<i>5__2) << 2);
        if(((R1 + (this.<i>5__2) << 2) + 16) == 0)
        {
            goto label_12;
        }
        
        label_5:
        val_9 = (this.<i>5__2) + 1;
        mem2[0] = val_9;
        label_4:
        if(val_9 < (this.<>4__this.curr_total))
        {
            goto label_14;
        }
        
        if((this.<>4__this.OnFinishedUIUpdate) != 0)
        {
                this.<>4__this.OnFinishedUIUpdate.Invoke(obj:  true);
        }
        
        val_8 = 0;
        this.<>4__this.ToggleLoadingPopup(state:  false);
        this.<>4__this.creating = val_8;
        return (bool)val_8;
        label_12:
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this);
        UnityEngine.Transform val_4 = this.<>4__this.transform;
        this.<>4__this.SetParent(parent:  this.<>4__this.gridRootTransform, worldPositionStays:  false);
        UnityEngine.GameObject val_5 = this.<>4__this.gridRootTransform.gameObject;
        val_10 = 0;
        this.<>4__this.layer = this.<>4__this.gridRootTransform.layer;
        this.<>4__this.memberGridItems.Add(item:  this.<>4__this);
        val_8 = 1;
        this.<>1__state = val_8;
        this.<>2__current = val_10;
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
