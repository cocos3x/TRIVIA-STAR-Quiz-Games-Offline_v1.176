using UnityEngine;
private sealed class WADPetsFtuxPopup.<>c__DisplayClass6_2
{
    // Fields
    public int nextPetIndex;
    public WADPetsFtuxPopup.<>c__DisplayClass6_1 CS$<>8__locals2;
    
    // Methods
    public WADPetsFtuxPopup.<>c__DisplayClass6_2()
    {
    
    }
    internal void <SetupFtux>b__1()
    {
        if(true <= this.nextPetIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (this.nextPetIndex << 2);
        this.CS$<>8__locals2.CS$<>8__locals1.<>4__this.ShowFtux(pet:  (0 + (this.nextPetIndex) << 2) + 16);
    }

}
