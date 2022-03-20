using UnityEngine;
public class SpinKingSlotMachine
{
    // Fields
    public const int NumberOfReel = 3;
    public const int NumberOfRow = 5;
    public static SpinKingSlotMachine.SpinType hackSpinType;
    private static System.Collections.Generic.List<SpinKingOutCome> outComesConfig;
    private static SpinKingSlotMachine.SpinKingSymbol[,] <ReelData>k__BackingField;
    private static SpinKingOutCome <SpinResult>k__BackingField;
    private static int middleRow;
    private static RandomSet spinRandomSet;
    private static System.Collections.Generic.List<SpinKingSlotMachine.SpinKingSymbol> allSymbolTypes;
    private static System.Collections.Generic.List<SpinKingSlotMachine.SpinKingSymbol> allNonCoinSymbolTypes;
    
    // Properties
    public static SpinKingSlotMachine.SpinKingSymbol[,] ReelData { get; set; }
    public static SpinKingOutCome SpinResult { get; set; }
    
    // Methods
    public static SpinKingSlotMachine.SpinKingSymbol[,] get_ReelData()
    {
        null = null;
    }
    private static void set_ReelData(SpinKingSlotMachine.SpinKingSymbol[,] value)
    {
        null = null;
        SpinKingSlotMachine.<ReelData>k__BackingField = value;
    }
    public static SpinKingOutCome get_SpinResult()
    {
        null = null;
    }
    private static void set_SpinResult(SpinKingOutCome value)
    {
        null = null;
        SpinKingSlotMachine.<SpinResult>k__BackingField = value;
    }
    public static SpinKingSlotMachine.SpinKingSymbol GetRandomSymbol(SpinKingSlotMachine.SpinKingSymbol except = 0)
    {
        var val_3;
        var val_4;
        var val_5;
        do
        {
            val_3 = null;
            val_3 = null;
            if(SpinKingSlotMachine.allSymbolTypes != 0)
        {
                val_4 = SpinKingSlotMachine.allSymbolTypes;
            val_5 = UnityEngine.Random.Range(min:  0, max:  SpinKingSlotMachine.allSymbolTypes + 12);
        }
        else
        {
                val_4 = 12;
            val_5 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_4 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_3 = SpinKingSlotMachine.allSymbolTypes + 8;
            val_3 = val_3 + (val_5 << 2);
        }
        while(((SpinKingSlotMachine.allSymbolTypes + 8 + (val_2) << 2) + 16) == except);
    
    }
    private static SpinKingSlotMachine.SpinKingSymbol GetNonCoinRandomSymbol(SpinKingSlotMachine.SpinKingSymbol except = 0)
    {
        var val_3;
        var val_4;
        var val_5;
        do
        {
            val_3 = null;
            val_3 = null;
            if(SpinKingSlotMachine.allNonCoinSymbolTypes != 0)
        {
                val_4 = SpinKingSlotMachine.allNonCoinSymbolTypes;
            val_5 = UnityEngine.Random.Range(min:  0, max:  SpinKingSlotMachine.allNonCoinSymbolTypes + 12);
        }
        else
        {
                val_4 = 12;
            val_5 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_4 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_3 = SpinKingSlotMachine.allNonCoinSymbolTypes + 8;
            val_3 = val_3 + (val_5 << 2);
        }
        while(((SpinKingSlotMachine.allNonCoinSymbolTypes + 8 + (val_2) << 2) + 16) == except);
    
    }
    public static SpinKingOutCome CreateSpinOutCome()
    {
        SpinKingOutCome val_5;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_28;
        var val_29;
        var val_31;
        var val_32;
        var val_34;
        var val_35;
        var val_37;
        var val_16 = 19718104;
        val_16 = 15926716 + val_16;
        val_17 = null;
        val_17 = null;
        if((SpinKingSlotMachine.<ReelData>k__BackingField) == 0)
        {
            goto label_13;
        }
        
        var val_17 = 19717972;
        val_17 = 15926848 + val_17;
        val_18 = null;
        val_18 = null;
        if((SpinKingSlotMachine.<ReelData>k__BackingField.Length) == 0)
        {
            goto label_13;
        }
        
        val_19 = null;
        goto label_14;
        label_13:
        var val_18 = 19717765;
        val_18 = 15927056 + val_18;
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        val_19 = null;
        val_19 = null;
        SpinKingSlotMachine.<ReelData>k__BackingField = null;
        label_14:
        val_19 = null;
        val_20 = 0;
        if(SpinKingSlotMachine.spinRandomSet.remainingCount() != 0)
        {
            goto label_23;
        }
        
        val_21 = null;
        val_21 = null;
        SpinKingSlotMachine.spinRandomSet.replacement = true;
        val_22 = 0;
        goto label_27;
        label_37:
        val_23 = null;
        val_23 = null;
        if((SpinKingSlotMachine.outComesConfig + 12) <= val_22)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_19 = SpinKingSlotMachine.outComesConfig + 8;
        val_19 = val_19 + 0;
        SpinKingSlotMachine.spinRandomSet.add(item:  0, weight:  null);
        val_22 = 1;
        label_27:
        val_24 = null;
        val_24 = null;
        if(val_22 < (SpinKingSlotMachine.outComesConfig + 12))
        {
            goto label_37;
        }
        
        label_23:
        val_25 = null;
        if(val_22 != (SpinKingSlotMachine.outComesConfig + 12))
        {
                val_20 = (SpinKingSlotMachine.__il2cppRuntimeField_BA & 512);
        }
        
        if(SpinKingSlotMachine.hackSpinType == 0)
        {
            goto label_41;
        }
        
        List.Enumerator<T> val_4 = 3.GetEnumerator();
        goto label_49;
        label_55:
        val_28 = null;
        val_28 = null;
        if((val_5 + 8) == SpinKingSlotMachine.hackSpinType)
        {
                val_29 = null;
            val_29 = null;
            SpinKingSlotMachine.<SpinResult>k__BackingField = val_5;
        }
        
        label_49:
        if(MoveNext() == true)
        {
            goto label_55;
        }
        
        Dispose();
        goto label_56;
        label_41:
        int val_7 = SpinKingSlotMachine.spinRandomSet.roll(unweighted:  false);
        if((SpinKingSlotMachine.outComesConfig + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_20 = 19716810;
        var val_21 = SpinKingSlotMachine.outComesConfig + 8;
        val_20 = 15928012 + val_20;
        val_21 = val_21 + (val_7 << 2);
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        SpinKingSlotMachine.<SpinResult>k__BackingField = (SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16;
        label_56:
        var val_24 = 0;
        do
        {
            var val_23 = 0;
            do
        {
            var val_22 = 19716652;
            val_22 = 15928168 + val_22;
            val_32 = null;
            val_32 = null;
            SpinKingSymbol val_8 = SpinKingSlotMachine.GetRandomSymbol(except:  0);
            val_23 = val_23 + 1;
            mem2[0] = 0;
        }
        while(val_23 != 5);
        
            val_24 = val_24 + 1;
        }
        while(val_24 != 3);
        
        var val_25 = 19716423;
        val_25 = 15928400 + val_25;
        if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
        val_34 = null;
        val_34 = null;
        SpinKingSlotMachine.SpinType val_26 = (SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType;
        val_26 = val_26 - 1;
        if(val_26 <= 9)
        {
                var val_9 = 15928516 + (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2);
            if(val_26 == 9)
        {
                15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2 = (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2) & 36255652;
            15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2 = (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2) & (1152921504986877952 >> (SpinKingSlotMachine.<SpinResult>k__BackingField));
            15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2 = (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2) & 36255652;
            15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2 = (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2) & (1152921504986877952 >> val_24);
            15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2 = (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2) & ((IP) << 1152921513010892296);
            15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2 = (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2) & ((IP) >> LR);
            15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2 = (15928516 + (((SpinKingSlotMachine.outComesConfig + 8 + (val_7) << 2) + 16.SType - 1)) << 2) & ((SpinKingSlotMachine.<SpinResult>k__BackingField) >> 0);
        }
        
            var val_27 = 19716220;
            val_27 = 15928600 + val_27;
            if(val_27 == 0)
        {
                var val_28 = 19716188;
            val_28 = 15928632 + val_28;
            mem2[0] = 1;
        }
        
            val_35 = null;
            val_35 = null;
            SpinKingSymbol[,] val_10 = (SpinKingSlotMachine.<ReelData>k__BackingField) + (SpinKingSlotMachine.middleRow << 2);
            var val_31 = 1;
            mem2[0] = 1;
            do
        {
            var val_29 = 19716012;
            val_29 = 15928808 + val_29;
            if(val_29 == 0)
        {
                var val_30 = 19715984;
            val_30 = 15928836 + val_30;
            mem2[0] = 1;
        }
        
            val_37 = null;
            val_37 = null;
            SpinKingSymbol val_11 = SpinKingSlotMachine.GetNonCoinRandomSymbol(except:  0);
            val_31 = val_31 + 1;
            mem2[0] = 0;
        }
        while(val_31 != 3);
        
        }
    
    }
    public SpinKingSlotMachine()
    {
    
    }
    private static SpinKingSlotMachine()
    {
        SpinKingSlotMachine.hackSpinType = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        object val_2 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 0;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 0;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1092616192;
        Add(item:  380190720);
        object val_3 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 1;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 5;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1101004800;
        Add(item:  380190720);
        object val_4 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 2;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 10;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1090519040;
        Add(item:  380190720);
        object val_5 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 3;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 20;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1077936128;
        Add(item:  380190720);
        object val_6 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 4;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 2;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1101004800;
        Add(item:  380190720);
        object val_7 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 5;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 3;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1092616192;
        Add(item:  380190720);
        object val_8 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 6;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 4;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1082130432;
        Add(item:  380190720);
        object val_9 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 7;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 15;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1092616192;
        Add(item:  380190720);
        object val_10 = new System.Object();
        Add(item:  380190720);
        object val_11 = new System.Object();
        typeof(SpinKingOutCome).__il2cppRuntimeField_8 = 9;
        typeof(SpinKingOutCome).__il2cppRuntimeField_C = 1;
        typeof(SpinKingOutCome).__il2cppRuntimeField_10 = 1065353216;
        Add(item:  380190720);
        SpinKingSlotMachine.outComesConfig = null;
        SpinKingSlotMachine.middleRow = 2;
        SpinKingSlotMachine.spinRandomSet = new RandomSet();
        System.Collections.Generic.List<WordPets.WordPetType> val_13 = new System.Collections.Generic.List<WordPets.WordPetType>();
        if(val_13 != 0)
        {
                Add(item:  1);
            Add(item:  2);
            Add(item:  3);
            Add(item:  4);
        }
        else
        {
                Add(item:  1);
            Add(item:  2);
            Add(item:  3);
            Add(item:  4);
        }
        
        Add(item:  5);
        SpinKingSlotMachine.allSymbolTypes = val_13;
        System.Collections.Generic.List<WordPets.WordPetType> val_14 = new System.Collections.Generic.List<WordPets.WordPetType>();
        if(val_14 != 0)
        {
                Add(item:  3);
            Add(item:  4);
        }
        else
        {
                Add(item:  3);
            Add(item:  4);
        }
        
        Add(item:  5);
        SpinKingSlotMachine.allNonCoinSymbolTypes = val_14;
    }

}
