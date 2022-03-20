using UnityEngine;
private sealed class Alphabet2Manager.<>c__DisplayClass132_0
{
    // Fields
    public Alphabet2Manager <>4__this;
    public Alphabet2Manager.Rarity rarity;
    
    // Methods
    public Alphabet2Manager.<>c__DisplayClass132_0()
    {
    
    }
    internal bool <RollLettersForRarity>b__0(System.Collections.Generic.KeyValuePair<string, float> kvp)
    {
        var val_4;
        object val_1 = new System.Object();
        typeof(Alphabet2Manager.<>c__DisplayClass132_1).__il2cppRuntimeField_C = R2;
        typeof(Alphabet2Manager.<>c__DisplayClass132_1).__il2cppRuntimeField_8 = kvp.Value;
        val_4 = 0;
        if((this.<>4__this) >= 0)
        {
                val_4 = 1;
            if((this.<>4__this) >= 0)
        {
                if((this.<>4__this) < 0)
        {
                val_4 = 2;
        }
        
        }
        
        }
        
        if(2 != this.rarity)
        {
                return false;
        }
        
        System.Collections.Generic.List<System.String> val_2 = this.<>4__this.GetCurrentCollection;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_3 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  306442240, method:  new IntPtr(2716090240));
        return System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  this.<>4__this, predicate:  7720960);
    }

}
