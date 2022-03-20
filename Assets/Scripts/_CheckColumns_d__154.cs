using UnityEngine;
private sealed class WPTGameUIController.<CheckColumns>d__154 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    private System.Collections.Generic.List<WordPets.WPTGameColumn> <columnsThatNeedWords>5__2;
    private System.Collections.Generic.List<char> <charactersToAdd>5__3;
    private int <column>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<CheckColumns>d__154(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WPTGameUIController.<CheckColumns>d__154 val_12;
        int val_13;
        var val_14;
        System.Int32[] val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        int val_20;
        val_12 = this;
        val_13 = 0;
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
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        System.Int32[] val_1 = this.<>4__this.gamemode.GetCharCount(includeSpiderWebTiles:  true);
        val_14 = val_12;
        val_15 = this.<>4__this.gamemode;
        this.<columnsThatNeedWords>5__2 = 0;
        val_16 = 4;
        goto label_6;
        label_16:
        if((this.<>4__this.gamemode) <= (this.<>4__this.gamemode))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443.GetLetterHeight() == 0)
        {
                val_12 = this.<columnsThatNeedWords>5__2;
            if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem[1152921513385373316] = val_12;
        }
        
            if(val_12 <= (this.<>4__this.gamemode))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            Add(item:  2621443);
        }
        
        val_16 = 5;
        label_6:
        if((val_16 - 4) < val_12)
        {
            goto label_16;
        }
        
        val_17 = mem[1152921513385373316];
        if(val_17 == 0)
        {
            goto label_17;
        }
        
        val_18 = 0;
        val_19 = 0;
        System.Collections.Generic.List<System.Char> val_5 = new System.Collections.Generic.List<System.Char>();
        mem[1152921513385373320] = null;
        if((this.<>4__this.<currentData>k__BackingField.<level>k__BackingField) <= 1)
        {
                if((this.<>4__this.doneItBefore) == false)
        {
            goto label_28;
        }
        
        }
        
        val_12 = val_12;
        this.<>4__this.AddExtraLetters(charactersToAdd:  80883712, lettersNeeded:  (List<T>.__il2cppRuntimeField_10 + 20 + 12 + val_19), letterOccuranceDict:  val_15);
        label_75:
        val_20 = 0;
        val_16 = val_12;
        mem[1152921513385373324] = val_20;
        goto label_29;
        label_1:
        this.<>1__state = 0;
        return (bool)val_13;
        label_2:
        val_16 = val_12;
        val_14 = 1152921513385373316;
        val_20 = (this.<column>5__4) + 1;
        this.<>1__state = 0;
        this.<column>5__4 = val_20;
        label_29:
        System.Collections.Generic.List<System.Char> val_6 = new System.Collections.Generic.List<System.Char>();
        val_15 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_12 = val_12;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.Collections.IEnumerator val_7 = this.<>4__this.AddLettersToColumn(column:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + ((this.<column>5__4 + 1)) << 2) + 16, characters:  80883712, isInitialPopulation:  false);
        val_13 = 1;
        this.<>1__state = val_13;
        mem[1152921513385373308] = this.<>4__this;
        return (bool)val_13;
        label_17:
        val_13 = 0;
        return (bool)val_13;
        label_28:
        Add(item:  'o');
        Add(item:  'g');
        this.<>4__this.doneItBefore = true;
        goto label_75;
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
