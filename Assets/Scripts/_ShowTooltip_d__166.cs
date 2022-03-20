using UnityEngine;
private sealed class Alphabet2Manager.<ShowTooltip>d__166 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineWord word;
    public Alphabet2Manager <>4__this;
    public UnityEngine.Transform letterTransform;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Alphabet2Manager.<ShowTooltip>d__166(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        var val_22;
        int val_23;
        var val_24;
        var val_25;
        if((this.<>1__state) != 1)
        {
                val_23 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_23;
        }
        
            this.<>1__state = 0;
            val_23 = 1;
            this.<>1__state = val_23;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_23;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_2 = 0.AlphabetTileTooltipPrefab;
        WordRegion val_3 = WordRegion.instance;
        UnityEngine.Transform val_4 = 0.SafeTransform;
        object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  0, parent:  0);
        object val_6 = 0.GetComponent<System.Object>();
        object val_7 = this.word.GetComponent<System.Object>();
        UnityEngine.Vector3 val_8 = localPosition;
        float val_22 = 20f;
        val_22 = val_22 + val_9;
        PluginExtension.SetLocalY(transform:  0, y:  val_22);
        WordRegion val_10 = WordRegion.instance;
        UnityEngine.Rect val_11 = getSafeAreaRect;
        float val_12 = width;
        val_22 = ;
        if(0 != 0)
        {
                object val_13 = 0.GetComponent<System.Object>();
            val_24 = 0;
        }
        else
        {
                object val_14 = 0.GetComponent<System.Object>();
            val_24 = 0;
        }
        
        object val_15 = 0.GetComponent<System.Object>();
        UnityEngine.Vector2 val_16 = sizeDelta;
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_16.x, y:  val_16.y);
        val_24.sizeDelta = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
        if(0 != 0)
        {
                object val_19 = 0.GetComponent<System.Object>();
            val_25 = 0;
        }
        else
        {
                object val_20 = 0.GetComponent<System.Object>();
            val_25 = 0;
        }
        
        val_23 = 0;
        UnityEngine.Transform val_21 = 0.transform;
        val_25.Setup(toolTipBase:  0, letter:  this.letterTransform);
        return (bool)val_23;
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
