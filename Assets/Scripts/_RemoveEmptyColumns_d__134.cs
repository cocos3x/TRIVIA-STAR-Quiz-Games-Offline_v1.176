using UnityEngine;
private sealed class WPTGameUIController.<RemoveEmptyColumns>d__134 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    private System.Collections.Generic.List<UnityEngine.GameObject> <colsToRemove>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<RemoveEmptyColumns>d__134(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        System.Collections.Generic.List<UnityEngine.GameObject> val_11;
        twelvegigs.sweepstakes.Distribution val_12;
        var val_13;
        object val_14;
        val_10 = 0;
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
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        this.<colsToRemove>5__2 = null;
        val_11 = this.<colsToRemove>5__2;
        if(((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) - 1) >= 0)
        {
                do
        {
            int val_3 = SL - 4;
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((0 + (SL) << 2 + 28 + 8) <= 0)
        {
                this.<>4__this.<currentData>k__BackingField.colData.RemoveAt(index:  val_3);
            if((this.<>4__this.<currentData>k__BackingField.colData) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_4 = 0 + (SL) << 2.gameObject;
            val_12 = 0 + (SL) << 2;
            this.<colsToRemove>5__2.SyncRoot.Add(item:  val_12);
            this.<>4__this.<currentColumns>k__BackingField.RemoveAt(index:  val_3);
        }
        
            var val_5 = SL - 1;
        }
        while((SL - 5) > 1);
        
        }
        
        if((mem[this.<colsToRemove>5__2.SyncRoot + 12]) < 1)
        {
            goto label_23;
        }
        
        val_13 = 0;
        goto label_24;
        label_31:
        if((mem[this.<colsToRemove>5__2.SyncRoot + 12]) <= val_13)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 0;
        mem2[0] = val_13;
        val_13 = 1;
        label_24:
        if(val_13 < val_10)
        {
            goto label_31;
        }
        
        UnityEngine.WaitForSeconds val_7 = null;
        val_14 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_10 = 1;
        this.<>1__state = val_10;
        this.<>2__current = val_14;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Recalculate();
        return (bool)val_10;
        label_2:
        val_11 = this.<colsToRemove>5__2;
        this.<>1__state = 0;
        label_23:
        val_14 = 0;
        val_12 = 1152921504765685760;
        goto label_37;
        label_43:
        if((mem[this.<colsToRemove>5__2.SyncRoot + 12]) <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = mem[this.<colsToRemove>5__2.SyncRoot + 8];
        val_11 = val_11 + 0;
        UnityEngine.Object.Destroy(obj:  (mem[this.<colsToRemove>5__2.SyncRoot + 8] + 0) + 16);
        val_14 = 1;
        label_37:
        if(val_14 < (mem[this.<colsToRemove>5__2.SyncRoot + 12]))
        {
            goto label_43;
        }
        
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        val_10 = 1;
        return (bool)val_10;
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
