using UnityEngine;
private sealed class SpinKingReelsController.<ActualSpinStart>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SpinKingReelsController <>4__this;
    private int <reel>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpinKingReelsController.<ActualSpinStart>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        var val_13;
        var val_14;
        var val_18;
        var val_19;
        var val_21;
        val_12 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
            val_13 = this;
            this.<reel>5__2 = 0;
            this.<>1__state = 0;
        }
        else
        {
                val_14 = this;
            int val_12 = this.<reel>5__2;
            val_12 = val_12 + 1;
            this.<>1__state = 0;
            this.<reel>5__2 = val_12;
            if(val_12 >= 3)
        {
                return (bool)val_12;
        }
        
        }
        
        object val_1 = new System.Object();
        typeof(SpinKingReelsController.<>c__DisplayClass10_0).__il2cppRuntimeField_C = this.<>4__this;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((this.<reel>5__2) == 2)
        {
                SpinKingSymbol val_14 = this.<>4__this.ReelData[(this.<reel>5__2 + 1) + 8 + 8];
            val_14 = (this.<>4__this.ReelData[2]) - val_14;
            val_14 = val_14 >> 5;
        }
        
        var val_16 = 0;
        do
        {
            SpinKingSymbolItemData val_3 = this.<>4__this.GetRESSymbolItemDataObject(symbol:  this.<>4__this.previousReelData[val_14]);
            Add(item:  this.<>4__this);
            val_16 = val_16 + 1;
        }
        while(val_16 != 5);
        
        if(val_14 != 0)
        {
                70 = 90;
            80 = 100;
        }
        
        val_18 = 0;
        if((UnityEngine.Random.Range(min:  90, max:  100)) >= 1)
        {
                var val_17 = 0;
            do
        {
            SpinKingSymbol val_5 = SpinKingSlotMachine.GetRandomSymbol(except:  0);
            SpinKingSymbolItemData val_6 = this.<>4__this.GetRESSymbolItemDataObject(symbol:  0);
            Add(item:  this.<>4__this);
            int val_7 = UnityEngine.Random.Range(min:  90, max:  100);
            val_17 = val_17 + 1;
        }
        while(val_17 < val_7);
        
        }
        
        val_19 = null;
        goto label_26;
        label_32:
        SpinKingSymbolItemData val_8 = this.<>4__this.GetRESSymbolItemDataObject(symbol:  this.<>4__this.ReelData[val_7]);
        val_19 = null;
        Add(item:  this.<>4__this);
        val_18 = 1;
        label_26:
        if(val_18 != 5)
        {
            goto label_32;
        }
        
        val_21 = null;
        this.<>4__this.reels[val_12].SetData<System.Object>(data:  80883712, invert:  true, windStartDis:  null, windEndDis:  null);
        typeof(SpinKingReelsController.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = val_12;
        DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  379924480, method:  new IntPtr(4107576368));
        if(val_14 != 0)
        {
                0f = 1060320051;
        }
        
        float val_10 = 0f + 0.7f;
        this.<>4__this.reels[val_12].StartSpin(scrollCount:  1094062059, duration:  val_10, callback:  val_10);
        UnityEngine.WaitForSeconds val_11 = null;
        val_11 = new UnityEngine.WaitForSeconds(seconds:  val_10);
        val_12 = 1;
        this.<>1__state = val_12;
        mem[1152921513009415676] = val_11;
        return (bool)val_12;
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
