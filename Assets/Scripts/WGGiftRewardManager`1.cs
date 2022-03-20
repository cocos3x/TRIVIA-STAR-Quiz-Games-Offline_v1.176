using UnityEngine;
public abstract class WGGiftRewardManager<T>
{
    // Fields
    private static T _instance;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_1 == 1)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 12];
            val_3 = __RuntimeMethodHiddenParam + 12;
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_4 == 1)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        }
        
        val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_5 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
        {
                return;
        }
    
    }
    public virtual void GenerateRewards()
    {
    
    }
    public virtual void CollectRewards()
    {
    
    }
    protected WGGiftRewardManager<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    private static WGGiftRewardManager<T>()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
        val_1 = __RuntimeMethodHiddenParam + 12 + 186;
        val_2 = __RuntimeMethodHiddenParam + 12;
        if(val_1 == 1)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12];
            val_2 = __RuntimeMethodHiddenParam + 12;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 8;
    }

}
