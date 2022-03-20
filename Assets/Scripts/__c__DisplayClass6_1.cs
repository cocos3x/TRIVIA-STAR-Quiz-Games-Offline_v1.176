using UnityEngine;
private sealed class WADPetsFtuxPopup.<>c__DisplayClass6_1
{
    // Fields
    public int i;
    public WADPetsFtuxPopup.<>c__DisplayClass6_0 CS$<>8__locals1;
    
    // Methods
    public WADPetsFtuxPopup.<>c__DisplayClass6_1()
    {
    
    }
    internal bool <SetupFtux>b__0(WADPetsFtuxDisplay x)
    {
        if(true <= this.i)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (this.i << 2);
        var val_2 = (0 + (this.i) << 2) + 16 + 8 + 12;
        val_2 = x.PetAbility - val_2;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }

}
