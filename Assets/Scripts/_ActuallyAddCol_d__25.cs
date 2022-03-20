using UnityEngine;
private sealed class WPTLevelEditorUI.<ActuallyAddCol>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.LevelEditor.WPTLevelEditorUI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTLevelEditorUI.<ActuallyAddCol>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        WordPets.WPTLevelData val_13;
        System.Collections.Generic.List<WordPets.ColData> val_14;
        WordPets.WPTLevelData val_15;
        WordPets.WPTLevelData val_16;
        val_12 = 0;
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
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        val_13 = this.<>4__this.<curData>k__BackingField;
        if(val_13 == 0)
        {
            goto label_5;
        }
        
        val_14 = this.<>4__this.<curData>k__BackingField.colData;
        goto label_6;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_12 = 1;
        this.<>1__state = 2;
        this.<>2__current = val_1;
        return (bool)val_12;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                this.<>4__this.RefreshRowButtons(delay:  null);
        }
        else
        {
                0.RefreshRowButtons(delay:  null);
        }
        
        this.<>4__this.CheckDiff();
        return (bool)val_12;
        label_5:
        val_14 = this.<>4__this.<curData>k__BackingField.colData;
        val_13 = this.<>4__this.<curData>k__BackingField;
        if(val_13 == 0)
        {
            goto label_11;
        }
        
        label_6:
        label_38:
        System.Collections.Generic.List<WordPets.ColData> val_12 = this.<>4__this.<curData>k__BackingField.colData;
        val_12 = val_12 - 1;
        if(val_13 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = R1 + (val_12 << 2);
        WordPets.ColData val_3 = new WordPets.ColData(copyData:  (R1 + ((this.<>4__this.<curData>k__BackingField.colData - 1)) << 2) + 16);
        val_14.Add(item:  398028800);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = this.<>4__this.<curData>k__BackingField;
        if((this.<>4__this.<curData>k__BackingField) != 0)
        {
            goto label_18;
        }
        
        val_15 = this.<>4__this.<curData>k__BackingField;
        if(val_15 == 0)
        {
            goto label_25;
        }
        
        label_18:
        System.Collections.Generic.List<WordPets.ColData> val_13 = this.<>4__this.<curData>k__BackingField.colData;
        val_13 = val_13 - 1;
        if(val_15 <= val_13)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + (val_13 << 2);
        WordPets.WPTGameColumn val_5 = AddNewCol(data:  (0 + ((this.<>4__this.<curData>k__BackingField.colData - 1)) << 2) + 16);
        System.Collections.Generic.List<System.Char> val_6 = new System.Collections.Generic.List<System.Char>();
        WordPets.WPTLevelData val_15 = this.<>4__this.<curData>k__BackingField;
        val_16 = val_15;
        if(val_15 != 0)
        {
            goto label_24;
        }
        
        val_16 = this.<>4__this.<curData>k__BackingField;
        if(val_16 == 0)
        {
            goto label_25;
        }
        
        label_24:
        val_15 = val_15 - 1;
        if(val_16 <= val_15)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (val_15 << 2);
        System.Char[] val_7 = (0 + ((this.<>4__this.<curData>k__BackingField - 1)) << 2) + 16 + 48.ToCharArray();
        AddRange(collection:  (0 + ((this.<>4__this.<curData>k__BackingField - 1)) << 2) + 16 + 48);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.Collections.IEnumerator val_11 = AddLettersToColumn(column:  (public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_70 + 8 + ((public static WordPets.WPTGameUIController MonoSingleton<WordPet + 16, characters:  80883712, isInitialPopulation:  false);
        val_12 = 1;
        this.<>1__state = val_12;
        this.<>2__current = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance();
        return (bool)val_12;
        label_11:
        if((this.<>4__this.<curData>k__BackingField) != 0)
        {
            goto label_38;
        }
        
        label_25:
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
