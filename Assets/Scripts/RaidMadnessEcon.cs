using UnityEngine;
public class RaidMadnessEcon
{
    // Fields
    public RaidMadnessRewardData rewardData;
    public int unlockPlayerLevel;
    public int pointsGainPerRaid;
    public float avgPointPerSpinTier1;
    public float avgPointPerSpinTier2;
    public float avgPointPerSpinTier3;
    
    // Methods
    public RaidMadnessEcon(System.Collections.Generic.Dictionary<string, object> eventDataDict)
    {
        var val_36;
        var val_37;
        val_36 = 35629860;
        val_37 = 15723;
        val_37 = 1030461975;
        this.unlockPlayerLevel = 5;
        RaidMadnessRewardData val_1 = RaidMadnessEconDataHelper.ParseCSV();
        this.rewardData = this;
        if(eventDataDict == 0)
        {
                return;
        }
        
        val_36 = "economy";
        if((eventDataDict.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        val_37 = 1152921510385703632;
        object val_3 = eventDataDict.Item[-1554533760];
        if(eventDataDict == 0)
        {
                return;
        }
        
        object val_4 = eventDataDict.Item[-1554533760];
        val_37 = 1;
        if((0.ContainsKey(key:  -1554533664)) != false)
        {
                string val_6 = 0.Item[-1554533664];
            if(0 != 0)
        {
                string val_7 = 0.Item[-1554533664];
            if((0.ContainsKey(key:  -1202791792)) != false)
        {
                string val_9 = 0.Item[-1202791792];
            if(0 != 0)
        {
                string val_10 = 0.Item[-1202791792];
            bool val_12 = System.Int32.TryParse(s:  null, result: out  int val_11 = -1078443912);
            if(val_12 == true)
        {
                val_12 = 0;
            this.pointsGainPerRaid = 0;
        }
        
        }
        
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  -1554533504)) != false)
        {
                string val_14 = 0.Item[-1554533504];
            if(0 != 0)
        {
                string val_15 = 0.Item[-1554533504];
            bool val_17 = System.Int32.TryParse(s:  null, result: out  int val_16 = -1078443916);
            if(val_17 == true)
        {
                val_17 = 0;
            this.unlockPlayerLevel = 0;
        }
        
        }
        
        }
        
        val_36 = "avg_pps";
        if((0.ContainsKey(key:  -1554533408)) == false)
        {
                return;
        }
        
        string val_19 = 0.Item[-1554533408];
        if(0 == 0)
        {
                return;
        }
        
        string val_20 = 0.Item[-1554533408];
        val_37 = 1;
        if((0.ContainsKey(key:  -1554533312)) != false)
        {
                string val_22 = 0.Item[-1554533312];
            if(0 != 0)
        {
                string val_23 = 0.Item[-1554533312];
            bool val_25 = System.Single.TryParse(s:  null, result: out  float val_24 = -1.439466f);
            if(val_25 == true)
        {
                val_25 = 0;
            this.avgPointPerSpinTier1 = 0f;
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  -1554533232)) != false)
        {
                string val_27 = 0.Item[-1554533232];
            if(0 != 0)
        {
                string val_28 = 0.Item[-1554533232];
            bool val_30 = System.Single.TryParse(s:  null, result: out  float val_29 = -1.439466f);
            if(val_30 == true)
        {
                val_30 = 0;
            this.avgPointPerSpinTier2 = 0f;
        }
        
        }
        
        }
        
        val_36 = "t3";
        if((0.ContainsKey(key:  -1554533152)) == false)
        {
                return;
        }
        
        string val_32 = 0.Item[-1554533152];
        if(0 == 0)
        {
                return;
        }
        
        string val_33 = 0.Item[-1554533152];
        bool val_35 = System.Single.TryParse(s:  null, result: out  float val_34 = -1.439466f);
        if(val_35 == true)
        {
                val_35 = 0;
            this.avgPointPerSpinTier3 = 0f;
        }
    
    }
    public float GetAveragePointPerSpinThreshold(int playerTier)
    {
        float val_1;
        float val_2;
        if(playerTier == 3)
        {
            goto label_0;
        }
        
        if(playerTier == 2)
        {
            goto label_1;
        }
        
        if(playerTier != 1)
        {
            goto label_2;
        }
        
        val_1 = this.avgPointPerSpinTier1;
        goto label_4;
        label_0:
        val_1 = this.avgPointPerSpinTier3;
        goto label_4;
        label_1:
        val_1 = this.avgPointPerSpinTier2;
        label_4:
        val_2 = mem[this.avgPointPerSpinTier2];
        val_2 = val_1;
        return val_2;
        label_2:
        val_2 = -1f;
        return val_2;
    }
    private System.Collections.Generic.List<RESEventRewardData> GetRewardsList(int playerTier)
    {
        if(playerTier < 1)
        {
                return;
        }
        
        int val_1 = playerTier;
        if(this < val_1)
        {
                return;
        }
        
        val_1 = val_1 - 1;
        0 = this.rewardData.rewardListTier[val_1];
    }
    private System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>> GetCoinsList(int playerTier)
    {
        if(playerTier < 1)
        {
                return;
        }
        
        int val_1 = playerTier;
        if(this < val_1)
        {
                return;
        }
        
        val_1 = val_1 - 1;
        0 = this.rewardData.coinValuesTiers[val_1];
    }
    public int GetTotalCollectableRewards(int playerTier)
    {
        System.Collections.Generic.List<RESEventRewardData> val_1 = this.GetRewardsList(playerTier:  playerTier);
        if(this == 0)
        {
                return 0;
        }
        
        System.Collections.Generic.List<RESEventRewardData> val_2 = this.GetRewardsList(playerTier:  playerTier);
        if(this != 0)
        {
                return (int)this.unlockPlayerLevel;
        }
        
        return (int)this.unlockPlayerLevel;
    }
    public RESEventRewardData GetFinalPrize(int playerTier)
    {
        var val_2;
        int val_3;
        var val_4;
        val_2 = 35629862;
        System.Collections.Generic.List<RESEventRewardData> val_1 = this.GetRewardsList(playerTier:  playerTier);
        if(this != 0)
        {
                val_3 = this.unlockPlayerLevel;
            val_4 = val_3;
        }
        else
        {
                val_2 = 12;
            val_4 = 0;
            val_3 = 0;
        }
        
        if(val_3 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        RaidMadnessRewardData val_2 = this.rewardData;
        val_2 = val_2 + 4294967292;
    }
    public decimal GetGrandPrizeSpinAmount(int playerTier)
    {
        RaidMadnessEcon val_4;
        var val_5;
        var val_6;
        int val_7;
        var val_8;
        RaidMadnessEcon val_9;
        var val_10;
        var val_11;
        System.Collections.Generic.List<RESEventRewardData> val_1 = playerTier.GetRewardsList(playerTier:  R2);
        val_8 = 4;
        val_9 = 0;
        val_10 = 0;
        val_11 = 0;
        goto label_1;
        label_10:
        if(0 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((playerTier + 8 + 16 + 8) == 2)
        {
                if((playerTier + 12) <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_2 = (playerTier + 8 + 16) + 20;
            decimal val_3 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1077415572}, d2:  new System.Decimal() {hi = playerTier + 8 + 16 + 16, lo = mem[(playerTier + 8 + 16 + 20) + (0)], mid = mem[(playerTier + 8 + 16 + 20) + (4)]});
            val_9 = val_4;
            val_10 = val_5;
            val_11 = val_6;
        }
        
        val_8 = 5;
        label_1:
        if((val_8 - 4) < (playerTier + 12))
        {
            goto label_10;
        }
        
        this = val_9;
        mem[1152921512119378052] = val_10;
        mem[1152921512119378056] = val_11;
        mem[1152921512119378060] = val_7;
        return new System.Decimal() {flags = -1077403520, hi = val_7, lo = val_3.lo, mid = val_3.mid};
    }
    public RESEventRewardData GetEventReward(int playerTier, int rewardProgressLevel)
    {
        System.Collections.Generic.List<RESEventRewardData> val_1 = this.GetRewardsList(playerTier:  playerTier);
        System.Collections.Generic.List<System.Collections.Generic.List<RESEventCoinValue>> val_2 = this.GetCoinsList(playerTier:  playerTier);
    }

}
