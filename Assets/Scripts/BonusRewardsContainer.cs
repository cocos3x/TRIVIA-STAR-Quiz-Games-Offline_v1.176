using UnityEngine;
public class BonusRewardsContainer
{
    // Fields
    private int <level>k__BackingField;
    private int <pointReq>k__BackingField;
    private int <bonusGoldenCurrencyEarnedPercent>k__BackingField;
    private int <bonusGemsEarnedPercent>k__BackingField;
    private int <bonusCoinsEarnedPercent>k__BackingField;
    
    // Properties
    public int level { get; set; }
    public int pointReq { get; set; }
    public int bonusGoldenCurrencyEarnedPercent { get; set; }
    public int bonusGemsEarnedPercent { get; set; }
    public int bonusCoinsEarnedPercent { get; set; }
    
    // Methods
    public int get_level()
    {
        return (int)this.<level>k__BackingField;
    }
    private void set_level(int value)
    {
        this.<level>k__BackingField = value;
    }
    public int get_pointReq()
    {
        return (int)this.<pointReq>k__BackingField;
    }
    private void set_pointReq(int value)
    {
        this.<pointReq>k__BackingField = value;
    }
    public int get_bonusGoldenCurrencyEarnedPercent()
    {
        return (int)this.<bonusGoldenCurrencyEarnedPercent>k__BackingField;
    }
    private void set_bonusGoldenCurrencyEarnedPercent(int value)
    {
        this.<bonusGoldenCurrencyEarnedPercent>k__BackingField = value;
    }
    public int get_bonusGemsEarnedPercent()
    {
        return (int)this.<bonusGemsEarnedPercent>k__BackingField;
    }
    private void set_bonusGemsEarnedPercent(int value)
    {
        this.<bonusGemsEarnedPercent>k__BackingField = value;
    }
    public int get_bonusCoinsEarnedPercent()
    {
        return (int)this.<bonusCoinsEarnedPercent>k__BackingField;
    }
    private void set_bonusCoinsEarnedPercent(int value)
    {
        this.<bonusCoinsEarnedPercent>k__BackingField = value;
    }
    public BonusRewardsContainer(int lvl, int ptrq, int bonusGC, int bonusGems, int bonusCoins)
    {
        this.<level>k__BackingField = lvl;
        this.<pointReq>k__BackingField = ptrq;
        this.<bonusGoldenCurrencyEarnedPercent>k__BackingField = bonusGC;
        this.<bonusGemsEarnedPercent>k__BackingField = bonusGems;
        this.<bonusCoinsEarnedPercent>k__BackingField = bonusCoins;
    }

}
