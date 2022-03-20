using UnityEngine;
public class DefaultHandler<T> : MonoBehaviour
{
    // Fields
    private static bool isQuitting;
    protected static T _Instance;
    
    // Properties
    public static T Instance { get; }
    protected Player Player { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_16 = __RuntimeMethodHiddenParam;
        val_17 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_17 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_17 == 1)
        {
                val_17 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_17 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        val_18 = 1152921504765685760;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92 + 4) != 0)
        {
            goto label_135;
        }
        
        val_19 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_19 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_19 == 1)
        {
                val_19 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_19 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
        {
            goto label_135;
        }
        
        val_20 = mem[__RuntimeMethodHiddenParam + 12 + 186];
        val_20 = __RuntimeMethodHiddenParam + 12 + 186;
        val_21 = __RuntimeMethodHiddenParam + 12;
        if(val_20 == 1)
        {
                val_21 = mem[__RuntimeMethodHiddenParam + 12];
            val_21 = __RuntimeMethodHiddenParam + 12;
            val_20 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_20 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
        val_23 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        val_24 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12];
        val_24 = __RuntimeMethodHiddenParam + 12 + 96 + 8 + 12;
        if(val_24 < 2)
        {
            goto label_30;
        }
        
        val_22 = null;
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 12});
        typeof(System.Object[]).__il2cppRuntimeField_10 = __RuntimeMethodHiddenParam + 12 + 96 + 12;
        typeof(System.Object[]).__il2cppRuntimeField_14 = " found: ";
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        D.LogClientError(developer:  -1861586928, filter:  1788750208, context:  0, strings:  472754880);
        if((__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12) < 1)
        {
            goto label_110;
        }
        
        var val_3 = val_23 + 16;
        var val_16 = 0;
        do
        {
            if(((__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0) == 0)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = "instances[";
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "] is null";
            D.LogClientError(developer:  -1861586928, filter:  1788750208, context:  0, strings:  472754880);
        }
        else
        {
                UnityEngine.GameObject val_5 = (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0.gameObject;
            typeof(System.Object[]).__il2cppRuntimeField_10 = "instances[";
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            val_16 = __RuntimeMethodHiddenParam + 12;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "] = ";
            string val_6 = (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0.name;
            typeof(System.Object[]).__il2cppRuntimeField_1C = (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0;
            string val_7 = +472754880;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            D.LogClientError(developer:  -1861586928, filter:  1788750208, context:  (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0, strings:  472754880);
            val_18 = 1152921504765685760;
            val_25 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_25 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_25 == 1)
        {
                val_25 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_25 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
            mem2[0] = (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) + 0;
        }
        
            val_16 = val_16 + 1;
            val_22 = "instances[";
            val_24 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12];
            val_24 = __RuntimeMethodHiddenParam + 12 + 96 + 8 + 12;
        }
        while(val_16 < val_24);
        
        label_30:
        if(val_24 == 1)
        {
                if((__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16) == 0)
        {
                val_22 = "instances[0] is null";
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_22;
            D.LogClientError(developer:  -1861586928, filter:  1788750208, context:  0, strings:  472754880);
        }
        else
        {
                val_22 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8 + 16];
            val_22 = __RuntimeMethodHiddenParam + 12 + 96 + 8 + 16;
            val_26 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_26 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_26 == 1)
        {
                val_26 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_26 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
            mem2[0] = val_22;
        }
        
        }
        
        label_110:
        val_27 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_27 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_27 == 1)
        {
                val_27 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_27 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if(((__RuntimeMethodHiddenParam + 12 + 96 + 92 + 4) == 0) && (UnityEngine.Application.isPlaying != false))
        {
                System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 12});
            string val_12 = -1826387632(-1826387632) + __RuntimeMethodHiddenParam + 12 + 96 + 12(__RuntimeMethodHiddenParam + 12 + 96 + 12) + -1826387536(-1826387536);
            UnityEngine.GameObject val_13 = new UnityEngine.GameObject(name:  -1826387632);
            System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 12});
            UnityEngine.Component val_15 = AddComponent(componentType:  __RuntimeMethodHiddenParam + 12 + 96 + 12);
            val_28 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_28 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_28 == 1)
        {
                val_28 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_28 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
            val_29 = 0;
            if(val_13 != 0)
        {
                val_29 = val_13;
            if(val_29 == 0)
        {
                val_29 = 0;
        }
        
        }
        
            val_16 = __RuntimeMethodHiddenParam + 12;
            mem2[0] = val_29;
            val_30 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_30 = __RuntimeMethodHiddenParam + 12 + 186;
            val_22 = val_16;
            if(val_30 == 1)
        {
                val_22 = mem[__RuntimeMethodHiddenParam + 12];
            val_22 = val_16;
            val_30 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_30 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
        }
        
        label_135:
        val_31 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_31 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_31 == 1)
        {
                val_31 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_31 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
        {
                return;
        }
    
    }
    public void OnApplicationQuit()
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_1 == 1)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        mem2[0] = 1;
    }
    protected virtual void AwakeLogic()
    {
    
    }
    protected Player get_Player()
    {
        return App.Player;
    }
    protected void RewardPlayerPurchase(PurchaseModel purchase)
    {
        var val_4;
        var val_33;
        var val_34;
        string val_36;
        var val_37;
        var val_38;
        var val_40;
        var val_41;
        int val_43;
        var val_45;
        var val_47;
        var val_48;
        var val_50;
        decimal val_1 = Credits;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                decimal val_3 = Credits;
        }
        
        decimal val_5 = GoldenCurrency;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_7 = GoldenCurrency;
        }
        
        decimal val_8 = Gems;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_10 = Gems;
            val_33 = val_4;
        }
        
        decimal val_11 = PetsFood;
        val_34 = null;
        val_34 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_13 = PetsFood;
            val_37 = null;
            val_37 = null;
            val_36 = Events.PURCHASE_FOOD;
        }
        
        decimal val_14 = PetCards;
        val_38 = null;
        val_38 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_16 = PetCards;
            val_40 = val_4;
        }
        
        decimal val_17 = GoldenCurrency;
        val_41 = null;
        val_41 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                GameBehavior val_19 = App.getBehavior;
            val_43 = 0;
            if(0 != 0)
        {
                val_43 = 1152921511095741472;
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2101040096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_23 = GoldenCurrency;
            val_43 = System.Decimal.op_Explicit(value:  new System.Decimal());
            OnAppleAwarded(appleAwarded:  val_43);
        }
        
        }
        
        }
        
        decimal val_25 = Spins;
        val_45 = null;
        val_45 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_27 = Spins;
            val_47 = val_4;
        }
        
        decimal val_28 = DiceRolls;
        val_48 = null;
        val_48 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_30 = DiceRolls;
            val_50 = val_4;
        }
        
        if((purchase.id.Contains(value:  -1825930800)) == false)
        {
                return;
        }
        
        Player val_32 = App.Player;
        0.RemovedAds = true;
    }
    protected void RewardPlayer(string theType, decimal amount, string sourceOfReward = "")
    {
        string val_17;
        var val_18;
        val_17 = theType;
        val_18 = __RuntimeMethodHiddenParam;
        uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_17);
        if(val_1 > 1358361813)
        {
            goto label_1;
        }
        
        if(val_1 == 493674245)
        {
            goto label_2;
        }
        
        if(val_1 == 1034903372)
        {
            goto label_3;
        }
        
        if(val_1 != 1358361813)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_17, b:  2129282688)) == false)
        {
                return;
        }
        
        this.AddCredits(amount:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}, source:  sourceOfReward, subSource:  0, externalParams:  0, doTrack:  true);
        return;
        label_1:
        if(val_1 > 2214363133)
        {
            goto label_9;
        }
        
        if(val_1 == 2214363133)
        {
            goto label_10;
        }
        
        if(val_1 != 2012565570)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_17, b:  -1825935216)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_17 = 0;
        RewardPetCards(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}), pet:  0, source:  null, subsource:  val_17, additionalParam:  val_17);
        return;
        label_9:
        if(val_1 == 2261890746)
        {
            goto label_19;
        }
        
        if(val_1 != 3050352350)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_17, b:  -1987367328)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_17 = 0;
        AwardSpins(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}), source:  1098586544, notify:  false);
        return;
        label_2:
        if((System.String.op_Equality(a:  val_17, b:  -1825935120)) == false)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.RewardDiceRolls(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}), source:  sourceOfReward);
        return;
        label_3:
        if((System.String.op_Equality(a:  val_17, b:  -1827757824)) == false)
        {
                return;
        }
        
        val_18 = this;
        val_17 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid});
        this.AddPetsFood(amount:  val_17, source:  sourceOfReward, subSource:  null, FoodSpentParams:  0, additionalParam:  0);
        return;
        label_10:
        if((System.String.op_Equality(a:  val_17, b:  -1930648496)) == false)
        {
                return;
        }
        
        val_18 = 0;
        val_17 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid});
        this.AddGems(amount:  val_17, source:  sourceOfReward, subsource:  null);
        return;
        label_19:
        if((System.String.op_Equality(a:  val_17, b:  -1825935328)) == false)
        {
                return;
        }
        
        int val_17 = amount.hi;
        val_17 = (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = amount.flags, hi = val_17, lo = amount.lo, mid = amount.mid})) + this;
        this.stars = val_17;
    }
    protected decimal GetTotalAmountByPackage(twelvegigs.storage.JsonDictionary packageDictionary, string packageType)
    {
        decimal val_1 = PackagesManager.GetTotalAmountByPackage(pack:  -1825660968, currencyType:  packageType);
        return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
    }
    protected twelvegigs.storage.JsonDictionary GetPackage(string id)
    {
        return PackagesManager.GetPackageById(packageId:  id);
    }
    public DefaultHandler<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    private static DefaultHandler<T>()
    {
    
    }

}
