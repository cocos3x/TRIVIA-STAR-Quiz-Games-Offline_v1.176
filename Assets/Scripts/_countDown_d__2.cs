using UnityEngine;
private sealed class TRVCountdownOverlay.<countDown>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVCountdownOverlay <>4__this;
    public int time;
    private UnityEngine.CanvasGroup <cg>5__2;
    private float <floatedTime>5__3;
    private float <animDuration>5__4;
    private float <animProgress>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVCountdownOverlay.<countDown>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        float val_10;
        float val_11;
        val_9 = 0;
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
                return (bool)val_9;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this);
        this.<cg>5__2 = this.<>4__this;
        this.<>4__this.alpha = null;
        this.<floatedTime>5__3 = (float)this.time;
        goto label_6;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) > 2)
        {
            goto label_7;
        }
        
        val_9 = 0;
        UnityEngine.GameObject val_3 = this.<>4__this.gameObject;
        this.<>4__this.SetActive(value:  false);
        return (bool)val_9;
        label_2:
        this.<>1__state = 0;
        float val_10 = this.<floatedTime>5__3;
        label_6:
        val_11 = this.<floatedTime>5__3;
        if((this.<>1__state) > 1)
        {
            goto label_11;
        }
        
        val_10 = 0.3f;
        this.<animDuration>5__4 = 0.3f;
        this.<animProgress>5__5 = 0.3f;
        label_7:
        this.<cg>5__2.alpha = val_10 / (this.<animDuration>5__4);
        float val_5 = UnityEngine.Time.deltaTime;
        uint val_9 = 0;
        this.<>1__state = 2;
        val_9 = (this.<animProgress>5__5) - val_9;
        this.<>2__current = 0;
        val_9 = 1;
        this.<animProgress>5__5 = val_9;
        return (bool)val_9;
        label_11:
        float val_6 = UnityEngine.Time.deltaTime;
        val_10 = val_10 - 0;
        mem2[0] = val_10;
        if((this.<>4__this) > 0)
        {
                string val_8 = UnityEngine.Mathf.CeilToInt(f:  0.15f).ToString();
            if((this.<>4__this.timeRemainingText) != 0)
        {
            goto label_19;
        }
        
        }
        
        label_19:
        val_11 = 0;
        float val_11 = (float)this.time;
        val_11 = (this.<floatedTime>5__3) / val_11;
        this.<>4__this.timeRemainingBar.fillAmount = val_11;
        val_9 = 1;
        this.<>1__state = val_9;
        this.<>2__current = val_11;
        return (bool)val_9;
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
