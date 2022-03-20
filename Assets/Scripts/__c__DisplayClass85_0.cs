using UnityEngine;
private sealed class CategoryPacksManager.<>c__DisplayClass85_0
{
    // Fields
    public CategoryColorCode colorCode;
    
    // Methods
    public CategoryPacksManager.<>c__DisplayClass85_0()
    {
    
    }
    internal bool <GetColor>b__0(CategoryColor x)
    {
        CategoryColorCode val_1 = this.colorCode;
        val_1 = x.colorType - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
