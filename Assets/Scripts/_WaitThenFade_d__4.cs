using UnityEngine;
private sealed class DefinitionDisplay.<WaitThenFade>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DefinitionDisplay <>4__this;
    private float <progress>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DefinitionDisplay.<WaitThenFade>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        float val_7;
        UnityEngine.CanvasGroup val_8;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_6;
        }
        
        if((this.<>4__this) <= 0)
        {
            goto label_10;
        }
        
        val_7 = this.<progress>5__2;
        val_8 = this.<>4__this.group;
        goto label_11;
        label_2:
        this.<>1__state = 0;
        this.<progress>5__2 = this.<>4__this.fadeTime;
        if((this.<>4__this) <= 0)
        {
            goto label_10;
        }
        
        val_8 = this.<>4__this.group;
        val_7 = this.<progress>5__2;
        if((this.<>4__this) != 0)
        {
            goto label_11;
        }
        
        goto label_12;
        label_6:
        if((this.<>4__this) > 0)
        {
            goto label_13;
        }
        
        label_10:
        val_6 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        this.<>4__this.SetActive(value:  false);
        return (bool)val_6;
        label_13:
        val_7 = this.<progress>5__2;
        val_8 = this.<>4__this.group;
        label_12:
        label_11:
        val_8.alpha = val_7 / (this.<>4__this.fadeTime);
        float val_4 = UnityEngine.Time.fixedDeltaTime;
        uint val_6 = 0;
        val_6 = (this.<progress>5__2) - val_6;
        this.<progress>5__2 = val_6;
        val_6 = 1;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
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
