using UnityEngine;
public class LetterBankTierRewardInfo
{
    // Fields
    public int tier;
    public LetterBankRewardChances coin_chances;
    public LetterBankRewardChances card_chances;
    public LetterBankRewardChances food_chances;
    public bool successfullyParsed;
    
    // Methods
    public LetterBankTierRewardInfo(System.Collections.Generic.Dictionary<string, object> chances)
    {
        object val_61;
        LetterBankRewardChances val_62;
        var val_63;
        var val_64;
        float val_65;
        val_61 = chances;
        this.coin_chances = new System.Object();
        this.card_chances = new System.Object();
        object val_3 = null;
        val_62 = val_3;
        val_3 = new System.Object();
        this.food_chances = val_62;
        val_61 = new System.Object();
        if((val_61.ContainsKey(key:  -1340676256)) != false)
        {
                object val_5 = val_61.Item[-1340676256];
            string val_6 = val_61.ToString();
            val_62 = val_61;
            bool val_8 = System.Int32.TryParse(s:  val_62, result: out  this.coin_chances.percent_chance);
        }
        
        if((val_61.ContainsKey(key:  -1340672080)) == false)
        {
            goto label_180;
        }
        
        object val_10 = val_61.Item[-1340672080];
        val_62 = 1152921504687730688;
        val_63 = 0;
        List.Enumerator<T> val_11 = GetEnumerator();
        val_64 = 0;
        val_65 = "ch";
        label_37:
        if(MoveNext() == false)
        {
            goto label_15;
        }
        
        if((0.ContainsKey(key:  -1340671984)) != false)
        {
                string val_15 = 0.Item[-1340671984];
            bool val_17 = System.Int32.TryParse(s:  null, result: out  int val_16 = -1340528460);
        }
        
        if((0.ContainsKey(key:  -1340671904)) != false)
        {
                string val_19 = 0.Item[-1340671904];
            bool val_21 = System.Int32.TryParse(s:  null, result: out  int val_20 = -1340528464);
        }
        
        if(val_64 >= 1)
        {
                val_64 = val_64;
        }
        
        if(val_64 < 1)
        {
            goto label_37;
        }
        
        if(this.coin_chances.reward_amounts == 0)
        {
                System.Collections.Generic.List<System.Int32> val_22 = new System.Collections.Generic.List<System.Int32>();
            this.coin_chances.reward_amounts = null;
        }
        
        if(this.coin_chances.reward_amounts_chances == 0)
        {
                System.Collections.Generic.List<System.Int32> val_23 = new System.Collections.Generic.List<System.Int32>();
            this.coin_chances.reward_amounts_chances = null;
        }
        
        this.coin_chances.reward_amounts.Add(item:  0);
        this.coin_chances.reward_amounts_chances.Add(item:  0);
        goto label_37;
        label_15:
        Dispose();
        val_61 = val_61;
        label_180:
        if((val_61.ContainsKey(key:  -1340630864)) != false)
        {
                string val_25 = val_61.Item[-1340630864];
            val_62 = val_61;
            bool val_27 = System.Int32.TryParse(s:  val_62, result: out  this.card_chances.percent_chance);
        }
        
        if((val_61.ContainsKey(key:  -1340626688)) == false)
        {
            goto label_177;
        }
        
        string val_29 = val_61.Item[-1340626688];
        val_62 = 1152921504687730688;
        val_63 = 0;
        List.Enumerator<T> val_30 = GetEnumerator();
        val_64 = 0;
        val_65 = "amt";
        label_75:
        if(MoveNext() == false)
        {
            goto label_53;
        }
        
        if((0.ContainsKey(key:  -1340671984)) != false)
        {
                string val_33 = 0.Item[-1340671984];
            bool val_35 = System.Int32.TryParse(s:  null, result: out  int val_34 = -1340528468);
        }
        
        if((0.ContainsKey(key:  -1340671904)) != false)
        {
                string val_37 = 0.Item[-1340671904];
            bool val_39 = System.Int32.TryParse(s:  null, result: out  int val_38 = -1340528472);
        }
        
        if(val_64 >= 1)
        {
                val_64 = val_64;
        }
        
        if(val_64 < 1)
        {
            goto label_75;
        }
        
        if(this.card_chances.reward_amounts == 0)
        {
                System.Collections.Generic.List<System.Int32> val_40 = new System.Collections.Generic.List<System.Int32>();
            this.card_chances.reward_amounts = null;
        }
        
        if(this.card_chances.reward_amounts_chances == 0)
        {
                System.Collections.Generic.List<System.Int32> val_41 = new System.Collections.Generic.List<System.Int32>();
            this.card_chances.reward_amounts_chances = null;
        }
        
        this.card_chances.reward_amounts.Add(item:  0);
        this.card_chances.reward_amounts_chances.Add(item:  0);
        goto label_75;
        label_53:
        Dispose();
        val_61 = val_61;
        label_177:
        if((val_61.ContainsKey(key:  -1340585632)) != false)
        {
                string val_43 = val_61.Item[-1340585632];
            val_62 = val_61;
            bool val_45 = System.Int32.TryParse(s:  val_62, result: out  this.food_chances.percent_chance);
        }
        
        if((val_61.ContainsKey(key:  -1340581456)) == false)
        {
            goto label_174;
        }
        
        string val_47 = val_61.Item[-1340581456];
        val_63 = 1152921504687730688;
        val_62 = 0;
        List.Enumerator<T> val_48 = GetEnumerator();
        val_64 = 0;
        val_65 = "amt";
        val_61 = "ch";
        label_113:
        if(MoveNext() == false)
        {
            goto label_91;
        }
        
        if((0.ContainsKey(key:  -1340671984)) != false)
        {
                string val_51 = 0.Item[-1340671984];
            bool val_53 = System.Int32.TryParse(s:  null, result: out  int val_52 = -1340528476);
        }
        
        if((0.ContainsKey(key:  -1340671904)) != false)
        {
                string val_55 = 0.Item[-1340671904];
            bool val_57 = System.Int32.TryParse(s:  null, result: out  int val_56 = -1340528480);
        }
        
        if(val_64 >= 1)
        {
                val_64 = val_64;
        }
        
        if(val_64 < 1)
        {
            goto label_113;
        }
        
        if(this.food_chances.reward_amounts == 0)
        {
                System.Collections.Generic.List<System.Int32> val_58 = new System.Collections.Generic.List<System.Int32>();
            this.food_chances.reward_amounts = null;
        }
        
        if(this.food_chances.reward_amounts_chances == 0)
        {
                System.Collections.Generic.List<System.Int32> val_59 = new System.Collections.Generic.List<System.Int32>();
            this.food_chances.reward_amounts_chances = null;
        }
        
        this.food_chances.reward_amounts.Add(item:  0);
        this.food_chances.reward_amounts_chances.Add(item:  0);
        goto label_113;
        label_91:
        Dispose();
        label_174:
        this.successfullyParsed = true;
    }
    public System.Collections.Generic.List<GiftReward> RollRewards()
    {
        var val_17;
        var val_18;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((UnityEngine.Random.Range(min:  0, max:  100)) < this.coin_chances.percent_chance)
        {
                RandomSet val_3 = new RandomSet();
            typeof(RandomSet).__il2cppRuntimeField_8 = 0;
            if(val_3 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            add(item:  2621443, weight:  2621443f);
            if(val_3 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            add(item:  1, weight:  1f);
            if(val_3 <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            add(item:  0, weight:  0f);
            WADGiftRewardManager val_5 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
            val_17 = public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance();
            System.Collections.Generic.List<GiftReward> val_6 = MakeRewards(rewardType:  0, rewardAmount:  roll(unweighted:  false));
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            Add(item:  public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance().__il2cppRuntimeField_8 + 16);
        }
        
        if((UnityEngine.Random.Range(min:  0, max:  100)) < this.card_chances.percent_chance)
        {
                RandomSet val_8 = new RandomSet();
            typeof(RandomSet).__il2cppRuntimeField_8 = 0;
            if(val_8 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            add(item:  2621443, weight:  2621443f);
            if(val_8 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            add(item:  1, weight:  1f);
            WADGiftRewardManager val_10 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
            val_17 = public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance();
            System.Collections.Generic.List<GiftReward> val_11 = MakeRewards(rewardType:  3, rewardAmount:  roll(unweighted:  false));
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            Add(item:  public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance().__il2cppRuntimeField_8 + 16);
        }
        
        val_18 = UnityEngine.Random.Range(min:  0, max:  100);
        if(val_18 >= this.food_chances.percent_chance)
        {
                return;
        }
        
        RandomSet val_13 = new RandomSet();
        typeof(RandomSet).__il2cppRuntimeField_8 = 0;
        if(val_13 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = 2621443;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        add(item:  2621443, weight:  2621443f);
        if(val_13 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        add(item:  1, weight:  1f);
        WADGiftRewardManager val_15 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
        val_18 = public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance();
        System.Collections.Generic.List<GiftReward> val_16 = MakeRewards(rewardType:  1, rewardAmount:  roll(unweighted:  false));
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        Add(item:  public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance().__il2cppRuntimeField_8 + 16);
    }

}
