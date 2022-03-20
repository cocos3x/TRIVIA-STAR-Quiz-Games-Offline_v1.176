using UnityEngine;
public class RestaurantMasterEcon
{
    // Fields
    public RestaurantMasterRewardData rewardData;
    public int unlockPlayerLevel;
    
    // Methods
    public RestaurantMasterEcon(System.Collections.Generic.Dictionary<string, object> eventDataDict)
    {
        var val_10;
        var val_11;
        val_10 = 35629950;
        this.unlockPlayerLevel = 2;
        RestaurantMasterRewardData val_1 = RestaurantMasterEconDataHelper.ParseCSV();
        this.rewardData = this;
        if(eventDataDict == 0)
        {
                return;
        }
        
        val_11 = 1152921510392296080;
        val_10 = "economy";
        if((eventDataDict.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_3 = eventDataDict.Item[-1554533760];
        if(eventDataDict == 0)
        {
                return;
        }
        
        object val_4 = eventDataDict.Item[-1554533760];
        val_10 = 1;
        val_11 = "unlock_lvl";
        if((0.ContainsKey(key:  -1554533504)) == false)
        {
                return;
        }
        
        string val_6 = 0.Item[-1554533504];
        if(0 == 0)
        {
                return;
        }
        
        string val_7 = 0.Item[-1554533504];
        bool val_9 = System.Int32.TryParse(s:  null, result: out  int val_8 = -1063186932);
        if(val_9 == true)
        {
                val_9 = 0;
            this.unlockPlayerLevel = 0;
        }
    
    }
    public System.Collections.Generic.List<RESEventRewardData> GetRewardsList(int playerLevel)
    {
        if(this.rewardData != 0)
        {
                this.rewardData = this.rewardData.rewardList;
            goto label_1;
        }
        
        return;
        label_1:
        if((this.rewardData.ContainsKey(key:  playerLevel)) != false)
        {
                System.Collections.Generic.List<RESEventRewardData> val_2 = this.rewardData.rewardList.Item[playerLevel];
            if(this.rewardData.rewardList != 0)
        {
                return;
        }
        
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_3 = this.rewardData.rewardList.Keys;
        int val_5 = UnityEngine.Mathf.Min(a:  playerLevel, b:  System.Linq.Enumerable.Max(source:  this.rewardData.rewardList));
        if((this.rewardData.rewardList.ContainsKey(key:  val_5)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<RESEventRewardData> val_7 = this.rewardData.rewardList.Item[val_5];
    }

}
