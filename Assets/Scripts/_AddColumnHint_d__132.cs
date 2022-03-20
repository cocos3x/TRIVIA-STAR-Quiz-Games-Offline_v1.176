using UnityEngine;
private sealed class WPTGameUIController.<AddColumnHint>d__132 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<AddColumnHint>d__132(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WPTGameUIController.<AddColumnHint>d__132 val_19;
        int val_20;
        WordPets.WPTGameUIController val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        int val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_19 = this;
        val_20 = 0;
        val_21 = this.<>4__this;
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
                return (bool)val_20;
        }
        
        this.<>1__state = 0;
        if(val_21 == 0)
        {
            goto label_4;
        }
        
        this.<>4__this.processingPetAnimation = true;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        if(val_21 == 0)
        {
            goto label_6;
        }
        
        this.<>4__this.processingPetAnimation = false;
        goto label_7;
        label_2:
        this.<>1__state = 0;
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        if(0 == 0)
        {
            goto label_8;
        }
        
        val_22 = 0;
        val_23 = 132;
        goto label_9;
        label_4:
        mem[209] = 1;
        label_5:
        bool val_3 = val_21.HasEmptiedColumns(colIndexesEmptied: out  System.Collections.Generic.List<System.Int32> val_2 = 183553256);
        if((val_3 != false) && (0 >= 1))
        {
                int val_4 = UnityEngine.Random.Range(min:  0, max:  0);
            if(0 <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_20 = 0;
            val_20 = val_20 + (val_4 << 2);
            if(val_20 <= ((0 + (val_4) << 2) + 16))
        {
                var val_21 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_21 = val_21 + (((0 + (val_4) << 2) + 16) << 2);
            UnityEngine.GameObject val_5 = (0 + ((0 + (val_4) << 2) + 16) << 2) + 16.gameObject;
            UnityEngine.Object.Destroy(obj:  (0 + ((0 + (val_4) << 2) + 16) << 2) + 16);
            this.<>4__this.<currentColumns>k__BackingField.RemoveAt(index:  (0 + (val_4) << 2) + 16);
            val_24 = val_21;
            this.<>4__this.<currentData>k__BackingField.colData.RemoveAt(index:  (0 + (val_4) << 2) + 16);
        }
        else
        {
                val_24 = val_21;
        }
        
        val_25 = 0;
        val_26 = 0;
        goto label_27;
        label_36:
        if((this.<>4__this + 196 + 8 + 12) <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = this.<>4__this + 196 + 8 + 8;
        val_22 = val_22 + 0;
        val_25 = 1;
        val_26 = UnityEngine.Mathf.Max(a:  0, b:  (this.<>4__this + 196 + 8 + 8 + 0) + 16 + 12);
        label_27:
        if(val_25 < (this.<>4__this + 196 + 8 + 12))
        {
            goto label_36;
        }
        
        val_27 = 0;
        System.Collections.Generic.List<System.Char> val_7 = val_21.GetSolvableRandomLetters(qtyOfLetters:  val_26, ignoreExistingGridLetters:  false);
        goto label_37;
        label_41:
        if(new System.Text.StringBuilder() <= val_27)
        {
                char val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_23 = val_23 + 16;
        System.Text.StringBuilder val_9 = Append(value:  val_23);
        val_27 = 1;
        label_37:
        if(val_27 < (this.<>4__this.WPTColumn))
        {
            goto label_41;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_21 = 1152921510535002416;
        Add(key:  149070464, value:  13152256);
        Add(key:  151046544, value:  24121344);
        WordPets.ColData val_11 = new WordPets.ColData(columnId:  val_3, myData:  78753792);
        val_19 = val_21;
        this.<>4__this + 196.AddColumn(newColData:  398028800);
        WordPets.WPTGameColumn val_12 = val_19.AddNewCol(data:  398028800);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Recalculate();
        val_20 = 1;
        System.Collections.IEnumerator val_14 = val_19.AddLettersToColumn(column:  val_19, characters:  val_21, isInitialPopulation:  true);
        this.<>1__state = val_20;
        mem[1152921513380346876] = val_19;
        return (bool)val_20;
        label_6:
        mem[209] = 0;
        label_7:
        if(val_21.CheckNoMoreWords() != false)
        {
                val_21.OnGameEnded(didPlayerWin:  false, loseCondition:  2);
        }
        
        val_21.DoPlayerTurnComplete();
        return (bool)val_20;
        label_8:
        val_22 = 312;
        val_23 = 132;
        label_9:
        mem[312] = 133;
        WordPets.WPTPlayer val_16 = WordPets.WPTPlayer.Instance;
        if(133 != 0)
        {
                val_28 = 133;
            val_29 = 0;
        }
        else
        {
                val_28 = 300;
            val_29 = 6;
        }
        
        mem[300] = 7;
        WordPets.WPTPlayer val_17 = WordPets.WPTPlayer.Instance;
        if(7 != 0)
        {
                val_30 = 7;
            val_31 = 0;
        }
        else
        {
                val_30 = 296;
            val_31 = 1030672;
        }
        
        mem[296] = val_31 + 1;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        val_20 = 1;
        return (bool)val_20;
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
