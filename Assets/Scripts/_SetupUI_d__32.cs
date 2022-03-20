using UnityEngine;
private sealed class WGAlphabetCollectionBoxPopup.<SetupUI>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGAlphabetCollectionBoxPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGAlphabetCollectionBoxPopup.<SetupUI>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_33;
        int val_34;
        UnityEngine.RectTransform[] val_35;
        var val_36;
        int val_37;
        var val_38;
        System.Collections.Generic.List<System.String> val_39;
        var val_40;
        System.Func<System.String, System.Int32> val_42;
        var val_43;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_34 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_34;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_4;
        }
        
        this.<>4__this.skip = false;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_2 = GetCurrentRewardAmount;
        object val_3 = this.<>4__this.rewardAmount.GetComponent<System.Object>();
        this.<>4__this.rewardAmount.Set(instantValue:  new System.Decimal() {flags = mem[this.<>4__this.currentCollectionRewardAmount + (0)], hi = mem[this.<>4__this.currentCollectionRewardAmount + (4)], lo = mem[this.<>4__this.currentCollectionRewardAmount + (8)], mid = mem[this.<>4__this.currentCollectionRewardAmount + (12)]});
        val_36 = 1152921511096081520;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_5 = GetRedrawCost;
        GameEcon val_6 = App.getGameEcon;
        string val_7 = ToString(format:  null);
        UnityEngine.GameObject val_8 = this.<>4__this.continueButton.gameObject;
        this.<>4__this.continueButton.SetActive(value:  false);
        UnityEngine.GameObject val_9 = this.<>4__this.redrawButton.gameObject;
        this.<>4__this.redrawButton.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_11 = GetCurrentCollectionProgress;
        if((this.<>4__this.hasDrawn) == false)
        {
            goto label_24;
        }
        
        System.Collections.IEnumerator val_12 = this.<>4__this.AnimateCollecting();
        label_70:
        val_34 = 0;
        UnityEngine.Coroutine val_13 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        return (bool)val_34;
        label_2:
        this.<>1__state = 0;
        val_37 = this;
        val_34 = 1;
        this.<>4__this.coinRewardGroup.SetActive(value:  true);
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return (bool)val_34;
        label_4:
        mem[93] = 0;
        label_5:
        this.<>4__this.wordRegion.Clear();
        val_38 = 0;
        UnityEngine.Transform val_15 = this.<>4__this.wordRegion.transform;
        MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.<>4__this.wordRegion);
        goto label_32;
        label_37:
        UnityEngine.RectTransform val_33 = this.<>4__this.boxItemsParentRows[val_38];
        UnityEngine.Transform val_16 = val_33.transform;
        MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  val_33);
        val_38 = 1;
        label_32:
        if(val_38 < val_33)
        {
            goto label_37;
        }
        
        val_35 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_18 = GetCurrentCollection;
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_20 = GetCurrentCollectionProgress;
        this.<>4__this.wordRegion.Setup(requiredWords:  -2100700048, progressWords:  -2100700048);
        val_39 = this.<>4__this.CurrentCollectionBoxLetters;
        if(val_39 == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_22 = GetCurrentCollectionBox;
            val_39 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
            this.<>4__this.CurrentCollectionBoxLetters = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
        }
        
        val_40 = null;
        val_40 = null;
        val_42 = WGAlphabetCollectionBoxPopup.<>c.<>9__32_0;
        if(val_42 == 0)
        {
                val_42 = null;
            val_42 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WGAlphabetCollectionBoxPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2730058400));
            WGAlphabetCollectionBoxPopup.<>c.<>9__32_0 = val_42;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_24 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  -2100700048, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_25 = System.Linq.Enumerable.ToList<System.Object>(source:  -2100700048);
        val_33 = val_39;
        val_36 = 0;
        val_37 = 1152921511631873696;
        val_43 = 0;
        goto label_62;
        label_68:
        UnityEngine.RectTransform val_35 = this.<>4__this.boxItemsParentRows[val_43];
        UnityEngine.GameObject val_29 = val_35.gameObject;
        val_37 = this.<>4__this.boxItemsPerRow;
        if((public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C) > (val_37 * val_43))
        {
                0 = 1;
        }
        
        val_35.SetActive(value:  true);
        val_43 = 1;
        label_62:
        if(val_43 < val_35)
        {
            goto label_68;
        }
        
        this.<>4__this.currentCollectedLetters.Clear();
        val_34 = 1;
        this.<>1__state = val_34;
        mem[1152921511632027756] = new UnityEngine.WaitForEndOfFrame();
        return (bool)val_34;
        label_24:
        System.Collections.IEnumerator val_32 = this.<>4__this.ShowTooltipBeforeAnimating();
        goto label_70;
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
