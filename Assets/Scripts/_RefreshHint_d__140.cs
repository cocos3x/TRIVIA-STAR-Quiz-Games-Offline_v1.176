using UnityEngine;
private sealed class WPTGameUIController.<RefreshHint>d__140 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<RefreshHint>d__140(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WPTGameUIController.<RefreshHint>d__140 val_17;
        int val_18;
        WordPets.WPTGameUIController val_19;
        System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Vector2Int> val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_17 = this;
        val_18 = 0;
        val_19 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_18;
        }
        
        this.<>1__state = 0;
        this.<>4__this.processingPetAnimation = true;
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        val_20 = null;
        val_20 = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Vector2Int>();
        val_21 = 0;
        goto label_4;
        label_23:
        if(val_20 <= val_21)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_18 + 0;
        System.Collections.Generic.List<WordPets.WPTLetterTile> val_3 = (0 + 0) + 16.GetLetterTiles();
        val_22 = 4;
        goto label_8;
        label_20:
        if(((0 + 0) + 16) <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((0 + 0) + 16 + 8 + 16.IsSelectable()) != false)
        {
                if(((0 + 0) + 16 + 12) <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(((0 + 0) + 16 + 12) <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            Add(key:  (0 + 0) + 16 + 8 + 16.GetInstanceID(), value:  (0 + 0) + 16 + 8 + 16);
            if(((0 + 0) + 16 + 12) <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Vector2Int val_7 = new UnityEngine.Vector2Int(x:  0, y:  78753792);
            Add(key:  (0 + 0) + 16 + 8 + 16.GetInstanceID(), value:  new UnityEngine.Vector2Int() {m_X = val_7.m_X, m_Y = val_7.m_Y});
        }
        
        val_22 = 5;
        label_8:
        if((val_22 - 4) < ((0 + 0) + 16 + 12))
        {
            goto label_20;
        }
        
        val_19 = val_19;
        val_21 = 1;
        val_20 = val_20;
        label_4:
        if(val_21 < (this.<>4__this + 112 + 12))
        {
            goto label_23;
        }
        
        System.Collections.Generic.List<System.Char> val_10 = val_19.GetSolvableRandomLetters(qtyOfLetters:  Count, ignoreExistingGridLetters:  true);
        Dictionary.Enumerator<TKey, TValue> val_11 = val_7.m_X.GetEnumerator();
        val_23 = 0;
        val_24 = 16;
        goto label_26;
        label_36:
        UnityEngine.Vector2Int val_12 = val_7.m_X.Item[78753792];
        int val_13 = val_7.m_X.x;
        if((this.<>4__this + 112 + 12) <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_19 = this.<>4__this + 112 + 8;
        val_19 = val_19 + (val_13 << 2);
        if((this.<>4__this + 12) <= val_23)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        char val_20 = this.<>4__this + 8;
        val_20 = val_20 + val_24;
        (this.<>4__this + 112 + 8 + (val_13) << 2) + 16 + 20.ModifyTileLetter(tileIndex:  val_7.m_X.y, letter:  val_20);
        if((this.<>4__this + 12) <= val_23)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        char val_21 = this.<>4__this + 8;
        val_21 = val_21 + val_24;
        val_22.SwapChar(newChar:  val_21);
        val_20 = val_20;
        val_24 = 18;
        val_23 = 1;
        label_26:
        if(val_18.MoveNext() == true)
        {
            goto label_36;
        }
        
        val_18.Dispose();
        val_17 = val_17;
        val_18 = 1;
        this.<>1__state = val_18;
        mem[1152921513381886460] = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_18;
        label_1:
        this.<>1__state = 0;
        if(val_19 != 0)
        {
                this.<>4__this.processingPetAnimation = false;
        }
        else
        {
                mem[209] = 0;
        }
        
        if(val_19.CheckNoMoreWords() != false)
        {
                val_19.OnGameEnded(didPlayerWin:  false, loseCondition:  2);
        }
        
        val_19.DoPlayerTurnComplete();
        return (bool)val_18;
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
