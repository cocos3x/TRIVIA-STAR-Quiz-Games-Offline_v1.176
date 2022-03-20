using UnityEngine;
public class PackagesManager
{
    // Fields
    public const string CREDITS = "credits";
    public const string GOLDEN_CURRENCY = "golden_currency";
    public const string SPECIAL = "special";
    public const string PRICE = "sale_price";
    public const string LOC_PRICE = "regular_price";
    public const string ID = "id";
    public const string GEMS = "gems";
    public const string PETS_FOOD = "pets_food";
    public const string PET_CARDS = "pet_cards";
    public const string DICE_ROLLS = "dice_rolls";
    public const string KEYS = "keys";
    public const string SPINS = "spins";
    public const string REMOVEADS = "removeAds";
    public const string GOLDEN_TICKET = "golden_ticket";
    public const string SILVER_TICKET = "silver_ticket";
    private static PackageDefinitions myDef;
    private static string[] NonConsumables;
    private static bool transformedCreditPacks;
    private static float _knownBestValuePrice;
    
    // Properties
    public static PackageDefinitions getDef { get; }
    
    // Methods
    public static PackageDefinitions get_getDef()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(PackagesManager.myDef == 0)
        {
                GameBehavior val_1 = App.getBehavior;
            object val_3 = System.Activator.CreateInstance(type:  0);
            val_5 = null;
            val_5 = null;
            PackagesManager.myDef = 0;
            val_4 = null;
        }
        
        val_4 = null;
    }
    private static System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> GetListToUseForGame(string packageType)
    {
        string val_13;
        var val_14;
        var val_15;
        val_13 = packageType;
        if((System.String.op_Equality(a:  val_13, b:  -1827757824)) != false)
        {
                PackageDefinitions val_2 = PackagesManager.getDef;
            val_14 = null;
            val_15 = mem[null + 236];
        }
        else
        {
                if((System.String.op_Equality(a:  val_13, b:  -1825935120)) != false)
        {
                PackageDefinitions val_4 = PackagesManager.getDef;
            val_14 = null;
            val_15 = mem[null + 252];
        }
        else
        {
                if((System.String.op_Equality(a:  val_13, b:  -1930648496)) != false)
        {
                PackageDefinitions val_6 = PackagesManager.getDef;
            val_14 = null;
            val_15 = mem[null + 228];
        }
        else
        {
                if((System.String.op_Equality(a:  val_13, b:  -1987367328)) != false)
        {
                PackageDefinitions val_8 = PackagesManager.getDef;
            val_14 = null;
            val_15 = mem[null + 244];
        }
        else
        {
                if((System.String.op_Equality(a:  val_13, b:  -1804579328)) != false)
        {
                PackageDefinitions val_10 = PackagesManager.getDef;
            val_14 = null;
            val_15 = mem[null + 268];
        }
        else
        {
                bool val_11 = System.String.op_Equality(a:  R4, b:  2129282688);
            return PackagesManager.GetCreditsForGame();
        }
        
        }
        
        }
        
        }
        
        }
    
    }
    private static System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> GetCreditsForGame()
    {
        int val_3;
        var val_9;
        var val_10;
        System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean> val_12;
        val_9 = null;
        val_9 = null;
        if(PackagesManager.transformedCreditPacks != true)
        {
                PackageDefinitions val_1 = PackagesManager.getDef;
            decimal val_2 = PackagesManager.GetCreditPackMultiplierForGame();
            PackagesManager.TransformCreditPacks(creditPacks:  292225024, multiplier:  new System.Decimal() {mid = val_3});
            val_9 = null;
        }
        
        PackageDefinitions val_4 = PackagesManager.getDef;
        val_10 = null;
        val_10 = null;
        val_12 = PackagesManager.<>c.<>9__19_0;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  PackagesManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2490504160));
            PackagesManager.<>c.<>9__19_0 = val_12;
        }
        
        object val_6 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  292225024, predicate:  7720960);
        if(val_9 != 0)
        {
                GameEcon val_7 = App.getGameEcon;
            set_Item(key:  2129282688, value:  13152256);
        }
        
        PackageDefinitions val_8 = PackagesManager.getDef;
        if(null != 0)
        {
                return;
        }
    
    }
    private static decimal GetCreditPackMultiplierForGame()
    {
        var val_3;
        decimal val_4;
        var val_5;
        var val_2 = 22797743;
        val_2 = 12828044 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        GameNames val_3 = App.game;
        val_3 = val_3 - 16;
        if(val_3 <= 5)
        {
                var val_1 = 12828144 + (12828144 + ((App.game - 16)) << 2);
            if(val_3 == 5)
        {
                12828144 + ((App.game - 16)) << 2 = (12828144 + ((App.game - 16)) << 2) & ((R8) << 12828144 + ((App.game - 16)) << 2);
            12828144 + ((App.game - 16)) << 2 = (12828144 + ((App.game - 16)) << 2) & ((R8) >> 32);
            12828144 + ((App.game - 16)) << 2 = (12828144 + ((App.game - 16)) << 2) & (((R8) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R8) << as. 
            
        
        
        
        
        
           
        ));
            12828144 + ((App.game - 16)) << 2 = (12828144 + ((App.game - 16)) << 2) & (((R8) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R8) << as. 
            
        
        
        
        
        
           
        ));
            12828144 + ((App.game - 16)) << 2 = (12828144 + ((App.game - 16)) << 2) & ((R8) >> 32);
            12828144 + ((App.game - 16)) << 2 = (12828144 + ((App.game - 16)) << 2) & ((R8) << (((((12828144 + ((App.game - 16)) << 2 & (R8) << 12828144 + ((App.game - 16)) << 2) & (R8) >> 32) & ((R8) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R8) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-as. 
            
        
        
        
        
        
          );
        }
        
            val_4 = 0m;
            val_5 = 5;
        }
        else
        {
                val_4 = 0m;
            val_5 = 10;
        }
        
        val_4 = new System.Decimal(value:  10);
        return new System.Decimal() {flags = val_4, hi = 10};
    }
    public static decimal GetCreditsAmountByIndex(string packageType, int packageIndex)
    {
        var val_5;
        var val_6;
        var val_7 = R2;
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = PackagesManager.GetListToUseForGame(packageType:  packageIndex);
        label_17:
        var val_6 = 0;
        label_16:
        val_5 = null;
        val_5 = null;
        if((packageIndex + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = packageIndex + 8;
        val_5 = val_5 + (val_7 << 2);
        if(val_6 >= (PackagesManager.NonConsumables + 12))
        {
            goto label_8;
        }
        
        string val_2 = (packageIndex + 8 + (R2) << 2) + 16.Item[1624646480];
        val_6 = null;
        val_6 = null;
        val_6 = val_6 + 1;
        if(((packageIndex + 8 + (R2) << 2) + 16.Contains(value:  PackagesManager.NonConsumables + 12 + 16)) == false)
        {
            goto label_16;
        }
        
        val_7 = val_7 + 1;
        goto label_17;
        label_8:
        decimal val_4 = PackagesManager.GetTotalAmountByPackage(thePack:  packageType, currencyType:  (packageIndex + 8 + (R2) << 2) + 16);
        return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
    }
    public static float GetPriceByIndex(string packageType, int index)
    {
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = PackagesManager.GetListToUseForGame(packageType:  packageType);
        if(packageType.m_firstChar <= index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_3 = packageType.m_stringLength;
        val_3 = val_3 + (index << 2);
        if((new twelvegigs.storage.JsonDictionary(parsedDictionary:  (packageType.m_stringLength + (index) << 2) + 16)) != 0)
        {
                return getFloat(key:  -1816221696, defaultValue:  null);
        }
        
        return getFloat(key:  -1816221696, defaultValue:  null);
    }
    public static twelvegigs.storage.JsonDictionary GetPackageByIndex(string packageType, int index)
    {
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = PackagesManager.GetListToUseForGame(packageType:  packageType);
        if(packageType.m_firstChar <= index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_3 = packageType.m_stringLength;
        val_3 = val_3 + (index << 2);
        twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  (packageType.m_stringLength + (index) << 2) + 16);
    }
    public static twelvegigs.storage.JsonDictionary GetPackageBySubscriptionID(string packageType, SubscriptionHandler.SubScriptionType instruction)
    {
        object val_1 = new System.Object();
        if(instruction == 0)
        {
                "silver_ticket" = "golden_ticket";
        }
        
        typeof(PackagesManager.<>c__DisplayClass24_0).__il2cppRuntimeField_8 = "golden_ticket";
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = PackagesManager.GetListToUseForGame(packageType:  packageType);
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_3 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  292331520, method:  new IntPtr(2491100000));
        object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  packageType, predicate:  7720960);
        GameBehavior val_5 = App.getBehavior;
        twelvegigs.storage.JsonDictionary val_6 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  0);
    }
    public static decimal GetTotalAmountByPackage(System.Collections.IDictionary thePack, string currencyType)
    {
        var val_3;
        twelvegigs.storage.JsonDictionary val_1 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  currencyType);
        val_3 = null;
        val_3 = null;
        decimal val_2 = thePack.getDecimal(key:  458731520, defaultValue:  new System.Decimal() {flags = R2, hi = System.Decimal.Zero});
        return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
    }
    public static decimal GetTotalAmountByPackage(twelvegigs.storage.JsonDictionary pack, string currencyType)
    {
        null = null;
        decimal val_1 = pack.getDecimal(key:  currencyType, defaultValue:  new System.Decimal() {flags = R2, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_8, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
    }
    public static System.Collections.IList GetPackages(string packageType)
    {
        return PackagesManager.GetPackagesByType(packageType:  packageType);
    }
    private static System.Collections.Generic.List<twelvegigs.storage.JsonDictionary> GetPackagesByType(string packageType)
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4;
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = PackagesManager.GetListToUseForGame(packageType:  packageType);
        val_4 = null;
        val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(packageType != null)
        {
                if(packageType.m_firstChar < '')
        {
                return;
        }
        
            var val_5 = 0;
            do
        {
            if(packageType.m_firstChar <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            int val_4 = packageType.m_stringLength;
            val_4 = val_4 + 0;
            null = new twelvegigs.storage.JsonDictionary(parsedDictionary:  (packageType.m_stringLength + 0) + 16);
            Add(item:  458731520);
            val_5 = val_5 + 1;
        }
        while(val_5 < packageType.m_firstChar);
        
            return;
        }
        
        val_4 = 0;
    }
    public static twelvegigs.storage.JsonDictionary GetPackageById(string packageId)
    {
        string val_5;
        var val_10;
        string val_1 = PackagesManager.InferPackageKind(packageId:  packageId);
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = PackagesManager.GetListToUseForGame(packageType:  packageId);
        if(packageId == null)
        {
            goto label_16;
        }
        
        List.Enumerator<T> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        string val_6 = val_5.Item[1624646480];
        if((System.String.op_Equality(a:  val_5, b:  packageId)) == false)
        {
            goto label_7;
        }
        
        twelvegigs.storage.JsonDictionary val_8 = null;
        val_10 = val_8;
        val_8 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  val_5);
        goto label_8;
        label_4:
        val_10 = 0;
        label_8:
        Dispose();
        return;
        label_16:
        val_10 = 0;
    }
    public static bool IsNonConsumable(PurchaseModel purchase)
    {
        var val_2;
        if(purchase.id == null)
        {
                return false;
        }
        
        val_2 = null;
        val_2 = null;
        var val_2 = 0;
        do
        {
            if(val_2 >= (PackagesManager.NonConsumables + 12))
        {
                return false;
        }
        
            val_2 = val_2 + 1;
        }
        while((purchase.id.Contains(value:  SB + 0)) == false);
        
        return true;
    }
    private static string InferPackageKind(string packageId)
    {
        if((packageId.LastIndexOf(value:  2129282688)) > 1)
        {
                return;
        }
        
        if((packageId.LastIndexOf(value:  -1930648496)) > 1)
        {
                "credits" = "gems";
        }
    
    }
    private static void TransformCreditPacks(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> creditPacks, decimal multiplier)
    {
        System.Globalization.NumberStyles val_3;
        int val_6;
        var val_8;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        string val_4 = val_3.Item[2129282688];
        decimal val_5 = System.Decimal.Parse(s:  -1802850824, style:  val_3);
        decimal val_7 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1802850840}, d2:  new System.Decimal() {flags = val_6, hi = multiplier.flags, lo = multiplier.hi, mid = multiplier.lo});
        val_3.set_Item(key:  2129282688, value:  10170368);
        goto label_8;
        label_2:
        Dispose();
        val_8 = null;
        val_8 = null;
        PackagesManager.transformedCreditPacks = true;
    }
    public static void UpdateCreditsFromStore(System.Collections.Generic.Dictionary<string, string> items)
    {
        var val_6;
        float val_8;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        string val_1 = PrettyPrint.printJSON(obj:  items, types:  false, singleLineOutput:  false);
        string val_2 = -1802742560(-1802742560) + items;
        SLCDebug.Log(logMessage:  -1802742560, colorHash:  -1835139200, isError:  false);
        PackageDefinitions val_3 = PackagesManager.getDef;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_24:
        if(MoveNext() == false)
        {
            goto label_9;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
        label_21:
        if(val_8.MoveNext() == false)
        {
            goto label_11;
        }
        
        string val_10 = val_6.Item[1624646480];
        if((val_6.Equals(value:  R4)) == false)
        {
            goto label_21;
        }
        
        if((val_6.ContainsKey(key:  -1816221600)) == false)
        {
            goto label_17;
        }
        
        val_6.set_Item(key:  -1816221600, value:  0);
        goto label_21;
        label_17:
        val_6.Add(key:  -1816221600, value:  0);
        goto label_21;
        label_11:
        var val_13 = 0 + 1;
        mem2[0] = 181;
        val_8.Dispose();
        if(val_13 == 1)
        {
            goto label_24;
        }
        
        if((-1802730608 + ((0 + 1)) << 2) == 181)
        {
                val_13 = val_13 >> 31;
            val_13 = ~(val_13 >> 31);
            val_13 = val_13 + val_13;
        }
        
        goto label_24;
        label_9:
        var val_50 = 0;
        val_50 = val_50 + 1;
        mem2[0] = 209;
        Dispose();
        if(val_50 != 1)
        {
                if(val_50 > 1)
        {
                0 = 1;
        }
        
            var val_51 = -1802730608 + ((0 + 1)) << 2;
            val_51 = val_51 - 209;
            val_51 = val_51 >> 5;
            val_51 = 1 & val_51;
            val_45 = val_50 - val_51;
        }
        else
        {
                val_45 = 0;
        }
        
        PackageDefinitions val_14 = PackagesManager.getDef;
        List.Enumerator<T> val_15 = GetEnumerator();
        label_57:
        if(MoveNext() == false)
        {
            goto label_42;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_17 = GetEnumerator();
        label_54:
        if(val_8.MoveNext() == false)
        {
            goto label_44;
        }
        
        string val_19 = val_6.Item[1624646480];
        if((val_6.Equals(value:  R4)) == false)
        {
            goto label_54;
        }
        
        if((val_6.ContainsKey(key:  -1816221600)) == false)
        {
            goto label_50;
        }
        
        val_6.set_Item(key:  -1816221600, value:  0);
        goto label_54;
        label_50:
        val_6.Add(key:  -1816221600, value:  0);
        goto label_54;
        label_44:
        var val_22 = val_45 + 1;
        mem2[0] = 367;
        val_8.Dispose();
        if(val_22 == 1)
        {
            goto label_57;
        }
        
        if((-1802730608 + ((val_45 + 1)) << 2) == 367)
        {
                -1802730608 + ((val_45 + 1)) << 2 = val_22 >> 31;
            -1802730608 + ((val_45 + 1)) << 2 = ~(val_22 >> 31);
            val_22 = val_22 + (-1802730608 + ((val_45 + 1)) << 2);
        }
        
        goto label_57;
        label_42:
        val_45 = val_45 + 1;
        mem2[0] = 395;
        Dispose();
        if(val_45 != 1)
        {
                if(val_45 > 1)
        {
                0 = 1;
        }
        
            var val_52 = -1802730608 + ((val_45 + 1)) << 2;
            val_52 = val_52 - 395;
            val_52 = val_52 >> 5;
            val_52 = 1 & val_52;
            val_46 = val_45 - val_52;
        }
        else
        {
                val_46 = 0;
        }
        
        PackageDefinitions val_23 = PackagesManager.getDef;
        List.Enumerator<T> val_24 = GetEnumerator();
        label_90:
        if(MoveNext() == false)
        {
            goto label_75;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_26 = GetEnumerator();
        label_87:
        if(val_8.MoveNext() == false)
        {
            goto label_77;
        }
        
        string val_28 = val_6.Item[1624646480];
        if((val_6.Equals(value:  R4)) == false)
        {
            goto label_87;
        }
        
        if((val_6.ContainsKey(key:  -1816221600)) == false)
        {
            goto label_83;
        }
        
        val_6.set_Item(key:  -1816221600, value:  0);
        goto label_87;
        label_83:
        val_6.Add(key:  -1816221600, value:  0);
        goto label_87;
        label_77:
        var val_31 = val_46 + 1;
        mem2[0] = 553;
        val_8.Dispose();
        if(val_31 == 1)
        {
            goto label_90;
        }
        
        if((-1802730608 + ((val_46 + 1)) << 2) == 553)
        {
                -1802730608 + ((val_46 + 1)) << 2 = val_31 >> 31;
            -1802730608 + ((val_46 + 1)) << 2 = ~(val_31 >> 31);
            val_31 = val_31 + (-1802730608 + ((val_46 + 1)) << 2);
        }
        
        goto label_90;
        label_75:
        val_46 = val_46 + 1;
        mem2[0] = 581;
        Dispose();
        if(val_46 != 1)
        {
                if(val_46 > 1)
        {
                0 = 1;
        }
        
            var val_53 = -1802730608 + ((val_46 + 1)) << 2;
            val_53 = val_53 - 581;
            val_53 = val_53 >> 5;
            val_53 = 1 & val_53;
            val_47 = val_46 - val_53;
        }
        else
        {
                val_47 = 0;
        }
        
        PackageDefinitions val_32 = PackagesManager.getDef;
        List.Enumerator<T> val_33 = GetEnumerator();
        label_123:
        if(MoveNext() == false)
        {
            goto label_108;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_35 = GetEnumerator();
        label_120:
        if(val_8.MoveNext() == false)
        {
            goto label_110;
        }
        
        string val_37 = val_6.Item[1624646480];
        if((val_6.Equals(value:  R4)) == false)
        {
            goto label_120;
        }
        
        if((val_6.ContainsKey(key:  -1816221600)) == false)
        {
            goto label_116;
        }
        
        val_6.set_Item(key:  -1816221600, value:  0);
        goto label_120;
        label_116:
        val_6.Add(key:  -1816221600, value:  0);
        goto label_120;
        label_110:
        var val_40 = val_47 + 1;
        mem2[0] = 739;
        val_8.Dispose();
        if(val_40 == 1)
        {
            goto label_123;
        }
        
        if((-1802730608 + ((val_47 + 1)) << 2) == 739)
        {
                -1802730608 + ((val_47 + 1)) << 2 = val_40 >> 31;
            -1802730608 + ((val_47 + 1)) << 2 = ~(val_40 >> 31);
            val_40 = val_40 + (-1802730608 + ((val_47 + 1)) << 2);
        }
        
        goto label_123;
        label_108:
        val_47 = val_47 + 1;
        mem2[0] = 767;
        Dispose();
        if(val_47 != 1)
        {
                if(val_47 > 1)
        {
                0 = 1;
        }
        
            var val_54 = -1802730608 + ((val_47 + 1)) << 2;
            val_54 = val_54 - 767;
            val_54 = val_54 >> 5;
            val_54 = 1 & val_54;
            val_48 = val_47 - val_54;
        }
        else
        {
                val_48 = 0;
        }
        
        PackageDefinitions val_41 = PackagesManager.getDef;
        List.Enumerator<T> val_42 = GetEnumerator();
        label_156:
        if(MoveNext() == false)
        {
            goto label_141;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_44 = GetEnumerator();
        label_153:
        if(val_8.MoveNext() == false)
        {
            goto label_143;
        }
        
        string val_46 = val_6.Item[1624646480];
        if((val_6.Equals(value:  R4)) == false)
        {
            goto label_153;
        }
        
        if((val_6.ContainsKey(key:  -1816221600)) == false)
        {
            goto label_149;
        }
        
        val_6.set_Item(key:  -1816221600, value:  0);
        goto label_153;
        label_149:
        val_6.Add(key:  -1816221600, value:  0);
        goto label_153;
        label_143:
        var val_49 = val_48 + 1;
        mem2[0] = 925;
        val_8.Dispose();
        if(val_49 == 1)
        {
            goto label_156;
        }
        
        if((-1802730608 + ((val_48 + 1)) << 2) == 925)
        {
                -1802730608 + ((val_48 + 1)) << 2 = val_49 >> 31;
            -1802730608 + ((val_48 + 1)) << 2 = ~(val_49 >> 31);
            val_49 = val_49 + (-1802730608 + ((val_48 + 1)) << 2);
        }
        
        goto label_156;
        label_141:
        val_48 = val_48 + 1;
        mem2[0] = 953;
        Dispose();
        if(val_48 != 1)
        {
                if(val_48 > 1)
        {
                0 = 1;
        }
        
            var val_55 = -1802730608 + ((val_48 + 1)) << 2;
            val_55 = val_55 - 953;
            val_55 = val_55 >> 5;
            val_55 = 1 & val_55;
            val_48 = val_48 - val_55;
        }
    
    }
    public static float GetBestValuePackPrice(System.Collections.Generic.List<PurchaseModel> unfiltered)
    {
        var val_1;
        float val_2;
        val_1 = null;
        val_1 = null;
        val_1 = null;
        val_2 = ;
        return (float);
    }
    public static string GetPackagePrice(twelvegigs.storage.JsonDictionary package)
    {
        float val_5;
        var val_6;
        var val_7;
        val_5 = "";
        if(package == 0)
        {
                return;
        }
        
        val_6 = 0;
        val_6 = val_6 + 1;
        val_7 = package.dataSource;
        if(package.dataSource == 0)
        {
                return;
        }
        
        string val_2 = package.getString(key:  -1816221600, defaultValue:  1098586544);
        val_5 = package;
        if((System.String.op_Equality(a:  package, b:  1098586544)) == false)
        {
                return;
        }
        
        string val_4 = package.getString(key:  -1816221696, defaultValue:  1098586544);
        return -1802497744(-1802497744) + package;
    }
    public static int GetAdPackageCount(string packageType)
    {
        var val_3;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_5;
        System.Collections.Generic.List<twelvegigs.storage.JsonDictionary> val_1 = PackagesManager.GetPackagesByType(packageType:  packageType);
        val_3 = null;
        val_3 = null;
        val_5 = PackagesManager.<>c.<>9__39_0;
        if(val_5 != 0)
        {
                return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  packageType, predicate:  7720960);
        }
        
        val_5 = null;
        val_5 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  PackagesManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2492593920));
        PackagesManager.<>c.<>9__39_0 = val_5;
        return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  packageType, predicate:  7720960);
    }
    public PackagesManager()
    {
    
    }
    private static PackagesManager()
    {
        PackagesManager.myDef = 0;
        typeof(System.String[]).__il2cppRuntimeField_10 = "remove";
        PackagesManager.NonConsumables = null;
        PackagesManager.transformedCreditPacks = false;
        PackagesManager._knownBestValuePrice = -1f;
    }

}
