using UnityEngine;
private sealed class Just2EmojisUIController.<DelayedReturn>d__51 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.Just2Emojis.Just2EmojisUIController <>4__this;
    public int index;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Just2EmojisUIController.<DelayedReturn>d__51(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Just2EmojisUIController.<DelayedReturn>d__51 val_6;
        int val_7;
        int val_8;
        int val_9;
        var val_10;
        val_6 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return val_7;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.shouldDisable = true;
        goto label_4;
        label_1:
        val_8 = this.<i>5__2;
        this.<>1__state = 0;
        goto label_11;
        label_3:
        mem[160] = 1;
        label_4:
        val_8 = val_6;
        val_9 = 160 - 1;
        this.<i>5__2 = val_9;
        goto label_7;
        label_39:
        if(160 <= (this.<i>5__2))
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + ((this.<i>5__2) << 2);
        if(((0 + ((160 - 1)) << 2) + 16 + 28) != 0)
        {
            goto label_11;
        }
        
        if(((0 + ((160 - 1)) << 2) + 16 + 28) <= (this.<i>5__2))
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + ((this.<i>5__2) << 2);
        if(val_7 <= (this.<i>5__2))
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + ((this.<i>5__2) << 2);
        (0 + ((160 - 1)) << 2) + 16.Empty();
        if(((0 + ((160 - 1)) << 2) + 16) <= (this.<i>5__2))
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + ((this.<i>5__2) << 2);
        (0 + ((160 - 1)) << 2) + 16 + 24.sprite = this.<>4__this.answerEmptySprite;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static SLC.Minigames.Just2Emojis.Just2EmojisManager MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>::get_Instance();
        ClearCurrentAnswerChar(index:  this.<i>5__2);
        val_6 = this.<>4__this.letters;
        var val_10 = 0;
        label_30:
        if(val_10 >= val_10)
        {
            goto label_26;
        }
        
        bool val_2 = System.String.op_Equality(a:  SLC.Minigames.Just2Emojis.Just2EmojisItem[].__il2cppRuntimeField_byval_arg, b:  (0 + ((160 - 1)) << 2) + 16 + 12);
        val_10 = val_10 + 1;
        goto label_30;
        label_26:
        val_6 = val_6;
        label_11:
        val_9 = (this.<i>5__2) - 1;
        this.<i>5__2 = val_9;
        label_7:
        if(val_9 >= mem[1152921514246593684])
        {
            goto label_39;
        }
        
        val_7 = false;
        this.<>4__this.shouldDisable = val_7;
        return val_7;
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
