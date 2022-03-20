using UnityEngine;
public class GiftRewardTier : DailyBonusTier
{
    // Fields
    public string threshold;
    public System.Collections.Generic.List<object> rewards;
    
    // Methods
    public GiftRewardTier()
    {
    
    }
    public GiftRewardTier(string threshold, System.Collections.Generic.List<object> rewards)
    {
        this.threshold = threshold;
        this.rewards = rewards;
    }
    public override string ToString()
    {
        string val_1 = PrettyPrint.printJSON(obj:  this.rewards, types:  false, singleLineOutput:  false);
        return System.String.Format(format:  -313438864, arg0:  this.threshold, arg1:  this.rewards);
    }

}
