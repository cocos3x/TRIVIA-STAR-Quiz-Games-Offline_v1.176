using UnityEngine;
private sealed class WordBubblesUIController.<ActuralPoint>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.Bubbles.WordBubblesUIController <>4__this;
    public int bubbleIndex;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordBubblesUIController.<ActuralPoint>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WordBubblesUIController.<ActuralPoint>d__25 val_17;
        int val_18;
        SLC.Minigames.Bubbles.WordBubblesUIController val_19;
        var val_20;
        val_17 = this;
        if((this.<>1__state) != 1)
        {
                val_18 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_18;
        }
        
            this.<>1__state = 0;
            val_18 = 1;
            this.<>1__state = val_18;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_18;
        }
        
        val_19 = this.<>4__this;
        this.<>1__state = 0;
        val_20 = 0;
        goto label_5;
        label_23:
        UnityEngine.GameObject val_2 = 1152921508447513984.gameObject;
        if(1152921508447513984.activeSelf != false)
        {
                UnityEngine.Transform val_4 = this.<>4__this.hand.transform;
            UnityEngine.Transform val_5 = 1152921508447513984.transform;
            UnityEngine.Vector3 val_6 = position;
            UnityEngine.Transform val_8 = 1152921508447513984.transform;
            UnityEngine.Vector3 val_9 = position;
            UnityEngine.Transform val_11 = this.<>4__this.hand.transform;
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_12.x, y:  val_12.y, z:  val_12.z);
            this.<>4__this.hand.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            object val_15 = 1152921508447513984.GetComponent<System.Object>();
            val_19 = val_19;
            1152921508447513984.enabled = true;
            val_17 = val_17;
        }
        
        val_20 = 1;
        label_5:
        if(val_20 < 1152921508447513984)
        {
            goto label_23;
        }
        
        val_18 = 0;
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
