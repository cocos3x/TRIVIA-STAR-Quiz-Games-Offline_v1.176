using UnityEngine;
private sealed class WFOEventPointGainAnimationV2.<AutoGenerateSymbols>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int count;
    public WFOEventPointGainAnimationV2 <>4__this;
    private float <scale>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOEventPointGainAnimationV2.<AutoGenerateSymbols>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        float val_6;
        int val_21;
        int val_22;
        int val_23;
        UnityEngine.Transform val_24;
        UnityEngine.Transform val_25;
        UnityEngine.Transform val_26;
        object val_27;
        if((this.<>1__state) != 1)
        {
                val_21 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_21;
        }
        
            this.<>1__state = 0;
            if(this.count < 1)
        {
                return (bool)val_21;
        }
        
            object val_1 = this.<>4__this.progress.icon.GetComponent<System.Object>();
            UnityEngine.Vector2 val_2 = sizeDelta;
            object val_4 = this.<>4__this.prefabPointImage.GetComponent<System.Object>();
            val_22 = 0;
            UnityEngine.Vector2 val_5 = sizeDelta;
            float val_20 = val_6;
            val_20 = val_3 / val_20;
            this.<scale>5__2 = val_20;
            this.count = UnityEngine.Mathf.Min(a:  10, b:  this.count);
        }
        else
        {
                val_23 = this.count;
            val_22 = (this.<i>5__3) + 1;
            this.<>1__state = 0;
        }
        
        val_23 = val_23 - 1;
        this.<i>5__3 = val_22;
        if(val_22 >= val_23)
        {
            goto label_13;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_14;
        }
        
        val_24 = this.<>4__this.symbolPrefab;
        goto label_15;
        label_13:
        if((this.<>4__this) == 0)
        {
            goto label_16;
        }
        
        val_25 = this.<>4__this.centralSymbolTransform;
        val_26 = this.<>4__this.target;
        goto label_17;
        label_14:
        val_24 = 83886592;
        label_15:
        object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  83886592, parent:  this.<>4__this.symbolParent);
        val_24.position = new UnityEngine.Vector3() {x = mem[this.<>4__this.originalCentralSymbolPos + (0)], y = mem[this.<>4__this.originalCentralSymbolPos + (4)], z = mem[this.<>4__this.originalCentralSymbolPos + (8)]};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.501063E+25f}, d:  this.<>4__this.symbolScale);
        val_24.localScale = new UnityEngine.Vector3();
        UnityEngine.GameObject val_11 = val_24.gameObject;
        val_21 = 1;
        val_24.SetActive(value:  true);
        DG.Tweening.Sequence val_12 = this.<>4__this.MoveSymbol(scale:  val_10.x, trans:  this.<scale>5__2, dest:  83886592, destroy:  this.<>4__this.target);
        UnityEngine.WaitForSeconds val_13 = null;
        val_27 = val_13;
        val_13 = new UnityEngine.WaitForSeconds(seconds:  val_10.x);
        this.<>1__state = val_21;
        this.<>2__current = val_27;
        return (bool)val_21;
        label_16:
        val_25 = 2621448;
        val_26 = 0;
        label_17:
        val_21 = 0;
        DG.Tweening.Sequence val_14 = this.<>4__this.MoveSymbol(scale:  null, trans:  this.<scale>5__2, dest:  2621448, destroy:  false);
        val_27 = 1152921504797581312;
        DG.Tweening.TweenCallback val_15 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(3913708384));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.<>4__this, callback:  190734336);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.<>4__this, interval:  null);
        DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(3913709408));
        object val_19 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.<>4__this, action:  190734336);
        return (bool)val_21;
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
