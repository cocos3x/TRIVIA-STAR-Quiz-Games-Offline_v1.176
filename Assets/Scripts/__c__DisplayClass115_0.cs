using UnityEngine;
private sealed class WPTGameUIController.<>c__DisplayClass115_0
{
    // Fields
    public WordPets.WPTGameColumn column;
    
    // Methods
    public WPTGameUIController.<>c__DisplayClass115_0()
    {
    
    }
    internal bool <AddLettersToColumn>b__0(WordPets.ColData c)
    {
        int val_1 = this.column.<myData>k__BackingField.<Id>k__BackingField;
        val_1 = (c.<Id>k__BackingField) - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
