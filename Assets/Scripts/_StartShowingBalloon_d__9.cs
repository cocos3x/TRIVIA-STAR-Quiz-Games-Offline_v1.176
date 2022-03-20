using UnityEngine;
private sealed class PrizeBalloonUIController.<StartShowingBalloon>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PrizeBalloonUIController <>4__this;
    private float <step>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PrizeBalloonUIController.<StartShowingBalloon>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        var val_19;
        object val_20;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_18 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_18;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_1 = this.<>4__this.balloon.transform;
        val_19 = 0;
        UnityEngine.Vector3 val_2 = position;
        this.<>4__this.balloon.position = new UnityEngine.Vector3();
        val_20 = 0;
        UnityEngine.GameObject val_3 = this.<>4__this.balloon.gameObject;
        val_18 = 1;
        this.<>4__this.balloon.SetActive(value:  true);
        this.<>1__state = val_18;
        this.<>2__current = val_20;
        return (bool)val_18;
        label_1:
        this.<>1__state = 0;
        goto label_11;
        label_2:
        this.<>1__state = 0;
        float val_4 = UnityEngine.Time.fixedDeltaTime;
        GameEcon val_5 = App.getGameEcon;
        this.<t>5__3 = 0f;
        float val_18 = -1.539109E+09f;
        val_18 = 0 / val_18;
        this.<step>5__2 = val_18;
        label_11:
        UnityEngine.Transform val_6 = this.<>4__this.balloon.transform;
        UnityEngine.Vector3 val_7 = position;
        UnityEngine.Vector3 val_9 = position;
        if((this.<>4__this.end) >= 0)
        {
                UnityEngine.Transform val_11 = this.<>4__this.balloon.transform;
            val_20 = this.<>4__this.end;
            val_18 = 0;
            UnityEngine.Vector3 val_12 = position;
            this.<>4__this.balloon.position = new UnityEngine.Vector3();
            this.<>4__this.HideBalloon();
            return (bool)val_18;
        }
        
        float val_19 = this.<step>5__2;
        val_19 = (this.<t>5__3) + val_19;
        this.<t>5__3 = val_19;
        UnityEngine.Transform val_13 = this.<>4__this.balloon.transform;
        UnityEngine.Vector3 val_14 = position;
        val_19 = 0;
        UnityEngine.Vector3 val_15 = position;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = -0.9321268f}, b:  new UnityEngine.Vector3(), t:  val_15.x);
        this.<>4__this.balloon.position = new UnityEngine.Vector3();
        val_18 = 1;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
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
