using UnityEngine;
public class WGDailyChallengeDayToggle : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text number;
    private UnityEngine.Color complete_text_color;
    private UnityEngine.Color incomplete_text_color;
    private UnityEngine.GameObject complete_group;
    private UnityEngine.GameObject incomplete_group;
    
    // Methods
    public void SetComplete(bool complete)
    {
        var val_2;
        var val_3;
        var val_4;
        UnityEngine.Color val_5;
        this.complete_group.SetActive(value:  complete);
        this.incomplete_group.SetActive(value:  complete ^ 1);
        if(complete != false)
        {
                val_2 = 1152921513094428524;
            val_3 = 1152921513094428520;
            val_4 = 1152921513094428516;
            val_5 = this.complete_text_color;
        }
        else
        {
                val_2 = 1152921513094428540;
            val_3 = 1152921513094428536;
            val_4 = 1152921513094428532;
            val_5 = this.incomplete_text_color;
        }
        
        this.number.color = new UnityEngine.Color() {r = this.incomplete_text_color.r, g = 4.099552E-25f, b = 4.099552E-25f};
    }
    public WGDailyChallengeDayToggle()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.gray;
    }

}
