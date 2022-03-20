using UnityEngine;
public class AdConfig
{
    // Fields
    public int UnlockLevel;
    public int InterstitialSeconds;
    public bool Enabled;
    public System.DateTime LastInterstitial;
    public System.Collections.Generic.List<InterstitialContext> AllowedContext;
    
    // Methods
    public override string ToString()
    {
        var val_4;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        string val_1 = MiniJSON.Json.Serialize(obj:  this.AllowedContext);
        typeof(System.Object[]).__il2cppRuntimeField_1C = this.AllowedContext;
        string val_2 = System.String.Format(format:  -1891572880, args:  472754880);
        val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_4 == 1)
        {
                val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_3 = System.String.Format(format:  -1891572880, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public AdConfig()
    {
        var val_2;
        var val_4;
        this.UnlockLevel = 257698037786;
        this.Enabled = true;
        val_2 = null;
        val_2 = null;
        this.LastInterstitial = System.DateTime.MinValue;
        System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
        if(null != 0)
        {
                val_4 = 1152921511298379280;
            Add(item:  1);
            Add(item:  2);
        }
        else
        {
                val_4 = 1152921511298379280;
            Add(item:  1);
            Add(item:  2);
        }
        
        Add(item:  3);
        this.AllowedContext = null;
    }

}
