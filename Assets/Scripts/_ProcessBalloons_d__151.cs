using UnityEngine;
private sealed class WPTGameUIController.<ProcessBalloons>d__151 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    private System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> <flyAwayDict>5__2;
    private bool <didEndEventTrigger>5__3;
    private System.Collections.Generic.Dictionary.Enumerator<WordPets.WPTLetterTile, WordPets.WPTPetTile> <>7__wrap3;
    private WordPets.WPTLetterTile <balloonTile>5__5;
    private WordPets.WPTPetTile <petTile>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<ProcessBalloons>d__151(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.<>1__state;
        val_1 = val_1 + 3;
        if(val_1 > 6)
        {
                return;
        }
        
        if((97 & (1 << val_1)) != 0)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        WPTGameUIController.<ProcessBalloons>d__151 val_27;
        bool val_28;
        WordPets.WPTGameUIController val_29;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_30;
        var val_31;
        WordPets.WPTPetTile val_32;
        val_27 = this;
        val_28 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        val_29 = this.<>4__this;
        var val_1 = 12959560 + (12959560 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                12959560 + (this.<>1__state) << 2 = (12959560 + (this.<>1__state) << 2) & ((12959560 + (this.<>1__state) << 2) << (12959560 + (this.<>1__state) << 2));
            12959560 + (this.<>1__state) << 2 = (12959560 + (this.<>1__state) << 2) & (((int)R8) >> R6);
            mem2[0] = ((12959560 + (this.<>1__state) << 2 & (12959560 + (this.<>1__state) << 2) << 12959560 + (this.<>1__state) << 2) & ((int)R8) >> R6) + ((12959560 + (this.<>1__state) << 2 & (12959560 + (this.<>1__state) << 2) << 12959560 + (this.<>1__state) << 2) & ((int)R8) >> R6);
        }
        
        val_30 = 0;
        this.<flyAwayDict>5__2 = val_30;
        this.<>1__state = 0;
        goto label_2;
        label_48:
        if(0 <= val_30)
        {
                var val_26 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = val_26 + 0;
        int val_2 = (0 + 0) + 16.GetLetterHeight();
        if(val_2 < 1)
        {
            goto label_27;
        }
        
        if(val_2 <= val_30)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + 0;
        var val_28 = (0 + 0) + 16;
        int val_4 = val_28.GetLetterHeight() + 3;
        label_41:
        val_27 = val_27;
        val_28 = val_4 - 4;
        val_29 = val_29;
        if(val_28 < 0)
        {
            goto label_27;
        }
        
        if((this.<>4__this + 112 + 12) <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_29 = this.<>4__this + 112 + 8;
        val_29 = val_29 + 0;
        if(((this.<>4__this + 112 + 8 + 0) + 16 + 16 + 12) <= val_28)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((((this.<>4__this + 112 + 8 + 0) + 16 + 16 + 8 + ((val_3 + 3)) << 2) == 0) || (0.HasBalloon == false)) || (0.HasSpiderWeb == true))
        {
            goto label_27;
        }
        
        if((this.<flyAwayDict>5__2) == 0)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            mem[1152921513383392260] = null;
        }
        
        if((this.<>4__this + 112 + 12) <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_30 = this.<>4__this + 112 + 8;
        val_30 = val_30 + 0;
        val_31 = 0;
        val_32 = 0;
        if((val_4 - 3) == ((this.<>4__this + 112 + 8 + 0) + 16.GetLetterHeight()))
        {
                val_31 = 0;
            if((this.<>4__this + 112 + 12) <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_31 = this.<>4__this + 112 + 8;
            val_31 = val_31 + 0;
            WordPets.WPTPetTile val_10 = (this.<>4__this + 112 + 8 + 0) + 16.GetPetTile();
            val_32 = (this.<>4__this + 112 + 8 + 0) + 16;
        }
        
        val_4 = val_4 - 1;
        Add(key:  0, value:  val_32);
        goto label_41;
        label_27:
        val_30 = 1;
        label_2:
        if(val_30 < val_2)
        {
            goto label_48;
        }
        
        val_28 = false;
        this.<didEndEventTrigger>5__3 = val_28;
        if((this.<flyAwayDict>5__2) == 0)
        {
                return (bool);
        }
        
        val_28 = 1;
        this.<>1__state = val_28;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool);
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap3.Dispose();
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
