using UnityEngine;
private sealed class TRVLevelComplete.<>c__DisplayClass83_1
{
    // Fields
    public int overrideValue;
    
    // Methods
    public TRVLevelComplete.<>c__DisplayClass83_1()
    {
    
    }
    internal bool <MultiplierPicked>b__1(System.Collections.Generic.KeyValuePair<TRVPickerGameButton, int> x)
    {
        int val_1 = this.overrideValue;
        val_1 = R2 - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
