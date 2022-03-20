using UnityEngine;
[Serializable]
public class TRVCategoryExpertEcon
{
    // Fields
    public string Category;
    public System.Collections.Generic.List<TRVExpert> experts;
    public bool upgradeOnlyEcon;
    
    // Properties
    public string GetLocalizedName { get; }
    
    // Methods
    public string get_GetLocalizedName()
    {
        if(this.upgradeOnlyEcon == true)
        {
                this.upgradeOnlyEcon = this.Category;
            return;
        }
        
        string val_1 = R5.ToLower();
        string val_2 = System.String.Format(format:  -614366592, arg0:  R5);
        string val_3 = R4 + 8.ToUpper();
        return Localization.Localize(key:  -614366592, defaultValue:  R4 + 8, useSingularKey:  false);
    }
    public TRVCategoryExpertEcon()
    {
    
    }

}
