using UnityEngine;
[Serializable]
public class ConsumableAmountPair : SerializableKeyValuePair<string, System.Decimal>
{
    // Fields
    public int Scale;
    
    // Methods
    public ConsumableAmountPair(string key, decimal value, int scale = 1)
    {
        this.Scale = 1;
        mem[1152921511395485448] = key;
        mem[1152921511395485452] = value.flags;
        mem[1152921511395485456] = value.hi;
        mem[1152921511395485460] = value.lo;
        mem[1152921511395485464] = value.mid;
        this.Scale = scale;
    }

}
