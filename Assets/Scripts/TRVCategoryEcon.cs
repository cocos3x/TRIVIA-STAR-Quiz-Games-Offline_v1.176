using UnityEngine;
public class TRVEcon.TRVCategoryEcon
{
    // Fields
    public string locale;
    public System.Collections.Generic.Dictionary<string, int> categoryUnlockLevels;
    
    // Methods
    public TRVEcon.TRVCategoryEcon(UnityEngine.TextAsset categoryEconData, string localeName)
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_7;
        var val_8;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        this.categoryUnlockLevels = null;
        this.locale = localeName;
        string val_2 = categoryEconData.text;
        val_7 = null;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        val_8 = 0;
        System.String[] val_3 = categoryEconData.Split(separator:  478563824);
        UnityEngine.TextAsset val_4 = categoryEconData + 16;
        goto label_5;
        label_16:
        typeof(System.Char[]).__il2cppRuntimeField_10 = 9;
        System.String[] val_5 = 1152921504765366272.Split(separator:  478563824);
        val_7 = this.categoryUnlockLevels;
        val_7.Add(key:  UnityEngine.TextAsset.__il2cppRuntimeField_byval_arg, value:  System.Int32.Parse(s:  typeof(UnityEngine.TextAsset).__il2cppRuntimeField_14));
        val_8 = 1;
        label_5:
        if(val_8 < val_7)
        {
            goto label_16;
        }
    
    }

}
