using UnityEngine;
private sealed class WPTGameUIController.<CheckAddPets>d__156 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    private int <currentPets>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<CheckAddPets>d__156(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        int val_9;
        var val_10;
        int val_11;
        int val_12;
        WordPets.WPTLevelData val_13;
        var val_14;
        float val_15;
        object val_16;
        val_8 = 0;
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
                return (bool)val_8;
        }
        
        val_9 = 0;
        val_10 = this;
        this.<currentPets>5__2 = val_9;
        this.<>1__state = 0;
        goto label_4;
        label_10:
        if(0 <= val_9)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + 0;
        bool val_1 = (0 + 0) + 16.HasPet();
        val_9 = 1;
        if(val_1 == true)
        {
                val_1 = this.<currentPets>5__2;
            val_1 = 1;
            mem[1152921513386156932] = val_1;
        }
        
        label_4:
        if(val_9 < val_1)
        {
            goto label_10;
        }
        
        val_11 = mem[1152921513386156932];
        goto label_13;
        label_1:
        val_12 = 0;
        goto label_12;
        label_2:
        val_10 = this;
        val_11 = this.<currentPets>5__2;
        this.<>1__state = 0;
        label_13:
        val_13 = this.<>4__this.<currentData>k__BackingField;
        if(val_11 >= (this.<>4__this.<currentData>k__BackingField.<totalInitialPets>k__BackingField))
        {
            goto label_18;
        }
        
        val_11 = this.<>4__this.gamemode.petsSpawnList;
        if((this.<>4__this.<currentData>k__BackingField.<totalInitialPets>k__BackingField) <= 0)
        {
            goto label_18;
        }
        
        val_14 = 0;
        val_11 = 4;
        val_15 = 0;
        this.<currentPets>5__2 = 2;
        goto label_19;
        label_40:
        if(2 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        bool val_2 = 2621443.HasPet();
        if(val_2 != true)
        {
                if(val_2 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((this.<>4__this.inFTUX) != true)
        {
                int val_3 = UnityEngine.Random.Range(min:  0, max:  2);
            if(val_3 <= 0)
        {
                if(val_3 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = 3.673424E-39f;
            int val_4 = val_15.GetLetterHeight();
            val_14 = val_4;
        }
        
        }
        
        }
        
        val_11 = 5;
        label_19:
        if((val_11 - 4) < val_4)
        {
            goto label_40;
        }
        
        if((this.<>4__this.<currentData>k__BackingField.<level>k__BackingField) <= 1)
        {
                if((this.<>4__this.<currentData>k__BackingField.<level>k__BackingField) <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = 0f;
        }
        
        val_13 = this.<>4__this.gamemode;
        WordPets.WordPet val_6 = val_13.GetNextPet();
        System.Collections.IEnumerator val_7 = this.<>4__this.AddPetToColumn(column:  0, petType:  this.<>4__this.gamemode.petsCapturedList, petMoveTimer:  0);
        val_16 = this.<>4__this;
        val_12 = 1;
        goto label_47;
        label_18:
        this.<>4__this.UpdateTileRefillStatus(suppressOnscreenMessage:  false);
        UnityEngine.WaitForSeconds val_8 = null;
        val_16 = val_8;
        val_8 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_12 = 2;
        label_47:
        val_8 = 1;
        this.<>2__current = val_16;
        label_12:
        this.<>1__state = val_12;
        return (bool)val_8;
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
