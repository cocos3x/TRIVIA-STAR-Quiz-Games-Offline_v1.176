using UnityEngine;
private sealed class WPTGameUIController.<SubmitCoroutine>d__126 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<SubmitCoroutine>d__126(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        var val_5;
        System.Collections.Generic.List<WordPets.WPTLetterTile> val_6;
        object val_7;
        val_3 = 0;
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
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_4;
        }
        
        this.<>4__this.ClearCrateSpiderWeb();
        goto label_5;
        label_1:
        val_4 = 0;
        goto label_6;
        label_2:
        val_5 = 0;
        this.<>1__state = 0;
        goto label_7;
        label_13:
        if(0 <= val_5)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        (0 + 0) + 16.RefreshTiles(moveUp:  false);
        val_5 = 1;
        label_7:
        if(val_5 < ((0 + 0) + 16))
        {
            goto label_13;
        }
        
        val_6 = this.<>4__this.currentSelectedTiles;
        val_6.Clear();
        this.<>4__this.isValidWordSelected = false;
        System.Collections.IEnumerator val_1 = this.<>4__this.DoEndOfTurnGridResolution(decrementPetTimer:  false);
        val_7 = this.<>4__this;
        val_4 = 2;
        goto label_15;
        label_4:
        0.ClearCrateSpiderWeb();
        label_5:
        val_5 = 0;
        this.<>4__this.myDisplay.DeselectAllTiles();
        goto label_17;
        label_22:
        if((this.<>4__this.myDisplay) <= val_5)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        val_5 = 1;
        label_17:
        val_6 = this.<>4__this.currentSelectedTiles;
        if(val_5 < ((0 + 0) + 16))
        {
            goto label_22;
        }
        
        UnityEngine.WaitForSeconds val_2 = null;
        val_7 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_4 = 1;
        label_15:
        val_3 = 1;
        this.<>2__current = val_7;
        label_6:
        this.<>1__state = val_4;
        return (bool)val_3;
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
