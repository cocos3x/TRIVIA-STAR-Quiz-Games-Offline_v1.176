using UnityEngine;
[Serializable]
public class SeasonPassEcon.Tier
{
    // Fields
    public SeasonPassEcon.Item PassItem;
    public int AwardPass;
    public SeasonPassEcon.Item FreeItem;
    public int AwardFree;
    
    // Methods
    public bool IsTierChest(bool isPass)
    {
        if(isPass == true)
        {
                16 = 8;
        }
        
        SeasonPassEcon.Item val_1 = this.PassItem;
        val_1 = val_1 - 5;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public SeasonPassEcon.Tier()
    {
    
    }

}
