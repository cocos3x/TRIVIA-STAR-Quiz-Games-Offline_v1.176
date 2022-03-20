using UnityEngine;
private sealed class WGChapterClearPopup.<ExecuteAppearingAnimationSequence_VIP>d__49 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGChapterClearPopup <>4__this;
    private UnityEngine.CanvasGroup <cg>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGChapterClearPopup.<ExecuteAppearingAnimationSequence_VIP>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        UnityEngine.GameObject[] val_9;
        int val_10;
        UnityEngine.GameObject[] val_11;
        val_8 = 0;
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
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_4;
        }
        
        val_9 = 5;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_13;
        }
        
        mem[140] = 7;
        val_10 = mem[140];
        goto label_7;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this.animDone) == false)
        {
            goto label_9;
        }
        
        UnityEngine.GameObject val_1 = this.<cg>5__2.gameObject;
        string val_2 = this.<cg>5__2.name;
        val_10 = this.<cg>5__2;
        if((val_10.Contains(value:  -119379040)) != false)
        {
                val_8 = 1;
            this.<>4__this.vipImgAnim.enabled = true;
            this.<>1__state = 2;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_8;
        }
        
        label_13:
        val_10 = (this.<>4__this.order) + 1;
        this.<>4__this.order = val_10;
        label_7:
        val_11 = this.<>4__this.appearingOrder;
        if(val_10 == (this.<>4__this.order))
        {
                return (bool)val_8;
        }
        
        this.<>4__this.animDone = false;
        label_9:
        this.<cg>5__2 = 0;
        label_4:
        val_9 = this.<>4__this.appearingOrder;
        label_5:
        val_10 = this.<>4__this.order;
        val_11 = val_9[val_10];
        object val_5 = val_11.GetComponent<System.Object>();
        this.<cg>5__2 = val_11;
        System.Collections.IEnumerator val_6 = this.<>4__this.ExecuteAppearingAnimation(cg:  val_11);
        val_8 = 1;
        this.<>1__state = val_8;
        this.<>2__current = this.<>4__this;
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
