using UnityEngine;
private sealed class WordRegionCrossword.<LoadCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordRegionCrossword <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordRegionCrossword.<LoadCoroutine>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_12;
        float val_43;
        float val_46;
        float val_47;
        var val_48;
        System.Func<System.String, System.Boolean> val_50;
        var val_51;
        var val_52;
        WordRegionCrossword val_53;
        var val_54;
        var val_55;
        var val_59;
        var val_60;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        this.<>1__state = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        goto label_3;
        label_1:
        this.<>1__state = 0;
        System.Collections.Generic.List<T> val_2 = CUtils.BuildListFromString<System.String>(values:  -2050893440, split:  '|');
        System.Collections.Generic.List<T> val_3 = CUtils.BuildListFromString<System.String>(values:  -2050893440, split:  '|');
        mem2[0] = this;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem2[0] = null;
        System.Collections.Generic.List<T> val_5 = CUtils.BuildListFromString<System.String>(values:  null, split:  '|');
        mem2[0] = 0;
        System.Collections.Generic.List<System.String> val_6 = GetLevelProgress();
        T[] val_7 = ToArray();
        MainController val_8 = MainController.instance;
        val_48 = null;
        val_48 = null;
        val_50 = WordRegionCrossword.<>c.<>9__8_0;
        if(val_50 == 0)
        {
                val_50 = null;
            val_50 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordRegionCrossword.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2244035408));
            WordRegionCrossword.<>c.<>9__8_0 = val_50;
        }
        
        mem[136] = System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  R8, predicate:  7720960);
        if(this != 0)
        {
                mem2[0] = this.<>2__current;
            this.<>4__this.SetupHackedWordsLists(wordList:  -2050893440);
        }
        else
        {
                mem2[0] = 0;
            this.<>4__this.SetupHackedWordsLists(wordList:  -2050893440);
        }
        
        List.Enumerator<T> val_11 = GetEnumerator();
        goto label_22;
        label_46:
        object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  279498752);
        if(val_12.Chars[0] != ('*'))
        {
            goto label_27;
        }
        
        string val_15 = val_12.Substring(startIndex:  1);
        string val_16 = val_12.ToUpper();
        val_51 = val_12;
        val_52 = 1;
        if(MonoUtils.instance.lineWord != 0)
        {
            goto label_33;
        }
        
        goto label_33;
        label_27:
        string val_17 = val_12.ToUpper();
        val_51 = val_12;
        val_52 = 0;
        label_33:
        typeof(LineWord).__il2cppRuntimeField_C = val_51;
        Cell val_18 = MonoUtils.instance.cell;
        Build(cellType:  MonoUtils.instance, clickable:  true);
        if(val_52 != 0)
        {
                SetStarred();
        }
        
        SetProgress(progress:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg);
        UnityEngine.Transform val_19 = transform;
        UnityEngine.Transform val_20 = this.<>4__this.transform;
        UnityEngine.Transform val_21 = this.<>4__this.parent;
        SetParent(p:  this.<>4__this);
        UnityEngine.Transform val_22 = transform;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_24 = transform;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
        localPosition = new UnityEngine.Vector3();
        this.<>4__this + 24.Add(item:  279498752);
        label_22:
        if(MoveNext() == true)
        {
            goto label_46;
        }
        
        Dispose();
        val_53 = this.<>4__this;
        System.Collections.Generic.List<T> val_27 = CUtils.BuildListFromString<System.Int32>(values:  this.<>4__this + 76 + 80, split:  '|');
        if((this.<>4__this + 76 + 80 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem2[0] = this.<>4__this + 76 + 80 + 8 + 16;
        if((this.<>4__this + 76 + 80 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem2[0] = this.<>4__this + 76 + 80 + 8 + 20;
        System.Collections.Generic.List<T> val_29 = CUtils.BuildListFromString<System.String>(values:  this.<>4__this + 76 + 76, split:  '|');
        System.Collections.Generic.List<System.Int32> val_30 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_31 = GetEnumerator();
        label_69:
        if(MoveNext() == false)
        {
            goto label_55;
        }
        
        System.Collections.Generic.List<T> val_33 = CUtils.BuildListFromString<System.String>(values:  val_12, split:  ',');
        if((val_12 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.Int32.TryParse(s:  val_12 + 8 + 16, result: out  int val_34 = -2050905484)) == false)
        {
            goto label_62;
        }
        
        if((val_12 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.Int32.TryParse(s:  val_12 + 8 + 20, result: out  int val_36 = -2050905480)) == false)
        {
            goto label_62;
        }
        
        Add(item:  new Vector2Int());
        if((val_12 + 12) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(item:  System.Int32.Parse(s:  val_12 + 8 + 24));
        goto label_69;
        label_62:
        string val_39 = -2050923696(-2050923696) + val_12;
        UnityEngine.Debug.LogError(message:  -2050923696);
        goto label_69;
        label_55:
        Dispose();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_40 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_54 = 0;
        val_55 = new System.Collections.Generic.List<Vector2Int>();
        if( != 0)
        {
                val_59 = ;
            val_60 = mem[this.<>4__this + 200];
            val_60 = this.<>4__this + 200;
        }
        else
        {
                val_59 = 200;
            val_60 = 188;
        }
        
        val_60.constraintCount = this.<>4__this + 204;
        UnityEngine.Vector2 val_42 = UnityEngine.Vector2.one;
        UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -1.821218E-35f, y = val_43}, d:  val_42.x);
        val_59.cellSize = new UnityEngine.Vector2() {x = val_46, y = val_47};
        if((this.<>4__this + 204) <= 7)
        {
                if((this.<>4__this + 208) > 7)
        {
                0 = 1;
        }
        
        }
    
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
