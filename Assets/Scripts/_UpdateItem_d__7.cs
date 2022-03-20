using UnityEngine;
private sealed class EventListItem.<UpdateItem>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public EventListItem <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EventListItem.<UpdateItem>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.myHandler) != 0)
        {
                if((this.<>4__this.myHandler) == 0)
        {
            goto label_6;
        }
        
        }
        
        val_6 = 0;
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        UnityEngine.Object.Destroy(obj:  this.<>4__this);
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.SetTimerText(timeEnd:  new System.DateTime() {dateData = this.<>4__this.myHandler});
        System.Collections.IEnumerator val_4 = this.<>4__this.UpdateItem();
        val_6 = 1;
        this.<>1__state = 2;
        this.<>2__current = this.<>4__this;
        return (bool)val_6;
        label_6:
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_6;
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
