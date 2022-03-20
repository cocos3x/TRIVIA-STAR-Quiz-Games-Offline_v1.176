using UnityEngine;
public class PiggyBankV2Econ
{
    // Fields
    private int[] packagePrices;
    private int[] goldCurrencyNeeded;
    private int[] minBankFund;
    private int[] maxBankFund;
    private string[] packageTierIDs;
    public const int playerSpendLow = 399;
    public const int playerSpendMid = 899;
    public const int playerSpendHigh = 1499;
    
    // Properties
    public int[] PackagePrices { get; }
    public int[] GoldCurrencyNeeded { get; }
    public int[] MinBankFund { get; }
    public int[] MaxBankFund { get; }
    public string[] PackageTierIDs { get; }
    
    // Methods
    public int[] get_PackagePrices()
    {
    
    }
    public int[] get_GoldCurrencyNeeded()
    {
    
    }
    public int[] get_MinBankFund()
    {
    
    }
    public int[] get_MaxBankFund()
    {
    
    }
    public string[] get_PackageTierIDs()
    {
    
    }
    public PiggyBankV2Econ()
    {
        this.packagePrices = null;
        this.goldCurrencyNeeded = null;
        this.minBankFund = null;
        this.maxBankFund = null;
        typeof(System.String[]).__il2cppRuntimeField_10 = "id_piggy_bank_tier0";
        typeof(System.String[]).__il2cppRuntimeField_14 = "id_piggy_bank_tier1";
        typeof(System.String[]).__il2cppRuntimeField_18 = "id_piggy_bank_tier2";
        typeof(System.String[]).__il2cppRuntimeField_1C = "id_piggy_bank_tier3";
        typeof(System.String[]).__il2cppRuntimeField_20 = "id_piggy_bank_tier4";
        typeof(System.String[]).__il2cppRuntimeField_24 = "id_piggy_bank_tier5";
        this.packageTierIDs = null;
    }

}
