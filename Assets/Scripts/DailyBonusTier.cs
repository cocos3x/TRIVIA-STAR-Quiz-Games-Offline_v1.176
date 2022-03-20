using UnityEngine;
[Serializable]
public class DailyBonusTier : EncodableModel
{
    // Fields
    public string threshold;
    public System.Collections.Generic.List<object> rewards;
    
    // Methods
    public DailyBonusTier()
    {
    
    }
    public DailyBonusTier(string threshold, System.Collections.Generic.List<object> rewards)
    {
        this.threshold = threshold;
        this.rewards = rewards;
    }

}
