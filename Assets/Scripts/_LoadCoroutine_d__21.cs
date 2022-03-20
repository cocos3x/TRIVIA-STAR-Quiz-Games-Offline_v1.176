using UnityEngine;
private sealed class WOLWordRegion.<LoadCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Wordlicious.WOLWordRegion <>4__this;
    private System.Collections.Generic.List<UnityEngine.GameObject> <goPages>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WOLWordRegion.<LoadCoroutine>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WOLWordRegion.<LoadCoroutine>d__21 val_24;
        SLC.Wordlicious.WOLWordRegion val_25;
        int val_26;
        System.Comparison<WordForest.NewsArticle> val_27;
        System.Collections.Generic.List<System.String> val_28;
        System.Collections.Generic.List<System.String> val_29;
        var val_30;
        int val_31;
        System.Collections.Generic.List<System.String> val_32;
        val_24 = this;
        val_25 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
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
        Player val_2 = App.Player;
        string val_3 = System.String.Format(format:  2127161280, arg0:  13152256);
        Dictionary.KeyCollection<TKey, TValue> val_4 = this.<>4__this.level.<words>k__BackingField.Keys;
        System.Collections.Generic.List<ZooTile> val_5 = new System.Collections.Generic.List<ZooTile>(collection:  this.<>4__this.level.<words>k__BackingField);
        this.<>4__this.wordList = null;
        val_27 = null;
        val_27 = new System.Comparison<WordForest.NewsArticle>(object:  val_25, method:  new IntPtr(731328688));
        Sort(comparison:  7933952);
        CompanyDevices val_7 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                string val_9 = MiniJSON.Json.Serialize(obj:  this.<>4__this.wordList);
            UnityEngine.Debug.Log(message:  this.<>4__this.wordList);
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<goPages>5__2 = null;
        val_28 = this.<>4__this.level.<progress>k__BackingField.<wordRegionLetters>k__BackingField;
        if(val_28 == 0)
        {
                val_28 = val_28;
        }
        
        val_29 = this.<>4__this.wordList;
        if((this.<>4__this.wordList) != 0)
        {
            goto label_22;
        }
        
        val_29 = this.<>4__this.wordList;
        if(val_29 == 0)
        {
            goto label_23;
        }
        
        label_22:
        float val_23 = 12f;
        val_30 = 0;
        val_23 = ((float)this.<>4__this.level.<words>k__BackingField) / val_23;
        int val_11 = UnityEngine.Mathf.CeilToInt(f:  val_23);
        this.<>4__this.numPages = val_11;
        if(val_11 >= 1)
        {
                var val_24 = 0;
            do
        {
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.page);
            UnityEngine.Transform val_13 = this.<>4__this.page.transform;
            UnityEngine.Transform val_14 = val_25.transform;
            this.<>4__this.page.SetParent(p:  val_25);
            UnityEngine.Transform val_15 = this.<>4__this.page.transform;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            this.<>4__this.page.localPosition = new UnityEngine.Vector3() {x = 0f};
            UnityEngine.Transform val_17 = this.<>4__this.page.transform;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            this.<>4__this.page.localScale = new UnityEngine.Vector3();
            this.<>4__this.page.Init(lineWord:  this.<>4__this.lineWordPrefab, cell:  this.<>4__this.cell, safeAreaWithinParent:  this.<>4__this.safeAreaWithinParent);
            this.<>4__this.pages.Add(item:  this.<>4__this.page);
            UnityEngine.GameObject val_19 = this.<>4__this.page.gameObject;
            this.<goPages>5__2.Add(item:  this.<>4__this.page);
            val_31 = 12;
            if(1 == (this.<>4__this.numPages))
        {
                val_31 = 0 + (this.<>4__this.numPages);
        }
        
            System.Collections.Generic.List<T> val_20 = this.<>4__this.wordList.GetRange(index:  0, count:  val_31);
            val_27 = 0;
            if((this.<>4__this.level.<progress>k__BackingField.<wordRegionLetters>k__BackingField + 12) == val_29)
        {
                val_32 = val_28;
            if(val_32 == 0)
        {
                val_32 = val_28;
        }
        
            System.Collections.Generic.List<T> val_21 = val_32.GetRange(index:  0, count:  val_31);
            val_27 = val_32;
        }
        
            this.<>4__this.page.Load(wordList:  this.<>4__this.wordList, wordListLevelProgress:  val_27);
            val_24 = val_24 + 12;
            val_25 = val_25;
            val_30 = 0;
            val_24 = val_24;
        }
        while(1 < (this.<>4__this.numPages));
        
        }
        
        this.<>1__state = 2;
        mem[1152921513928202876] = new UnityEngine.WaitForEndOfFrame();
        val_26 = 1;
        return (bool)val_26;
        label_1:
        this.<>1__state = 0;
        val_27 = this.<>4__this.pageDisplay;
        val_26 = 0;
        val_27.Load(pages:  this.<goPages>5__2);
        return (bool)val_26;
        label_23:
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
