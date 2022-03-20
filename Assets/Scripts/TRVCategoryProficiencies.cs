using UnityEngine;
[Serializable]
public class TRVCategoryProficiencies
{
    // Fields
    public string subCat;
    public int defaultPotential;
    public int maxPotential;
    public int currentPotential;
    
    // Methods
    public TRVCategoryProficiencies(string cat, string maxPot, string incDefault)
    {
        string val_1 = cat;
        val_1 = new System.Object();
        this.subCat = val_1;
        if((System.Int32.TryParse(s:  incDefault, result: out  this.defaultPotential)) == false)
        {
                mem2[0] = 0;
        }
        
        if((System.Int32.TryParse(s:  maxPot, result: out  this.maxPotential)) == false)
        {
                mem2[0] = 0;
        }
        
        this.currentPotential = this.defaultPotential;
        typeof(System.Object[]).__il2cppRuntimeField_10 = "cat ";
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_1;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " cur ";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_6 = +472754880;
        UnityEngine.Debug.LogError(message:  472754880);
    }
    public TRVCategoryProficiencies()
    {
    
    }
    public bool Deserialize(string data)
    {
        object val_1 = MiniJSON.Json.Deserialize(json:  data);
        UnityEngine.Debug.LogError(message:  -613522736);
        return false;
    }
    public string Serialize()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = this.currentPotential.ToString();
        Add(key:  -1785508240, value:  this.currentPotential);
        Add(key:  -613522544, value:  this.subCat);
        string val_3 = this.maxPotential.ToString();
        Add(key:  -613522624, value:  this.maxPotential);
        return MiniJSON.Json.Serialize(obj:  78753792);
    }

}
