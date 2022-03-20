using UnityEngine;
private sealed class RESRestaurantManager.<>c__DisplayClass52_0
{
    // Fields
    public int damagedTreeIdToFix;
    
    // Methods
    public RESRestaurantManager.<>c__DisplayClass52_0()
    {
    
    }
    internal bool <AddGrowth>b__0(RestaurantRivals.MapItem n)
    {
        if(n.id != this.damagedTreeIdToFix)
        {
                return (bool)0;
        }
        
        bool val_1 = System.String.op_Equality(a:  n.type, b:  -1402413584);
        if(val_1 == true)
        {
                val_1 = n.status;
            val_1 = val_1 - 2;
        }
        
        if(val_1 == true)
        {
                0 = val_1 >> 5;
        }
        
        return (bool)0;
    }

}
