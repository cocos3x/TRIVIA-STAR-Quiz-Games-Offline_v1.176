using UnityEngine;
private sealed class WPTWordList.<LoadGenerativeWordLists>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WPTWordList <>4__this;
    private int <totalWordCount>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTWordList.<LoadGenerativeWordLists>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        twelvegigs.sweepstakes.Distribution val_17;
        WPTWordList.<LoadGenerativeWordLists>d__9 val_28;
        int val_29;
        var val_30;
        int val_31;
        int val_32;
        var val_33;
        UnityEngine.TextAsset[] val_34;
        int val_35;
        float val_36;
        int val_37;
        val_28 = this;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_1 = 6106996 + (6106996 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                6106996 + (this.<>1__state) << 2 = (6106996 + (this.<>1__state) << 2) & ((6106996 + (this.<>1__state) << 2) << (6106996 + (this.<>1__state) << 2));
            mem2[0] = (6106996 + (this.<>1__state) << 2 & (6106996 + (this.<>1__state) << 2) << 6106996 + (this.<>1__state) << 2) + 35625643;
            ((6106996 + (this.<>1__state) << 2 & (6106996 + (this.<>1__state) << 2) << 6106996 + (this.<>1__state) << 2) + 35625643) & (((35625643) << (32-as. 
            
        
        
        
        
        
           
        )) | ((35625643) << as. 
            
        
        
        
        
        
           
        )) = (((6106996 + (this.<>1__state) << 2 & (6106996 + (this.<>1__state) << 2) << 6106996 + (this.<>1__state) << 2) + 35625643) & (((35625643) << (32-as. 
            
        
        
        
        
        
           
        )) | ((35625643) << as. 
            
        
        
        
        
        
           
        ))) & ((IP) << 1);
        }
        
        val_29 = 0;
        this.<totalWordCount>5__2 = val_29;
        this.<>1__state = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_30 = val_28;
        this.<>4__this.generativeWordLists = null;
        this.<i>5__3 = val_29;
        if( >= (this.<i>5__3))
        {
            goto label_10;
        }
        
        UnityEngine.TextAsset val_25 = this.<>4__this.commonWordsSources[];
        string val_3 = val_25.text;
        object val_4 = MiniJSON.Json.Deserialize(json:  val_25);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<>4__this.generativeWordLists.Add(item:  80883712);
        val_33 = 1152921504687730688;
        val_34 = 0;
        goto label_20;
        label_10:
        this.<>4__this.uncommonWordsLists = null;
        val_31 = 0;
        this.<i>5__3 = val_31;
        if(val_31 >= (new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()))
        {
            goto label_22;
        }
        
        UnityEngine.TextAsset val_26 = this.<>4__this.uncommonWordsSources[this.<i>5__3];
        string val_7 = val_26.text;
        object val_8 = MiniJSON.Json.Deserialize(json:  val_26);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<>4__this.uncommonWordsLists.Add(item:  80883712);
        val_33 = 1152921504687730688;
        val_34 = 0;
        goto label_32;
        label_22:
        this.<>4__this.rareWordsLists = null;
        val_32 = 0;
        this.<i>5__3 = val_32;
        val_34 = this.<>4__this.rareWordsSources;
        if(val_32 >= (new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()))
        {
            goto label_34;
        }
        
        UnityEngine.TextAsset val_27 = this.<>4__this.rareWordsSources[this.<i>5__3];
        string val_11 = val_27.text;
        object val_12 = MiniJSON.Json.Deserialize(json:  val_27);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_13 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<>4__this.rareWordsLists.Add(item:  80883712);
        val_33 = 1152921504687730688;
        val_34 = 0;
        goto label_44;
        label_34:
        val_35 = 0;
        string val_14 = 116047920 + 13152256 + 116048112;
        UnityEngine.Debug.Log(message:  116047920);
        return (bool)val_35;
        label_1:
        val_35 = 0;
        return (bool)val_35;
        label_32:
        List.Enumerator<T> val_15 = this.<totalWordCount>5__2.GetEnumerator();
        val_28 = 1152921510382894416;
        val_36 = 1152921510046813136;
        label_55:
        bool val_16 = MoveNext();
        if(val_16 == false)
        {
            goto label_49;
        }
        
        if(val_16 <= (this.<i>5__3))
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + 0;
        string val_18 = val_17.ToUpper();
        (0 + 0) + 16.Add(item:  val_17);
        goto label_55;
        label_49:
        Dispose();
        val_37 = 2;
        goto label_56;
        label_44:
        List.Enumerator<T> val_19 = this.<totalWordCount>5__2.GetEnumerator();
        val_28 = 1152921510382894416;
        val_36 = 1152921510046813136;
        label_63:
        bool val_20 = MoveNext();
        if(val_20 == false)
        {
            goto label_57;
        }
        
        if(val_20 <= (this.<i>5__3))
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + 0;
        string val_21 = val_17.ToUpper();
        (0 + 0) + 16.Add(item:  val_17);
        goto label_63;
        label_57:
        Dispose();
        val_37 = 3;
        label_56:
        val_35 = 1;
        this.<>1__state = val_37;
        mem[1152921513312866076] = 0;
        return (bool)val_35;
        label_20:
        List.Enumerator<T> val_22 = this.<totalWordCount>5__2.GetEnumerator();
        val_28 = 1152921510382894416;
        val_36 = 1152921510046813136;
        label_71:
        bool val_23 = MoveNext();
        if(val_23 == false)
        {
            goto label_65;
        }
        
        if(val_23 <= (this.<i>5__3))
        {
                var val_30 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_30 = val_30 + 0;
        string val_24 = val_17.ToUpper();
        (0 + 0) + 16.Add(item:  val_17);
        goto label_71;
        label_65:
        Dispose();
        val_35 = 1;
        this.<>1__state = val_35;
        mem[1152921513312866076] = 0;
        return (bool)val_35;
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
