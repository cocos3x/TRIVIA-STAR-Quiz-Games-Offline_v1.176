using UnityEngine;
private sealed class PuzzleCollectionUIController.<ShowTooltip>d__65 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PuzzleCollectionUIController <>4__this;
    public UnityEngine.Transform parent;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PuzzleCollectionUIController.<ShowTooltip>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        var val_26;
        int val_27;
        var val_28;
        UnityEngine.GameObject val_29;
        var val_30;
        var val_31;
        var val_32;
        val_26 = this;
        if((this.<>1__state) != 1)
        {
                val_27 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_27;
        }
        
            this.<>1__state = 0;
            val_27 = 1;
            this.<>1__state = val_27;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_27;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.toolTipPrefab) != 0)
        {
                object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.toolTipPrefab, parent:  this.parent);
            val_28 = this.<>4__this;
            val_29 = this.<>4__this.toolTipPrefab;
            this.<>4__this.toolTipBase = this.<>4__this.toolTipPrefab;
        }
        else
        {
                val_28 = this.<>4__this;
            val_29 = this.<>4__this.toolTipBase;
        }
        
        object val_4 = val_29.GetComponent<System.Object>();
        object val_5 = this.<>4__this.word.GetComponent<System.Object>();
        UnityEngine.Vector3 val_6 = localPosition;
        float val_26 = 20f;
        val_26 = val_26 + val_7;
        PluginExtension.SetLocalY(transform:  val_29, y:  val_26);
        WordRegion val_8 = WordRegion.instance;
        UnityEngine.Rect val_9 = getSafeAreaRect;
        float val_10 = width;
        object val_11 = this.<>4__this + 72.GetComponent<System.Object>();
        object val_12 = this.<>4__this + 72.GetComponent<System.Object>();
        UnityEngine.Vector2 val_13 = sizeDelta;
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_13.x, y:  val_13.y);
        this.<>4__this + 72.sizeDelta = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
        val_30 = 0;
        if((this.<>4__this.toolTipPickPrefab) == 0)
        {
            goto label_24;
        }
        
        val_31 = 0;
        UnityEngine.Transform val_17 = this.<>4__this.letter.transform;
        val_30 = public static UnityEngine.GameObject UnityEngine.Object::Instantiate<UnityEngine.GameObject>(UnityEngine.GameObject original, UnityEngine.Transform parent);
        object val_18 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.toolTipPickPrefab, parent:  this.<>4__this.letter);
        val_32 = this.<>4__this.toolTipPickPrefab;
        if((this.<>4__this.toolTipPickPrefab) != 0)
        {
            goto label_28;
        }
        
        label_24:
        val_31 = 1;
        val_32 = 0;
        label_28:
        UnityEngine.Transform val_19 = val_32.transform;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        val_32.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_21 = val_32.transform;
        val_26 = val_32;
        UnityEngine.Transform val_22 = this.<>4__this + 72.transform;
        val_27 = 0;
        val_26.parent = this.<>4__this + 72;
        object val_23 = val_32.GetComponent<System.Object>();
        PluginExtension.SetLocalY(transform:  0, y:  val_20.x);
        System.Collections.IEnumerator val_24 = this.<>4__this.DestroyTooltipUponClick();
        UnityEngine.Coroutine val_25 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        this.<>4__this.destroyTooltipUponClick = this.<>4__this;
        return (bool)val_27;
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
