using UnityEngine;
public class ThemeTextSettings : ScriptableObject
{
    // Fields
    public UnityEngine.Font font;
    public UnityEngine.Color color;
    public int size;
    public bool outline;
    public UnityEngine.Color outlineColor;
    public UnityEngine.Vector2 outlineOffset;
    public bool shadow;
    public UnityEngine.Color shadowColor;
    public UnityEngine.Vector2 shadowOffset;
    public string useCaseName;
    public System.Collections.Generic.List<string> usedBy;
    
    // Methods
    public void Populate(UnityEngine.UI.Text newText)
    {
        UnityEngine.GameObject val_17;
        UnityEngine.Vector2 val_18;
        var val_19;
        ThemeTextSettings val_20;
        UnityEngine.GameObject val_1 = newText.gameObject;
        val_17 = newText;
        string val_2 = NGUITools.GetHierarchy(obj:  val_17);
        this.usedBy.Add(item:  val_17);
        if(newText != 0)
        {
                UnityEngine.Font val_3 = newText.font;
            this.font = newText;
        }
        else
        {
                UnityEngine.Font val_4 = 0.font;
            this.font = 0;
        }
        
        UnityEngine.Color val_5 = color;
        this.size = newText.fontSize;
        this.shadow = false;
        this.outline = false;
        T[] val_7 = newText.GetComponents<System.Object>();
        if(newText == 0)
        {
                return;
        }
        
        if(newText < 1)
        {
                return;
        }
        
        UnityEngine.UI.Text val_8 = newText + 16;
        var val_19 = 0;
        label_41:
        val_17 = 0;
        if(null != 0)
        {
                val_17 = 0;
        }
        
        if(0 == 0)
        {
            goto label_17;
        }
        
        if(this.outline != false)
        {
                UnityEngine.GameObject val_10 = newText.gameObject;
            string val_11 = NGUITools.GetHierarchy(obj:  newText);
            string val_12 = -680386832(-680386832) + newText;
            UnityEngine.Debug.LogError(message:  -680386832);
        }
        
        this.outline = true;
        if(val_17 == 0)
        {
            goto label_24;
        }
        
        var val_13 = val_17 + 16;
        goto label_25;
        label_17:
        if(208465920 == 0)
        {
            goto label_29;
        }
        
        if(this.shadow != false)
        {
                UnityEngine.GameObject val_15 = newText.gameObject;
            string val_16 = NGUITools.GetHierarchy(obj:  newText);
            string val_17 = -680386608(-680386608) + newText;
            UnityEngine.Debug.LogError(message:  -680386608);
        }
        
        this.shadow = true;
        val_18 = this.shadowOffset;
        val_20 = 1152921512516419272;
        goto label_40;
        label_24:
        var val_18 = val_17 + 16;
        label_25:
        val_19 = val_17 + 32;
        val_18 = this.outlineOffset;
        val_20 = 1152921512516419244;
        label_40:
        mem2[0] = val_19;
        mem[1152921512516419244] = (val_17 + 32) + 4;
        label_29:
        val_19 = val_19 + 1;
        if(val_19 < ((val_17 + 32) + 4))
        {
            goto label_41;
        }
    
    }
    public bool Matches(ThemeTextSettings other)
    {
        UnityEngine.Font val_4;
        UnityEngine.Font val_5;
        val_4 = this.font;
        val_5 = other.font;
        if(val_4 != val_5)
        {
                return false;
        }
        
        ThemeTextSettings val_2 = other + 20;
        val_5 = other.color;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = mem[this.color + (0)], g = mem[this.color + (4)], b = mem[this.color + (8)], a = mem[this.color + (12)]}, rhs:  new UnityEngine.Color() {r = val_5, g = mem[(other + 20) + (0)], b = mem[(other + 20) + (4)], a = mem[(other + 20) + (8)]})) == true)
        {
                return false;
        }
        
        if(other.outline == true)
        {
                other.outline = 1;
        }
        
        if(this.outline == true)
        {
                this.outline = 1;
        }
        
        if(1 != 1)
        {
                return false;
        }
        
        bool val_4 = this.shadow;
        val_4 = val_4 >> 5;
        if(other.shadow == true)
        {
                other.shadow = 1;
        }
        
        val_4 = val_4 ^ 1;
        return (bool)val_4;
    }
    public string GetDescriptiveName(string colorHex)
    {
        string val_1 = this.font.name;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.font;
        typeof(System.Object[]).__il2cppRuntimeField_14 = colorHex;
        if(this.outline == false)
        {
                "_O" = "";
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_18 = "";
        if(this.shadow == false)
        {
                "_S" = "";
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_1C = "";
        return System.String.Format(format:  -680121424, args:  472754880);
    }
    public ThemeTextSettings()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.usedBy = null;
    }

}
