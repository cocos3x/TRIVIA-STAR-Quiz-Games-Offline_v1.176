using UnityEngine;
private sealed class ExtraWordsAnimationControl.<Fadeout>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ExtraWordsAnimationControl <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ExtraWordsAnimationControl.<Fadeout>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        ExtraWordsAnimationControl val_19;
        val_18 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_18;
        }
        
        val_19 = this.<>4__this;
        this.<>1__state = 0;
        UnityEngine.Color val_1 = color;
        if((this.<>4__this.skAnima) <= 0)
        {
                UnityEngine.Transform val_3 = val_19.transform;
            UnityEngine.Transform val_4 = val_19.parent;
            val_18 = 0;
            UnityEngine.GameObject val_5 = val_19.gameObject;
            val_19.SetActive(value:  false);
            return (bool)val_18;
        }
        
        UnityEngine.Color val_6 = color;
        UnityEngine.Color val_8 = color;
        UnityEngine.Color val_10 = color;
        UnityEngine.Color val_12 = color;
        UnityEngine.Color val_15 = new UnityEngine.Color(r:  UnityEngine.Mathf.Lerp(a:  val_12.r, b:  val_12.g, t:  val_12.b), g:  val_12.g, b:  val_12.b, a:  val_12.a);
        this.<>4__this.skAnima.color = new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.r};
        UnityEngine.WaitForSeconds val_17 = null;
        val_19 = val_17;
        val_17 = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Time.deltaTime);
        val_18 = 1;
        this.<>1__state = val_18;
        this.<>2__current = val_19;
        return (bool)val_18;
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
