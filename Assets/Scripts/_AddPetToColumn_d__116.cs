using UnityEngine;
private sealed class WPTGameUIController.<AddPetToColumn>d__116 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WordPetType petType;
    public WordPets.WPTGameUIController <>4__this;
    public WordPets.WPTGameColumn column;
    public int petMoveTimer;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<AddPetToColumn>d__116(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        object val_12;
        var val_13;
        if((this.<>1__state) != 1)
        {
                val_11 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
            this.<>1__state = 0;
            val_11 = 0;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(402341888)});
            val_12 = null;
            val_13 = null;
            if((System.Enum.IsDefined(enumType:  402341888, value:  402341888)) == false)
        {
                return (bool)val_11;
        }
        
            UnityEngine.WaitForSeconds val_3 = null;
            val_12 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_11 = 1;
            this.<>1__state = val_11;
            this.<>2__current = val_12;
            return (bool)val_11;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_4 = this.column.transform;
        object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.WPTPetTile, parent:  this.column);
        object val_6 = this.<>4__this.WPTPetTile.GetComponent<System.Object>();
        this.column.AddTile(newTile:  this.<>4__this.WPTPetTile, dontUpdateData:  false);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WordPet val_8 = GetPet(petType:  this.petType);
        val_12 = public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance();
        this.<>4__this.WPTPetTile.DisplayPet(thisPet:  121280000, moveCounter:  this.petMoveTimer);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector2 val_10 = CurrentTileSize;
        val_11 = 0;
        return (bool)val_11;
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
