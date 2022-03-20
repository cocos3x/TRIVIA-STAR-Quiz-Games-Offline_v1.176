using UnityEngine;
public class ThemeAssetTable
{
    // Fields
    public System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> sprites;
    public System.Collections.Generic.Dictionary<string, UnityEngine.Texture> textures;
    public System.Collections.Generic.Dictionary<string, UnityEngine.Color> contextColors;
    public UIThemeTemplate[] templates;
    public ThemeSettings themeSettings;
    public System.Collections.Generic.List<ThemeTextSettings> themeTextSettings;
    private System.Collections.Generic.Dictionary<string, UIThemeTemplate> cachedThemeTemplates;
    private System.Collections.Generic.Dictionary<string, ThemeTextSettings> cachedTextSettings;
    
    // Properties
    public System.Collections.Generic.Dictionary<string, UIThemeTemplate> CachedThemeTemplates { get; }
    public System.Collections.Generic.Dictionary<string, ThemeTextSettings> CachedTextSettings { get; }
    
    // Methods
    public System.Collections.Generic.Dictionary<string, UIThemeTemplate> get_CachedThemeTemplates()
    {
        System.Collections.Generic.Dictionary<System.String, UIThemeTemplate> val_14;
        UIThemeTemplate[] val_15;
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.Dictionary<System.String, UIThemeTemplate> val_22;
        UIThemeTemplate val_23;
        string val_24;
        var val_25;
        val_14 = this.cachedThemeTemplates;
        if(val_14 != 0)
        {
                return;
        }
        
        val_15 = this.templates;
        val_14 = null;
        val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.cachedThemeTemplates = val_14;
        if(val_15 == null)
        {
                return;
        }
        
        val_16 = 0;
        val_17;
        goto label_3;
        label_50:
        UIThemeTemplate val_14 = this.templates[0];
        if(this.templates[0x0][0].gameObject != 0)
        {
            goto label_9;
        }
        
        string val_3 = 0.ToString();
        val_18 = val_17;
        val_19 = "Theme is missing template GameObject at index ";
        val_20 = ". Skipping this template.";
        goto label_10;
        label_9:
        UIThemeTemplate val_15 = this.templates[0];
        object val_4 = this.templates[0x0][0].gameObject.GetComponent<System.Object>();
        if((this.templates[0x0][0].gameObject == 0) || (R7 == 0))
        {
            goto label_21;
        }
        
        val_22 = this.cachedThemeTemplates;
        string val_7 = this.templates[0x0][0].gameObject.name;
        val_21 = this.templates[0x0][0].gameObject;
        val_23 = this.templates[0];
        val_24 = val_21;
        val_25 = 1152921512518817168;
        goto label_26;
        label_21:
        UIThemeTemplate val_16 = this.templates[0];
        object val_8 = this.templates[0x0][0].gameObject.GetComponent<System.Object>();
        if((this.templates[0x0][0].gameObject == 0) || (R7 == 0))
        {
            goto label_37;
        }
        
        val_22 = this.cachedThemeTemplates;
        string val_11 = this.templates[0x0][0].gameObject.name;
        val_21 = 0;
        val_23 = this.templates[val_21];
        val_24 = this.templates[0x0][0].gameObject;
        val_25 = 1152921512518817168;
        label_26:
        val_22.Add(key:  val_24, value:  val_23);
        val_17;
        goto label_42;
        label_37:
        UIThemeTemplate val_17 = this.templates[0];
        string val_12 = this.templates[0x0][0].gameObject.name;
        val_18 = this.templates[0x0][0].gameObject;
        val_19 = "Couldn\'t cache theme template for ";
        val_20 = " because no Image or RawImage was found on the template object.";
        label_10:
        string val_13 = -677827184(-677827184) + val_18 + -677827040(-677827040);
        UnityEngine.Debug.LogError(message:  -677827184);
        label_42:
        val_16 = 0 + 1;
        label_3:
        val_15 = this.templates;
        if(val_16 < 0)
        {
            goto label_50;
        }
        
        val_14 = this.cachedThemeTemplates;
    }
    public System.Collections.Generic.Dictionary<string, ThemeTextSettings> get_CachedTextSettings()
    {
        System.Collections.Generic.Dictionary<System.String, ThemeTextSettings> val_7;
        System.Collections.Generic.List<ThemeTextSettings> val_8;
        var val_9;
        val_7 = this.cachedTextSettings;
        if(val_7 != 0)
        {
                return;
        }
        
        val_8 = this.themeTextSettings;
        val_7 = null;
        val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.cachedTextSettings = val_7;
        if(val_8 == 0)
        {
                return;
        }
        
        val_9 = "Couldn\'t cache index ";
        label_21:
        val_8 = this.themeTextSettings;
        if(0 >= val_7)
        {
            goto label_4;
        }
        
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_2 = UnityEngine.Object.op_Inequality(x:  public System.Void System.Collections.Generic.Dictionary<System.String, ThemeTextSettings>::.ctor().__il2cppRuntimeField_10, y:  0);
        if(val_2 == false)
        {
            goto label_13;
        }
        
        if(val_2 <= false)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + 0;
        bool val_3 = System.String.IsNullOrEmpty(value:  (0 + 0) + 16 + 92);
        if(val_3 == true)
        {
            goto label_13;
        }
        
        if(val_3 <= false)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + 0;
        val_9 = "Couldn\'t cache index ";
        bool val_4 = this.cachedTextSettings.ContainsKey(key:  (0 + 0) + 16 + 92);
        if(val_4 == false)
        {
            goto label_18;
        }
        
        label_13:
        string val_5 = 0.ToString();
        string val_6 = -677311376(-677311376) + -677261112(-677261112) + -677290784(-677290784);
        UnityEngine.Debug.LogError(message:  -677311376);
        label_28:
        var val_7 = 0 + 1;
        goto label_21;
        label_18:
        if(val_4 <= false)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 0;
        if(val_10 <= 0)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 0;
        this.cachedTextSettings.Add(key:  (0 + 0) + 16 + 92, value:  (0 + 0) + 16);
        goto label_28;
        label_4:
        val_7 = this.cachedTextSettings;
    }
    public ThemeAssetTable()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.sprites = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.textures = null;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Color> val_3 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color>();
        this.contextColors = null;
    }

}
