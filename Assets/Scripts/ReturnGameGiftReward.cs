using UnityEngine;
public class ReturnGameGiftReward
{
    // Fields
    private int <tier>k__BackingField;
    private decimal <coins>k__BackingField;
    private decimal <spins>k__BackingField;
    
    // Properties
    public int tier { get; set; }
    public decimal coins { get; set; }
    public decimal spins { get; set; }
    
    // Methods
    public int get_tier()
    {
        return (int)this.<tier>k__BackingField;
    }
    private void set_tier(int value)
    {
        this.<tier>k__BackingField = value;
    }
    public decimal get_coins()
    {
        return new System.Decimal() {flags = -212056048, hi = R1 + 12};
    }
    private void set_coins(decimal value)
    {
    
    }
    public decimal get_spins()
    {
        return new System.Decimal() {flags = -211832048, hi = R1 + 28};
    }
    private void set_spins(decimal value)
    {
    
    }
    public ReturnGameGiftReward()
    {
        var val_1;
        this.<tier>k__BackingField = 1;
        val_1 = null;
        val_1 = null;
    }
    public ReturnGameGiftReward(int _tier, decimal _coins, decimal _spins)
    {
        this.<tier>k__BackingField = _tier;
        this.<coins>k__BackingField = _coins;
        mem[1152921512985285536] = _coins.hi;
        mem[1152921512985285540] = _coins.lo;
        mem[1152921512985285544] = _coins.mid;
    }

}
