using UnityEngine;
public class PurchaseModel : JsonSerializable<PurchaseModel>
{
    // Fields
    private string <Sku>k__BackingField;
    private string id;
    private bool vipApplied;
    private decimal vipAddedCredits;
    private decimal vipAddedGems;
    private decimal vipAddedGoldenCurrency;
    private int vipLevel;
    private int vipContribution;
    private int vipFriendsGiftAmount;
    private bool clubsApplied;
    private int clubsContribution;
    private string price;
    private float sale_price;
    private float targetSalePrice;
    private int trackerPurchasePoint;
    private string ltoModifier;
    private string extraInfo;
    private int purchaseScale;
    private int defaultPackage;
    private string promoType;
    private bool isSubscription;
    private System.Collections.Generic.List<PurchaseCommands> PurchaseInstructions;
    private System.Collections.Generic.Dictionary<string, object> _PurchaseTrackingInfo;
    private System.Collections.Generic.Dictionary<string, System.Decimal> rewards;
    private bool <isPromoActivated>k__BackingField;
    private string <originalPrice>k__BackingField;
    public PurchaseUserInfo PrePurchaseUserInfo;
    
    // Properties
    public string Sku { get; set; }
    public System.Collections.Generic.Dictionary<string, object> PurchaseTrackingInfo { get; }
    public decimal Credits { get; }
    public decimal Gems { get; }
    public decimal PetsFood { get; }
    public decimal PetCards { get; }
    public decimal DiceRolls { get; }
    public decimal GoldenCurrency { get; }
    public decimal Keys { get; }
    public decimal Spins { get; }
    public string InternalId { get; set; }
    public bool VipApplied { get; set; }
    public decimal VipAddedCredits { get; set; }
    public decimal VipAddedGems { get; set; }
    public decimal VipAddedGoldenCurrency { get; set; }
    public int VipLevel { get; set; }
    public int VipContribution { get; set; }
    public int VipFriendsGiftAmount { get; set; }
    public bool ClubsApplied { get; set; }
    public int ClubsContribution { get; set; }
    public string LocalPrice { get; set; }
    public float SalePrice { get; set; }
    public int DefaultPackage { get; set; }
    public int PurchaseScale { get; }
    public float TargetSalePrice { get; set; }
    public TrackerPurchasePoints TrackerPurchasePoint { get; set; }
    public string LTOModifier { get; set; }
    public string ExtraInfo { get; set; }
    public string PromoType { get; set; }
    public bool isPromoActivated { get; set; }
    public string originalPrice { get; set; }
    public bool IsSubscription { get; set; }
    public decimal VipAddedAmount { get; }
    
    // Methods
    public string get_Sku()
    {
    
    }
    public void set_Sku(string value)
    {
        this.<Sku>k__BackingField = value;
    }
    public System.Collections.Generic.Dictionary<string, object> get_PurchaseTrackingInfo()
    {
    
    }
    public decimal get_Credits()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  2129282688)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public decimal get_Gems()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  -1930648496)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public decimal get_PetsFood()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  -1827757824)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public decimal get_PetCards()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  -1825935216)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public decimal get_DiceRolls()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  -1825935120)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public decimal get_GoldenCurrency()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  -1825935328)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public decimal get_Keys()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  -1799947264)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public decimal get_Spins()
    {
        var val_3;
        if((R1 + 136.ContainsKey(key:  -1987367328)) != false)
        {
                decimal val_2 = this.Item[R1 + 136];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public string get_InternalId()
    {
    
    }
    public void set_InternalId(string value)
    {
        this.id = value;
    }
    public bool get_VipApplied()
    {
        return (bool)this.vipApplied;
    }
    public void set_VipApplied(bool value)
    {
        this.vipApplied = value;
    }
    public decimal get_VipAddedCredits()
    {
        return new System.Decimal() {flags = -1799234800, hi = R1 + 20};
    }
    public void set_VipAddedCredits(decimal value)
    {
    
    }
    public decimal get_VipAddedGems()
    {
        return new System.Decimal() {flags = -1799010800, hi = R1 + 36};
    }
    public void set_VipAddedGems(decimal value)
    {
    
    }
    public decimal get_VipAddedGoldenCurrency()
    {
        return new System.Decimal() {flags = -1798786800, hi = R1 + 52};
    }
    public void set_VipAddedGoldenCurrency(decimal value)
    {
    
    }
    public int get_VipLevel()
    {
        return (int)this.vipLevel;
    }
    public void set_VipLevel(int value)
    {
        this.vipLevel = value;
    }
    public int get_VipContribution()
    {
        return (int)this.vipContribution;
    }
    public void set_VipContribution(int value)
    {
        this.vipContribution = value;
    }
    public int get_VipFriendsGiftAmount()
    {
        return (int)this.vipFriendsGiftAmount;
    }
    public void set_VipFriendsGiftAmount(int value)
    {
        this.vipFriendsGiftAmount = value;
    }
    public bool get_ClubsApplied()
    {
        return (bool)this.clubsApplied;
    }
    public void set_ClubsApplied(bool value)
    {
        this.clubsApplied = value;
    }
    public int get_ClubsContribution()
    {
        return (int)this.clubsContribution;
    }
    public void set_ClubsContribution(int value)
    {
        this.clubsContribution = value;
    }
    public string get_LocalPrice()
    {
        if(this.price != null)
        {
                return;
        }
        
        return R4 + 92.ToString(format:  -1797462704);
    }
    public void set_LocalPrice(string value)
    {
        this.price = value;
    }
    public float get_SalePrice()
    {
        return (float)S0;
    }
    public void set_SalePrice(float value)
    {
        this.sale_price = ;
    }
    public int get_DefaultPackage()
    {
        return (int)this.defaultPackage;
    }
    public void set_DefaultPackage(int value)
    {
        this.defaultPackage = value;
    }
    public int get_PurchaseScale()
    {
        int val_3;
        if(this.purchaseScale > 1)
        {
                return (int)this.purchaseScale;
        }
        
        if(this.id != null)
        {
                val_3 = this.id.m_stringLength;
        }
        else
        {
                val_3 = 0;
        }
        
        string val_1 = this.id.Substring(startIndex:  -1, length:  1);
        int val_2 = System.Int32.Parse(s:  this.id);
        this.purchaseScale = val_2;
        return val_2;
    }
    public float get_TargetSalePrice()
    {
        return (float)S0;
    }
    public void set_TargetSalePrice(float value)
    {
        this.targetSalePrice = ;
    }
    public TrackerPurchasePoints get_TrackerPurchasePoint()
    {
    
    }
    public void set_TrackerPurchasePoint(TrackerPurchasePoints value)
    {
        this.trackerPurchasePoint = value;
    }
    public string get_LTOModifier()
    {
    
    }
    public void set_LTOModifier(string value)
    {
        this.ltoModifier = value;
    }
    public string get_ExtraInfo()
    {
    
    }
    public void set_ExtraInfo(string value)
    {
        this.extraInfo = value;
    }
    public string get_PromoType()
    {
    
    }
    public void set_PromoType(string value)
    {
        this.promoType = value;
    }
    public bool get_isPromoActivated()
    {
        return (bool)this.<isPromoActivated>k__BackingField;
    }
    public void set_isPromoActivated(bool value)
    {
        this.<isPromoActivated>k__BackingField = value;
    }
    public string get_originalPrice()
    {
    
    }
    public void set_originalPrice(string value)
    {
        this.<originalPrice>k__BackingField = value;
    }
    public bool get_IsSubscription()
    {
        return (bool)this.isSubscription;
    }
    public void set_IsSubscription(bool value)
    {
        this.isSubscription = value;
    }
    public decimal get_VipAddedAmount()
    {
        var val_3;
        int val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = R1 + 24;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = R1 + 20, hi = val_4, lo = R1 + 28, mid = R1 + 32}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                var val_2 = R1 + 20;
            return new System.Decimal() {flags = -1794768416, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = R1 + 28, mid = R1 + 32};
        }
        
        val_5 = null;
        val_5 = null;
        return new System.Decimal() {flags = -1794768416, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = R1 + 28, mid = R1 + 32};
    }
    public bool ContainsInstruction(PurchaseCommands instruction)
    {
        if(this.PurchaseInstructions == 0)
        {
                return false;
        }
        
        return this.PurchaseInstructions.Contains(item:  instruction);
    }
    public void AddInstruction(PurchaseCommands instruction)
    {
        System.Collections.Generic.List<PurchaseCommands> val_3 = this.PurchaseInstructions;
        if(val_3 == 0)
        {
                val_3 = null;
            val_3 = new System.Collections.Generic.List<WordPets.WordPetType>();
            this.PurchaseInstructions = val_3;
            if(val_3 == 0)
        {
                val_3 = 0;
        }
        
        }
        
        if((val_3.Contains(item:  instruction)) != false)
        {
                return;
        }
        
        this.PurchaseInstructions.Add(item:  instruction);
    }
    public void RemoveInstruction(PurchaseCommands instruction)
    {
        if(this.PurchaseInstructions == 0)
        {
                return;
        }
        
        if((this.PurchaseInstructions.Contains(item:  instruction)) == false)
        {
                return;
        }
        
        bool val_2 = this.PurchaseInstructions.Remove(item:  instruction);
    }
    public void AddTrackingInfo(string infoKey, object infoValue)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = this._PurchaseTrackingInfo;
        if(val_2 == 0)
        {
                val_2 = null;
            val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this._PurchaseTrackingInfo = val_2;
            if(val_2 == 0)
        {
                val_2 = 0;
        }
        
        }
        
        val_2.Add(key:  infoKey, value:  infoValue);
    }
    public PurchaseModel()
    {
        this.defaultPackage = 0;
        this.promoType = "";
        System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
        this.PurchaseInstructions = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this._PurchaseTrackingInfo = null;
        this.PrePurchaseUserInfo = new PurchaseUserInfo();
        System.Collections.Generic.Dictionary<System.String, System.Decimal> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Decimal>();
        this.rewards = null;
    }
    public PurchaseModel(PurchaseModel purchaseToClone)
    {
        System.Collections.Generic.Dictionary<System.String, System.Type> val_8;
        this.defaultPackage = 0;
        this.promoType = "";
        System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
        this.PurchaseInstructions = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this._PurchaseTrackingInfo = null;
        this.PrePurchaseUserInfo = new PurchaseUserInfo();
        if(purchaseToClone != 0)
        {
                this.<Sku>k__BackingField = purchaseToClone.<Sku>k__BackingField;
            this.id = purchaseToClone.id;
            this.price = purchaseToClone.price;
            this.sale_price = purchaseToClone.sale_price;
            this.trackerPurchasePoint = purchaseToClone.trackerPurchasePoint;
        }
        else
        {
                this.<Sku>k__BackingField = 0;
            this.id = 0;
            this.price = 0;
            this.sale_price = 0f;
            this.trackerPurchasePoint = 33446072;
        }
        
        System.Collections.Generic.List<WordPets.WordPetType> val_4 = new System.Collections.Generic.List<WordPets.WordPetType>(collection:  purchaseToClone.PurchaseInstructions);
        this.PurchaseInstructions = null;
        if(purchaseToClone != 0)
        {
                val_8 = null;
            val_8 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  purchaseToClone._PurchaseTrackingInfo);
            this._PurchaseTrackingInfo = val_8;
        }
        else
        {
                val_8 = null;
            val_8 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  purchaseToClone._PurchaseTrackingInfo);
            this._PurchaseTrackingInfo = val_8;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Decimal> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Decimal>(dictionary:  purchaseToClone.rewards);
        this.rewards = null;
    }
    public PurchaseModel(twelvegigs.storage.JsonDictionary json)
    {
        int val_7;
        int val_8;
        int val_9;
        int val_10;
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        int val_22;
        int val_23;
        int val_24;
        int val_25;
        int val_27;
        int val_28;
        int val_29;
        int val_30;
        int val_32;
        int val_33;
        int val_34;
        int val_35;
        int val_37;
        int val_38;
        int val_39;
        int val_40;
        var val_44;
        this.defaultPackage = 0;
        this.promoType = "";
        System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
        this.PurchaseInstructions = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this._PurchaseTrackingInfo = null;
        this.PrePurchaseUserInfo = new PurchaseUserInfo();
        string val_4 = json.getString(key:  1624646480, defaultValue:  1098586544);
        this.id = json;
        System.Collections.Generic.Dictionary<System.String, System.Decimal> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Decimal>();
        this.rewards = null;
        val_44 = null;
        val_44 = null;
        decimal val_6 = getDecimal(key:  json, defaultValue:  new System.Decimal() {flags = 2129282688, hi = System.Decimal.Zero, lo = ???, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        this.AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_10, mid = val_7});
        decimal val_11 = getDecimal(key:  json, defaultValue:  new System.Decimal() {flags = -1930648496, hi = System.Decimal.Zero, lo = ???, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        this.AddReward(rewardType:  -1930648496, amount:  new System.Decimal() {flags = val_13, hi = val_14, lo = val_15, mid = val_12});
        decimal val_16 = getDecimal(key:  json, defaultValue:  new System.Decimal() {flags = -1827757824, hi = System.Decimal.Zero, lo = ???, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        this.AddReward(rewardType:  -1827757824, amount:  new System.Decimal() {flags = val_18, hi = val_19, lo = val_20, mid = val_17});
        decimal val_21 = getDecimal(key:  json, defaultValue:  new System.Decimal() {flags = -1825935328, hi = System.Decimal.Zero});
        this.AddReward(rewardType:  -1825935328, amount:  new System.Decimal() {flags = val_23, hi = val_24, lo = val_25, mid = val_22});
        decimal val_26 = getDecimal(key:  json, defaultValue:  new System.Decimal() {flags = -1825935120, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_8, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        this.AddReward(rewardType:  -1825935120, amount:  new System.Decimal() {flags = val_28, hi = val_29, lo = val_30, mid = val_27});
        decimal val_31 = getDecimal(key:  json, defaultValue:  new System.Decimal() {flags = -1799947264, hi = System.Decimal.Zero});
        this.AddReward(rewardType:  -1799947264, amount:  new System.Decimal() {flags = val_33, hi = val_34, lo = val_35, mid = val_32});
        decimal val_36 = getDecimal(key:  json, defaultValue:  new System.Decimal() {flags = -1987367328, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_8, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        this.AddReward(rewardType:  -1987367328, amount:  new System.Decimal() {flags = val_38, hi = val_39, lo = val_40, mid = val_37});
        float val_41 = json.getFloat(key:  -1816221696, defaultValue:  null);
        this.sale_price = json;
        string val_42 = this.sale_price.ToString(format:  -1793840384);
        string val_43 = json.getString(key:  -1816221600, defaultValue:  -1793816196);
        this.price = json;
    }
    public PurchaseModel(System.Collections.Generic.Dictionary<string, object> packageDefinition)
    {
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        int val_43;
        this.defaultPackage = 0;
        this.promoType = "";
        System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
        this.PurchaseInstructions = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this._PurchaseTrackingInfo = null;
        this.PrePurchaseUserInfo = new PurchaseUserInfo();
        if((packageDefinition.ContainsKey(key:  1624646480)) != false)
        {
                object val_5 = packageDefinition.Item[1624646480];
            string val_6 = packageDefinition.ToString();
            this.id = packageDefinition;
        }
        
        if((packageDefinition.ContainsKey(key:  -1816221696)) != false)
        {
                object val_8 = packageDefinition.Item[-1816221696];
            string val_9 = packageDefinition.ToString();
            float val_10 = System.Single.Parse(s:  packageDefinition);
            this.sale_price = packageDefinition;
        }
        
        if((packageDefinition.ContainsKey(key:  -1816221600)) != false)
        {
                object val_12 = packageDefinition.Item[-1816221600];
            string val_13 = packageDefinition.ToString();
            this.price = packageDefinition;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Decimal> val_14 = new System.Collections.Generic.Dictionary<System.String, System.Decimal>();
        this.rewards = null;
        if((packageDefinition.ContainsKey(key:  2129282688)) != false)
        {
                object val_16 = packageDefinition.Item[2129282688];
            string val_17 = packageDefinition.ToString();
            decimal val_18 = System.Decimal.Parse(s:  -1793708144);
            this.AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_20, hi = val_21, lo = val_22, mid = val_19});
        }
        
        if((packageDefinition.ContainsKey(key:  -1930648496)) != false)
        {
                object val_24 = packageDefinition.Item[-1930648496];
            string val_25 = packageDefinition.ToString();
            decimal val_26 = System.Decimal.Parse(s:  -1793708144);
            this.AddReward(rewardType:  -1930648496, amount:  new System.Decimal() {flags = val_20, hi = val_21, lo = val_22, mid = val_19});
        }
        
        if((packageDefinition.ContainsKey(key:  -1827757824)) != false)
        {
                object val_28 = packageDefinition.Item[-1827757824];
            string val_29 = packageDefinition.ToString();
            decimal val_30 = System.Decimal.Parse(s:  -1793708144);
            this.AddReward(rewardType:  -1827757824, amount:  new System.Decimal() {flags = val_20, hi = val_21, lo = val_22, mid = val_19});
        }
        
        if((packageDefinition.ContainsKey(key:  -1825935328)) != false)
        {
                object val_32 = packageDefinition.Item[-1825935328];
            string val_33 = packageDefinition.ToString();
            decimal val_34 = System.Decimal.Parse(s:  -1793708144);
            this.AddReward(rewardType:  -1825935328, amount:  new System.Decimal() {flags = val_20, hi = val_21, lo = val_22, mid = val_19});
        }
        
        val_43 = "pet_cards";
        if((packageDefinition.ContainsKey(key:  -1825935216)) != false)
        {
                object val_36 = packageDefinition.Item[-1825935216];
            string val_37 = packageDefinition.ToString();
            decimal val_38 = System.Decimal.Parse(s:  -1793708144);
            this.AddReward(rewardType:  -1825935216, amount:  new System.Decimal() {flags = val_20, hi = val_21, lo = val_22, mid = val_19});
        }
        
        if((packageDefinition.ContainsKey(key:  -1825935120)) == false)
        {
                return;
        }
        
        object val_40 = packageDefinition.Item[-1825935120];
        string val_41 = packageDefinition.ToString();
        decimal val_42 = System.Decimal.Parse(s:  -1793708144);
        val_43 = val_19;
        this.AddReward(rewardType:  -1825935120, amount:  new System.Decimal() {flags = val_20, hi = val_21, lo = val_22, mid = val_43});
    }
    public void AddReward(string rewardType, decimal amount)
    {
        int val_3;
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        if((this.rewards.ContainsKey(key:  rewardType)) != false)
        {
                decimal val_2 = Item[this.rewards];
            decimal val_4 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1793578756}, d2:  new System.Decimal() {flags = val_3, hi = amount.flags, lo = amount.hi, mid = amount.lo});
            this.rewards.set_Item(key:  rewardType, value:  new System.Decimal() {flags = val_5, hi = val_6, lo = val_7, mid = val_8});
            return;
        }
        
        this.rewards.Add(key:  rewardType, value:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid});
    }
    public decimal GetReward(string rewardType)
    {
        var val_3;
        if((static_value_021FB667.ContainsKey(key:  R2)) != false)
        {
                decimal val_2 = this.Item[rewardType];
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -1981327856};
    }
    public override string ToString()
    {
        return this.ToCustomString();
    }
    public string ToCustomString()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1793210208, formatting:  1);
    }
    public string ToShortString()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.rewards, formatting:  1);
        string val_2 = System.String.Format(format:  -1793114016, arg0:  this.id, arg1:  15282176, arg2:  this.rewards);
    }

}
