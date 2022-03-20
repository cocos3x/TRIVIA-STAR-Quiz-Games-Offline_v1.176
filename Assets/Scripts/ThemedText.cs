using UnityEngine;
public class ThemedText : MonoBehaviour
{
    // Fields
    public string textTypeTag;
    
    // Methods
    public void ApplyThemeTextSettings(ThemeTextSettings newText)
    {
        bool val_16;
        var val_17;
        ThemedText val_18;
        var val_19;
        var val_20;
        string val_21;
        var val_22;
        object val_1 = this.GetComponent<System.Object>();
        val_16 = this;
        this.font = newText.font;
        T[] val_2 = this.GetComponents<System.Object>();
        val_18 = this;
        val_19 = 0;
        goto label_4;
        label_40:
        val_17 = 0;
        if(0 != 0)
        {
                val_16 = mem[1179403827];
            if(((mem[1179403747] + (UnityEngine.UI.Outline.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_17 = 0;
        }
        
        if(0 == 0)
        {
            goto label_10;
        }
        
        if(newText.outline == true)
        {
                newText.outline = 1;
        }
        
        val_17.enabled = true;
        if(newText.outline == false)
        {
            goto label_13;
        }
        
        val_17.effectColor = new UnityEngine.Color() {r = newText.outlineColor, g = val_16, b = 1.401298E-45f, a = val_18};
        val_17.effectDistance = new UnityEngine.Vector2() {x = mem[newText.outlineOffset + (0)], y = mem[newText.outlineOffset + (4)]};
        val_18 = val_18;
        goto label_29;
        label_10:
        if(newText.font == 0)
        {
            goto label_34;
        }
        
        if(newText.shadow == true)
        {
                newText.shadow = 1;
        }
        
        val_17.enabled = true;
        if(newText.shadow == false)
        {
            goto label_24;
        }
        
        1.effectColor = new UnityEngine.Color() {r = newText.shadowColor, g = val_16, b = 0f, a = 1152921512516934416};
        val_18 = val_18;
        1.effectDistance = new UnityEngine.Vector2() {x = mem[newText.shadowOffset + (0)], y = mem[newText.shadowOffset + (4)]};
        goto label_29;
        label_13:
        if(UnityEngine.Application.isPlaying == true)
        {
            goto label_34;
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        string val_7 = NGUITools.GetHierarchy(obj:  -679847168);
        val_20 = this;
        val_21 = newText.useCaseName;
        val_22 = "You can remove Outline from ";
        goto label_33;
        label_24:
        if(UnityEngine.Application.isPlaying == true)
        {
            goto label_34;
        }
        
        UnityEngine.GameObject val_9 = this.gameObject;
        string val_10 = NGUITools.GetHierarchy(obj:  -679847168);
        val_20 = this;
        val_21 = newText.useCaseName;
        val_22 = "You can remove Shadow from ";
        label_33:
        val_17 = 0;
        string val_11 = -679872464(-679872464) + -679847168(-679847168) + -679872336(-679872336) + val_21;
        UnityEngine.Debug.LogError(message:  -679872464);
        label_29:
        label_34:
        val_19 = 1;
        label_4:
        if(val_19 < mem[1152921512516934412])
        {
            goto label_40;
        }
        
        bool val_16 = newText.outline;
        val_16 = val_16 >> 5;
        val_16 = 1 | val_16;
        if(val_16 == true)
        {
                UnityEngine.GameObject val_12 = this.gameObject;
            object val_13 = this.AddComponent<System.Object>();
            val_16 = this;
            this.effectColor = new UnityEngine.Color() {r = mem[newText.outlineColor + (0)], g = mem[newText.outlineColor + (4)], b = mem[newText.outlineColor + (8)], a = this};
            this.effectDistance = new UnityEngine.Vector2() {x = mem[newText.outlineOffset + (0)], y = mem[newText.outlineOffset + (4)]};
        }
        
        if(newText.shadow == true)
        {
                newText.shadow = 1;
            newText.shadow = 0;
        }
        
        if(newText.shadow == 1)
        {
                return;
        }
        
        UnityEngine.GameObject val_14 = this.gameObject;
        object val_15 = this.AddComponent<System.Object>();
        this.effectColor = new UnityEngine.Color() {r = mem[newText.shadowColor + (0)], g = mem[newText.shadowColor + (4)], b = mem[newText.shadowColor + (8)], a = this};
        this.effectDistance = new UnityEngine.Vector2() {x = mem[newText.shadowOffset + (0)], y = mem[newText.shadowOffset + (4)]};
    }
    public void UpdateThemeTextSettings(ThemeTextSettings themeText)
    {
        UnityEngine.Font val_13;
        bool val_14;
        var val_15;
        var val_16;
        UnityEngine.Vector2 val_17;
        ThemeTextSettings val_18;
        object val_1 = this.GetComponent<System.Object>();
        val_13 = this;
        UnityEngine.Font val_2 = this.font;
        themeText.font = val_13;
        T[] val_3 = this.GetComponents<System.Object>();
        ThemeTextSettings val_4 = themeText + 88;
        val_15 = 0;
        goto label_4;
        label_28:
        val_13 = 0;
        if(0 != 0)
        {
                val_14 = mem[1179403827];
            if(((mem[1179403747] + (UnityEngine.UI.Outline.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_13 = 0;
        }
        
        if(0 == 0)
        {
            goto label_10;
        }
        
        val_14 = val_13.enabled;
        themeText.outline = val_14;
        if(val_13 == 0)
        {
            goto label_13;
        }
        
        var val_8 = val_13 + 16;
        goto label_14;
        label_10:
        if(0 == 0)
        {
            goto label_18;
        }
        
        bool val_10 = val_13.enabled;
        themeText.shadow = val_10;
        bool val_11 = val_10 + 16;
        val_16 = val_10 + 32;
        goto label_26;
        label_13:
        var val_12 = val_13 + 16;
        label_14:
        val_16 = val_13 + 32;
        val_17 = themeText.outlineOffset;
        val_18 = themeText + 60;
        label_26:
        mem2[0] = val_16;
        mem2[0] = (val_13 + 32) + 4;
        label_18:
        val_15 = 1;
        label_4:
        if(val_15 < this.textTypeTag)
        {
            goto label_28;
        }
        
        if(1 == 1)
        {
                themeText.outline = false;
        }
        
        if(1 != 1)
        {
                return;
        }
        
        themeText.shadow = false;
    }
    public ThemedText()
    {
        this.textTypeTag = "";
    }

}
