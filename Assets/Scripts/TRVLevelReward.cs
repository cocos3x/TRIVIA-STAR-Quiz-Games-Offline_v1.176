using UnityEngine;
public class TRVLevelReward
{
    // Fields
    private string <desc>k__BackingField;
    private int <value>k__BackingField;
    private TRVLevelReward.RewardType <rewardType>k__BackingField;
    private int <cardMulti>k__BackingField;
    
    // Properties
    public string desc { get; set; }
    public int value { get; set; }
    public TRVLevelReward.RewardType rewardType { get; set; }
    public int cardMulti { get; set; }
    
    // Methods
    public string get_desc()
    {
    
    }
    private void set_desc(string value)
    {
        this.<desc>k__BackingField = value;
    }
    public int get_value()
    {
        return (int)this.<value>k__BackingField;
    }
    private void set_value(int value)
    {
        this.<value>k__BackingField = value;
    }
    public TRVLevelReward.RewardType get_rewardType()
    {
    
    }
    private void set_rewardType(TRVLevelReward.RewardType value)
    {
        this.<rewardType>k__BackingField = value;
    }
    public int get_cardMulti()
    {
        return (int)this.<cardMulti>k__BackingField;
    }
    private void set_cardMulti(int value)
    {
        this.<cardMulti>k__BackingField = value;
    }
    public TRVLevelReward(string description, int rwvalue, TRVLevelReward.RewardType rwt, int multi = 0)
    {
        string val_1 = description;
        val_1 = new System.Object();
        this.<desc>k__BackingField = val_1;
        this.<value>k__BackingField = rwvalue;
        this.<rewardType>k__BackingField = rwt;
        this.<cardMulti>k__BackingField = multi;
    }

}
