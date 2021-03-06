using UnityEngine;
public class TRVSubCategoryDictionary
{
    // Fields
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> subCategories;
    private string language;
    
    // Properties
    public string GetLanguage { get; }
    
    // Methods
    public string get_GetLanguage()
    {
    
    }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> GetSubCategories(string currentLocale)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_6;
        bool val_7;
        val_6 = this;
        val_7 = static_value_021FAC0D;
        if(val_7 != true)
        {
                val_7 = true;
        }
        
        string val_1 = this.ParseLanguageFromLocale(currentLocale:  currentLocale);
        bool val_2 = this.language.Equals(value:  1);
        if(val_2 != false)
        {
                val_6 = this.subCategories;
            return;
        }
        
        string val_3 = val_2.ParseLanguageFromLocale(currentLocale:  currentLocale);
        this.language = val_2;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_4 = TRVDataParser.LoadCategoryInfo(currentLanguage:  val_2);
        this.subCategories = val_2;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Init(forceUpdate:  true);
    }
    public TRVSubCategoryDictionary(string currentLocale)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.subCategories = null;
        this.language = "";
        string val_2 = this.ParseLanguageFromLocale(currentLocale:  currentLocale);
        this.language = this;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_3 = TRVDataParser.LoadCategoryInfo(currentLanguage:  -533351488);
        this.subCategories = this;
    }
    private string ParseLanguageFromLocale(string currentLocale)
    {
        typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
        System.String[] val_1 = currentLocale.Split(separator:  478563824);
        if(currentLocale.m_firstChar != ' ')
        {
                return;
        }
    
    }

}
