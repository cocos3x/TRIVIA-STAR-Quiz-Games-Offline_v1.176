using UnityEngine;
private sealed class WordRegion.<LoadCoroutine>d__70 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordRegion <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordRegion.<LoadCoroutine>d__70(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ZooTile val_13;
        var val_45;
        int val_46;
        var val_47;
        System.Func<System.String, System.Boolean> val_49;
        var val_50;
        GameLevel val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        val_45 = this;
        if((this.<>1__state) != 1)
        {
                val_46 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_46;
        }
        
            this.<>1__state = 0;
            val_46 = 1;
            this.<>1__state = val_46;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_46;
        }
        
        this.<>1__state = 0;
        System.Collections.Generic.List<T> val_2 = CUtils.BuildListFromString<System.String>(values:  this.<>4__this.gameLevel.answers, split:  '|');
        this.<>4__this.ExtraRequiredList = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_4 = this.<>4__this.gameLevel.extraRequiredWords.Split(separator:  478563824);
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Object>(source:  this.<>4__this.gameLevel.extraRequiredWords);
        this.<>4__this.ExtraRequiredList = this.<>4__this.gameLevel.extraRequiredWords;
        System.Collections.Generic.List<System.String> val_6 = this.<>4__this.gameLevel.GetLevelProgress();
        T[] val_7 = this.<>4__this.gameLevel.ToArray();
        System.Collections.Generic.List<T> val_8 = CUtils.BuildListFromString<System.String>(values:  this.<>4__this.gameLevel.extraWords, split:  '|');
        this.<>4__this.validWords = this.<>4__this.gameLevel.extraWords;
        System.Collections.Generic.List<T> val_9 = CUtils.BuildListFromString<System.String>(values:  this.<>4__this.gameLevel.availExtraReq, split:  '|');
        List.Enumerator<T> val_11 = GetEnumerator();
        label_21:
        if(MoveNext() == false)
        {
            goto label_17;
        }
        
        if((Contains(item:  val_13)) == true)
        {
            goto label_21;
        }
        
        Add(item:  val_13);
        goto label_21;
        label_17:
        Dispose();
        this.<>4__this.validWords = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_15 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_16 = GetEnumerator();
        label_28:
        if(MoveNext() == false)
        {
            goto label_24;
        }
        
        if((Contains(item:  val_13)) == true)
        {
            goto label_28;
        }
        
        Add(item:  val_13);
        goto label_28;
        label_24:
        Dispose();
        MainController val_19 = MainController.instance;
        val_47 = null;
        val_47 = null;
        val_49 = WordRegion.<>c.<>9__70_0;
        if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2239009872));
            WordRegion.<>c.<>9__70_0 = val_49;
        }
        
        mem[136] = System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.<>4__this.ExtraRequiredList, predicate:  7720960);
        System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32> val_22 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  this.<>4__this, method:  new IntPtr(2239011920));
        System.Linq.IOrderedEnumerable<TSource> val_23 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  80883712, keySelector:  7720960);
        System.Func<ZooTile, System.String> val_24 = new System.Func<ZooTile, System.String>(object:  this.<>4__this, method:  new IntPtr(2239013968));
        System.Linq.IOrderedEnumerable<TSource> val_25 = System.Linq.Enumerable.ThenBy<System.Object, System.Object>(source:  80883712, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_26 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
        mem2[0] = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
        this.<>4__this.SetupHackedWordsLists(wordList:  80883712);
        if((this.<>4__this.ExtraRequiredList) < 11)
        {
                3 = 2;
        }
        
        val_50 = this.<>4__this.ExtraRequiredList;
        mem2[0] = 1;
        val_50 = this.<>4__this.ExtraRequiredList;
        float val_46 = 1f;
        val_46 = ((float)this.<>4__this.ExtraRequiredList) / val_46;
        val_45 = 0;
        mem2[0] = val_45;
        mem2[0] = val_46;
        if(val_50 >= 2139095040)
        {
                var val_27 = 2139095040 - 1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            mem2[0] = ((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((2139095040 - 1)) << 2) + 16 + 8 + val_45);
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        mem2[0] = ((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((2139095040 - 1)) << 2) + 16 - 1)) << 2) + 16 + 8 + (UnityEngine.Mat;
        this.<>4__this.RecalculateCellSize();
        val_51 = this.<>4__this.gameLevel;
        if(val_51 == 0)
        {
                val_51 = this.<>4__this.gameLevel;
        }
        
        System.String[] val_28 = this.<>4__this.GetAncientLevelProgress();
        val_51 = null;
        List.Enumerator<T> val_29 = GetEnumerator();
        val_52 = 0;
        goto label_51;
        label_78:
        val_53 = val_13;
        object val_30 = UnityEngine.Object.Instantiate<System.Object>(original:  279498752);
        val_54 = 0;
        if((val_53.StartsWith(value:  -2063697616)) != false)
        {
                val_54 = 1;
            string val_32 = val_53.Remove(startIndex:  0, count:  1);
            val_53 = val_53;
        }
        
        string val_33 = val_53.ToUpper();
        if(MonoUtils.instance.lineWord != 0)
        {
                typeof(LineWord).__il2cppRuntimeField_C = val_53;
            typeof(LineWord).__il2cppRuntimeField_10 = val_53;
        }
        else
        {
                mem[12] = val_53;
            mem[16] = val_53;
        }
        
        SetLineWidth();
        Cell val_34 = MonoUtils.instance.cell;
        Build(cellType:  MonoUtils.instance, clickable:  true);
        if(val_54 != 0)
        {
                SetStarred();
        }
        
        val_55 = val_51;
        if(val_51 == 0)
        {
                val_55 = val_51;
        }
        
        SetProgress(progress:  System.String[].__il2cppRuntimeField_byval_arg);
        UnityEngine.Transform val_35 = transform;
        UnityEngine.Transform val_36 = this.<>4__this.transform;
        SetParent(p:  this.<>4__this);
        UnityEngine.Transform val_37 = transform;
        val_45 = 0;
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_39 = transform;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.zero;
        localPosition = new UnityEngine.Vector3();
        Add(item:  279498752);
        val_52 = 1;
        label_51:
        if(MoveNext() == true)
        {
            goto label_78;
        }
        
        Dispose();
        System.Collections.IEnumerator val_42 = this.<>4__this.ScaleToPositionAndFitLate();
        val_46 = 0;
        UnityEngine.Coroutine val_43 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        System.Collections.IEnumerator val_44 = this.<>4__this.LevelLoadCompleteActionCoroutine();
        UnityEngine.Coroutine val_45 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        this.<>4__this.NotifyLevelLoaded(level:  this.<>4__this.gameLevel);
        this.<>4__this.CheckGameComplete();
        return (bool)val_46;
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
