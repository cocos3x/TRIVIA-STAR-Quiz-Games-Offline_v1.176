using UnityEngine;
public class ScrollIndexCallback2 : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text text;
    public UnityEngine.UI.LayoutElement element;
    private static float[] randomWidths;
    
    // Methods
    private void ScrollCellIndex(int idx)
    {
        var val_6;
        string val_1 = idx.ToString();
        string val_2 = -2007574656(-2007574656) + -2007181556(-2007181556);
        bool val_3 = UnityEngine.Object.op_Inequality(x:  this.text, y:  0);
        val_6 = null;
        val_6 = null;
        int val_6 = UnityEngine.Mathf.Abs(value:  idx);
        var val_7 = 4294967298;
        val_6 = val_6 - val_7;
        val_7 = ScrollIndexCallback2.randomWidths + (val_6 << 2);
        UnityEngine.GameObject val_5 = this.gameObject;
        this.name = -2007574656;
    }
    public ScrollIndexCallback2()
    {
    
    }
    private static ScrollIndexCallback2()
    {
        ScrollIndexCallback2.randomWidths = null;
    }

}
