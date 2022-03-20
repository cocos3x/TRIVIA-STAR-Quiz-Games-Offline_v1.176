using UnityEngine;
private sealed class AlphabetWordRegion.<LoadCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AlphabetWordRegion <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AlphabetWordRegion.<LoadCoroutine>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        int val_26;
        var val_27;
        System.Func<System.String, System.Int32> val_29;
        var val_30;
        System.Func<System.String, System.String> val_32;
        var val_33;
        var val_34;
        var val_35;
        System.Collections.IEnumerator val_37;
        if((this.<>1__state) != 1)
        {
                val_26 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_26;
        }
        
            this.<>1__state = 0;
            val_26 = 1;
            this.<>1__state = val_26;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_26;
        }
        
        this.<>1__state = 0;
        val_27 = null;
        val_27 = null;
        val_29 = AlphabetWordRegion.<>c.<>9__10_0;
        if(val_29 == 0)
        {
                val_29 = null;
            val_29 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  AlphabetWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2724912688));
            AlphabetWordRegion.<>c.<>9__10_0 = val_29;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this.<>4__this.words, keySelector:  7720960);
        val_30 = null;
        val_30 = null;
        val_32 = AlphabetWordRegion.<>c.<>9__10_1;
        if(val_32 == 0)
        {
                val_32 = null;
            val_32 = new System.Func<ZooTile, System.String>(object:  AlphabetWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2724913712));
            AlphabetWordRegion.<>c.<>9__10_1 = val_32;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_5 = System.Linq.Enumerable.ThenBy<System.Object, System.Object>(source:  this.<>4__this.words, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Object>(source:  this.<>4__this.words);
        val_33 = this.<>4__this.words;
        System.Collections.Generic.List<System.String> val_7 = this.<>4__this.words.GetLevelProgress(savedProgress:  this.<>4__this.progress, orderedWordList:  this.<>4__this.words);
        mem2[0] = this.<>4__this.words;
        if((this.<>4__this.words) < 11)
        {
                3 = 2;
        }
        
        val_34 = this.<>4__this.words;
        mem2[0] = 1;
        val_34 = this.<>4__this.words;
        float val_26 = 1f;
        val_26 = ((float)this.<>4__this.words) / val_26;
        var val_28 = 0;
        mem2[0] = val_28;
        mem2[0] = val_26;
        if(val_34 >= 2139095040)
        {
                var val_8 = 2139095040 - 1;
            if(val_26 <= val_8)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_27 = val_27 + (val_8 << 2);
            val_28 = ((0 + ((2139095040 - 1)) << 2) + 16 + 8) + val_28;
            mem2[0] = val_28;
        }
        
        var val_29 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_29 = val_29 + ((((0 + ((2139095040 - 1)) << 2) + 16) - 1) << 2);
        mem2[0] = ((0 + (((0 + ((2139095040 - 1)) << 2) + 16 - 1)) << 2) + 16 + 8 + (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + 2139095040));
        this.<>4__this.RecalculateCellSize();
        if(0 != (this.<>4__this))
        {
                UnityEngine.Debug.LogWarning(message:  -1570048464, context:  this.<>4__this);
        }
        
        List.Enumerator<T> val_10 = GetEnumerator();
        val_35 = 0;
        goto label_29;
        label_43:
        LineWord val_12 = this.<>4__this.LineWordPrefabLoaded;
        object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this);
        string val_14 = val_11.ToUpper();
        mem2[0] = val_11;
        mem2[0] = val_11;
        this.<>4__this.SetLineWidth();
        Cell val_15 = this.<>4__this.CellPrefabLoaded;
        this.<>4__this.Build(cellType:  this.<>4__this, clickable:  false);
        if((this.<>4__this) >= 1)
        {
                if((this.<>4__this) <= val_35)
        {
                var val_30 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_30 = val_30 + 0;
            this.<>4__this.SetProgress(progress:  (0 + 0) + 16);
        }
        
        UnityEngine.Transform val_16 = this.<>4__this.transform;
        UnityEngine.Transform val_17 = this.<>4__this.transform;
        this.<>4__this.SetParent(p:  this.<>4__this);
        val_33 = this.<>4__this.words;
        UnityEngine.Transform val_18 = this.<>4__this.transform;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        this.<>4__this.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_20 = this.<>4__this.transform;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
        this.<>4__this.localPosition = new UnityEngine.Vector3();
        this.<>4__this.Add(item:  this.<>4__this);
        val_35 = 1;
        label_29:
        if(MoveNext() == true)
        {
            goto label_43;
        }
        
        Dispose();
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_23 = this.<>4__this.ScaleToPositionAndFitLate();
            val_37 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_24 = this.<>4__this.ScaleToPositionAndFitLate();
            val_37 = this.<>4__this;
        }
        
        val_26 = 0;
        UnityEngine.Coroutine val_25 = this.<>4__this.StartCoroutine(routine:  val_37);
        return (bool)val_26;
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
