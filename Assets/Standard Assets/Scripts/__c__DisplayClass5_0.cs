using UnityEngine;
private sealed class ShortcutExtensionsTextMeshProUGUI.<>c__DisplayClass5_0
{
    // Fields
    public TMPro.TextMeshProUGUI target;
    
    // Methods
    public ShortcutExtensionsTextMeshProUGUI.<>c__DisplayClass5_0()
    {
    
    }
    internal UnityEngine.Color <DOFaceFade>b__0()
    {
        UnityEngine.Color32 val_1 = R1 + 8.faceColor;
        UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 128, g = 239, b = 177, a = 125});
        return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    internal void <DOFaceFade>b__1(UnityEngine.Color x)
    {
        UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = x.r, g = x.g, b = x.b, a = x.a});
        this.target.faceColor = new UnityEngine.Color32() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }

}
