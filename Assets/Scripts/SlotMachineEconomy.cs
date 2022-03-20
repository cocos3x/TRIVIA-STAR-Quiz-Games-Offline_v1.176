using UnityEngine;
public class SlotMachineEconomy
{
    // Fields
    private System.Collections.Generic.List<float> coinChance;
    private System.Collections.Generic.List<int> coinValue;
    private System.Collections.Generic.List<float> starChance;
    private System.Collections.Generic.List<int> starValue;
    
    // Methods
    public int GetCoinReward()
    {
        var val_3;
        var val_4;
        System.Collections.Generic.List<System.Single> val_5;
        var val_6;
        val_3 = 0;
        float val_1 = UnityEngine.Random.Range(min:  null, max:  null);
        uint val_5 = 0;
        val_4 = 16;
        goto label_1;
        label_8:
        val_5 = this.coinChance;
        if(0 <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + val_4;
        if(0 <= val_3)
        {
            goto label_4;
        }
        
        if(val_3 <= val_3)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = 1;
        val_4 = val_4 + val_4;
        val_4 = 20;
        val_5 = val_5 - val_4;
        label_1:
        val_5 = this.coinChance;
        if(val_3 < val_4)
        {
            goto label_8;
        }
        
        val_6 = 0;
        return (int)val_6;
        label_4:
        if(val_3 <= val_3)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        val_6 = mem[(0 + 0) + 16];
        val_6 = (0 + 0) + 16;
        if(val_3 > 8)
        {
                return (int)val_6;
        }
        
        val_6 = (UnityEngine.Random.Range(min:  0, max:  10)) + val_6;
        return (int)val_6;
    }
    public int GetStarReward()
    {
        var val_3;
        var val_4;
        System.Collections.Generic.List<System.Single> val_5;
        var val_6;
        val_3 = 0;
        float val_1 = UnityEngine.Random.Range(min:  null, max:  null);
        uint val_5 = 0;
        val_4 = 16;
        goto label_1;
        label_8:
        val_5 = this.starChance;
        if(0 <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + val_4;
        if(0 <= val_3)
        {
            goto label_4;
        }
        
        if(val_3 <= val_3)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = 1;
        val_4 = val_4 + val_4;
        val_4 = 20;
        val_5 = val_5 - val_4;
        label_1:
        val_5 = this.starChance;
        if(val_3 < val_4)
        {
            goto label_8;
        }
        
        val_6 = 0;
        return (int)val_6;
        label_4:
        if(val_3 <= val_3)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        val_6 = mem[(0 + 0) + 16];
        val_6 = (0 + 0) + 16;
        if(val_3 > 8)
        {
                return (int)val_6;
        }
        
        val_6 = (UnityEngine.Random.Range(min:  0, max:  10)) + val_6;
        return (int)val_6;
    }
    public void CheckEconomy()
    {
        float val_3;
        var val_4;
        var val_5;
        float val_6;
        val_3 = 0f;
        val_4 = 0;
        goto label_1;
        label_5:
        if(true <= val_4)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = 1;
        val_3 = val_3 + 16;
        val_3 = val_3 + val_3;
        label_1:
        if(val_4 < val_3)
        {
            goto label_5;
        }
        
        val_5 = 0;
        string val_1 = -1521041200(-1521041200) + 15282176;
        UnityEngine.Debug.LogError(message:  -1521041200);
        val_6 = 0f;
        goto label_8;
        label_12:
        if(("total coin chance: ") <= val_5)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = 1;
        val_4 = val_4 + 16;
        val_6 = val_6 + val_4;
        label_8:
        if(val_5 < val_4)
        {
            goto label_12;
        }
        
        string val_2 = -1521032896(-1521032896) + 15282176;
        UnityEngine.Debug.LogError(message:  -1521032896);
    }
    public SlotMachineEconomy()
    {
        var val_5;
        var val_6;
        System.Collections.Generic.List<System.Single> val_1 = new System.Collections.Generic.List<System.Single>();
        if(val_1 != 0)
        {
                Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
        }
        else
        {
                Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
        }
        
        Add(item:  null);
        this.coinChance = val_1;
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        if(val_2 != 0)
        {
                Add(item:  10);
            Add(item:  20);
            Add(item:  30);
            Add(item:  40);
            Add(item:  50);
            Add(item:  60);
            Add(item:  70);
            Add(item:  80);
            Add(item:  90);
            Add(item:  100);
            Add(item:  200);
            Add(item:  300);
            Add(item:  400);
            Add(item:  500);
            Add(item:  600);
            Add(item:  700);
            Add(item:  800);
        }
        else
        {
                Add(item:  10);
            Add(item:  20);
            Add(item:  30);
            Add(item:  40);
            Add(item:  50);
            Add(item:  60);
            Add(item:  70);
            Add(item:  80);
            Add(item:  90);
            Add(item:  100);
            Add(item:  200);
            Add(item:  300);
            Add(item:  400);
            Add(item:  500);
            Add(item:  600);
            Add(item:  700);
            Add(item:  800);
        }
        
        Add(item:  900);
        this.coinValue = val_2;
        System.Collections.Generic.List<System.Single> val_3 = new System.Collections.Generic.List<System.Single>();
        if(val_3 != 0)
        {
                Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            val_5 = 16624;
            val_5 = 1089470464;
            Add(item:  null);
            val_6 = 16648;
            val_6 = 1091043328;
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
        }
        else
        {
                Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            val_5 = 16624;
            val_5 = 1089470464;
            Add(item:  null);
            val_6 = 16648;
            val_6 = 1091043328;
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
            Add(item:  null);
        }
        
        Add(item:  null);
        this.starChance = val_3;
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
        if(val_4 != 0)
        {
                Add(item:  10);
            Add(item:  20);
            Add(item:  30);
            Add(item:  40);
            Add(item:  50);
            Add(item:  60);
            Add(item:  70);
            Add(item:  80);
            Add(item:  90);
            Add(item:  100);
            Add(item:  200);
            Add(item:  300);
            Add(item:  400);
            Add(item:  500);
            Add(item:  600);
            Add(item:  700);
            Add(item:  800);
        }
        else
        {
                Add(item:  10);
            Add(item:  20);
            Add(item:  30);
            Add(item:  40);
            Add(item:  50);
            Add(item:  60);
            Add(item:  70);
            Add(item:  80);
            Add(item:  90);
            Add(item:  100);
            Add(item:  200);
            Add(item:  300);
            Add(item:  400);
            Add(item:  500);
            Add(item:  600);
            Add(item:  700);
            Add(item:  800);
        }
        
        Add(item:  900);
        this.starValue = val_4;
    }

}
