using UnityEngine;
private sealed class WADPetsFeedFoodPopup.<OnFed>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WADPetsFeedFoodPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WADPetsFeedFoodPopup.<OnFed>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_3 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.UpdateCardsCollection();
        goto label_4;
        label_1:
        this.<>1__state = 0;
        val_3 = 0;
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return (bool)val_3;
        label_3:
        0.UpdateCardsCollection();
        label_4:
        this.<>4__this.particles.Play();
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
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
