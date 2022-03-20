using UnityEngine;
private sealed class RESReelsController.<ActualSpinStart>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESReelsController <>4__this;
    private int <reel>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESReelsController.<ActualSpinStart>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15;
        RestaurantRivals.RESReelsController val_16;
        var val_17;
        var val_18;
        bool val_19;
        RestaurantRivals.RESReelsController val_23;
        var val_24;
        var val_25;
        var val_26;
        val_15 = 0;
        val_16 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
            val_17 = this;
            this.<reel>5__2 = 0;
            this.<>1__state = 0;
        }
        else
        {
                val_18 = this;
            int val_15 = this.<reel>5__2;
            val_15 = val_15 + 1;
            this.<>1__state = 0;
            this.<reel>5__2 = val_15;
            if(val_15 >= 3)
        {
                return (bool)val_15;
        }
        
        }
        
        var val_19 = 0;
        null = new System.Object();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_19 = 0;
        if((this.<reel>5__2) == 2)
        {
                bool val_3 = System.String.op_Equality(a:  this.<>4__this.ReelData[2], b:  this.<>4__this.ReelData[(this.<reel>5__2 + 1) + 8 + 8]);
            val_19 = val_3;
        }
        
        do
        {
            val_23 = val_16;
            RestaurantRivals.RESSymbolItemData val_4 = val_23.GetRESSymbolItemDataObject(symbol:  this.<>4__this.previousReelData[val_3]);
            Add(item:  val_23);
            val_19 = val_19 + 1;
        }
        while(val_19 != 5);
        
        if(val_19 == true)
        {
                80 = 100;
            70 = 90;
        }
        
        val_24 = 0;
        if((UnityEngine.Random.Range(min:  90, max:  100)) < 1)
        {
            goto label_25;
        }
        
        var val_20 = 0;
        do
        {
            string val_6 = RestaurantRivals.RESSymbol.GetRandomSymbol();
            RestaurantRivals.RESSymbolItemData val_7 = val_23.GetRESSymbolItemDataObject(symbol:  null);
            Add(item:  val_23);
            val_20 = val_20 + 1;
        }
        while(val_20 < (UnityEngine.Random.Range(min:  90, max:  100)));
        
        goto label_25;
        label_31:
        val_25 = mem[this.<>4__this + 24 + 8];
        val_25 = this.<>4__this + 24 + 8;
        if(val_25 <= val_15)
        {
                val_25 = mem[this.<>4__this + 24 + 8];
            val_25 = this.<>4__this + 24 + 8;
        }
        
        val_23 = val_16;
        val_25 = (this.<>4__this + 24) + (val_25 << 2);
        RestaurantRivals.RESSymbolItemData val_9 = val_23.GetRESSymbolItemDataObject(symbol:  (this.<>4__this + 24 + (this.<>4__this + 24 + 8) << 2) + 16);
        Add(item:  val_23);
        val_24 = 1;
        label_25:
        if(val_24 != 5)
        {
            goto label_31;
        }
        
        val_26 = null;
        var val_10 = (this.<>4__this + 12) + (val_15 << 2);
        (this.<>4__this + 12 + (this.<reel>5__2) << 2) + 16.SetData<System.Object>(data:  80883712, invert:  true, windStartDis:  null, windEndDis:  null);
        typeof(RESReelsController.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = val_15;
        var val_11 = (this.<>4__this + 12) + (val_15 << 2);
        DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  428167168, method:  new IntPtr(620012896));
        val_16 = 1152921505700909035;
        if(val_19 == true)
        {
                0f = 1060320051;
        }
        
        float val_13 = 0f + 0.7f;
        (this.<>4__this + 12 + (this.<reel>5__2) << 2) + 16.StartSpin(scrollCount:  1094062059, duration:  val_13, callback:  val_13);
        UnityEngine.WaitForSeconds val_14 = null;
        val_14 = new UnityEngine.WaitForSeconds(seconds:  val_13);
        val_15 = 1;
        this.<>1__state = val_15;
        mem[1152921513816819500] = val_14;
        return (bool)val_15;
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
