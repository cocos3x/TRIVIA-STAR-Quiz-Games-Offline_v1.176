using UnityEngine;
private sealed class WGChallengeFlyout.<CompleteFlyout>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGChallengeFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGChallengeFlyout.<CompleteFlyout>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        WGChallengeButton val_18;
        val_17 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_17;
        }
        
        var val_1 = 6726388 + (6726388 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                6726388 + (this.<>1__state) << 2 = (6726388 + (this.<>1__state) << 2) & ((6726388 + (this.<>1__state) << 2) << (6726388 + (this.<>1__state) << 2));
            6726388 + (this.<>1__state) << 2 = (6726388 + (this.<>1__state) << 2) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            6726388 + (this.<>1__state) << 2 = (6726388 + (this.<>1__state) << 2) & ((R8) << 6726388);
        }
        
        this.<>1__state = 0;
        object val_2 = UnityEngine.Object.FindObjectOfType<System.Object>();
        val_18 = public static WGChallengeButton UnityEngine.Object::FindObjectOfType<WGChallengeButton>();
        if((this.<>4__this) == 0)
        {
            goto label_4;
        }
        
        this.<>4__this.uiButton = val_18;
        goto label_5;
        label_28:
        this.<>2__current = ;
        return (bool)val_17;
        label_4:
        mem[40] = val_18;
        val_18 = mem[40];
        label_5:
        if((-1596404896) == 0)
        {
                val_17 = 0;
            UnityEngine.Debug.LogError(message:  -1596399776);
            this.<>4__this.OnDisplayComplete();
            return (bool)val_17;
        }
        
        UnityEngine.GameObject val_12 = this.<>4__this.gameObject;
        object val_13 = this.<>4__this.GetComponentInParent<System.Object>();
        if((this.<>4__this) != 0)
        {
                UnityEngine.Camera val_15 = this.<>4__this.worldCamera;
            this.<>4__this.canvasCamera = this.<>4__this;
        }
        
        null = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = 1;
        goto label_28;
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
