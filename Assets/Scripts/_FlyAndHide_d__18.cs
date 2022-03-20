using UnityEngine;
private sealed class KeyToRichesTile.<FlyAndHide>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public KeyToRichesTile <>4__this;
    private UnityEngine.Vector3 <endPos>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KeyToRichesTile.<FlyAndHide>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        object val_18;
        int val_19;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 11556196 + (11556196 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                11556196 + (this.<>1__state) << 2 = (11556196 + (this.<>1__state) << 2) & ((11556196 + (this.<>1__state) << 2) << (11556196 + (this.<>1__state) << 2));
            11556196 + (this.<>1__state) << 2 = (11556196 + (this.<>1__state) << 2) & (((int)IP) >> 2);
            11556196 + (this.<>1__state) << 2 = (11556196 + (this.<>1__state) << 2) & ((11556196 + (this.<>1__state) << 2) << R2);
            mem2[0] = (((11556196 + (this.<>1__state) << 2 & (11556196 + (this.<>1__state) << 2) << 11556196 + (this.<>1__state) << 2) & ((int)IP) >> 2) & (((11556196 + (this.<>1__state) << 2 & (11556196 + (this.<>1__state + this;
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_2 = this.<>4__this.keyGroup.transform;
            UnityEngine.Transform val_3 = transform;
            val_17 = KeyToRichesEventHandler._Instance.eventButtonGO;
            this.<>4__this.keyGroup.SetParent(p:  157720576);
            UnityEngine.Transform val_4 = transform;
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.WaitForSeconds val_6 = null;
            val_18 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  val_5.x);
            val_19 = 1;
            this.<>1__state = val_19;
            this.<>2__current = val_18;
            return (bool);
        }
        
        val_19 = 0;
        return (bool);
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
