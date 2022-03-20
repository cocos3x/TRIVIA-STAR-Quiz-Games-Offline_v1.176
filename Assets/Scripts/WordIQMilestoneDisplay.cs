using UnityEngine;
public class WordIQMilestoneDisplay : MonoBehaviour
{
    // Fields
    private string[] milestoneHexColors;
    private UnityEngine.GameObject mortarBoardBG;
    private UnityEngine.UI.Image mortarBoard;
    private UnityEngine.UI.Image upgradeGlow;
    private UnityEngine.UI.Image upgradeArrow;
    private UnityEngine.ParticleSystem upgradeBurst;
    
    // Methods
    public void UpdateMilestoneDisplay(int newMilestoneIndex)
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_2 = MilestoneColorableSprite;
        val_4 = public static WordIQManagerUI MonoSingleton<WordIQManagerUI>::get_Instance();
        this.mortarBoard.sprite = -930643664;
        if(this.mortarBoard == 0)
        {
                val_4 = 0;
        }
        
        string val_4 = this.milestoneHexColors[0];
        UnityEngine.Color val_3 = GetColorFromHexColor(colorString:  null);
        this.mortarBoard.color = new UnityEngine.Color() {a = ???};
    }
    public float GetMilestoneUpdateAnimTime()
    {
        return (float)S0;
    }
    public void AnimateMilestoneUpdate(int newMilestoneIndex)
    {
        if(new System.Object() != 0)
        {
                typeof(WordIQMilestoneDisplay.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(WordIQMilestoneDisplay.<>c__DisplayClass8_0).__il2cppRuntimeField_C = newMilestoneIndex;
    }
    public void PlayBurstUpdateDisplay(int newMilestoneIndex)
    {
        this.UpdateMilestoneDisplay(newMilestoneIndex:  newMilestoneIndex);
    }
    private UnityEngine.Color GetColorFromHexColor(string colorString)
    {
        var val_4;
        if((System.String.op_Equality(a:  R2, b:  -913862016)) != false)
        {
                val_4 = this;
        }
        else
        {
                val_4 = this;
        }
        
        UnityEngine.Color val_3 = MetricSystem.HexToColor(hex:  -913837856);
        return new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    public WordIQMilestoneDisplay()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "6A6A6A";
        typeof(System.String[]).__il2cppRuntimeField_14 = "FDF022";
        typeof(System.String[]).__il2cppRuntimeField_18 = "3CFF00";
        typeof(System.String[]).__il2cppRuntimeField_1C = "02EAAB";
        typeof(System.String[]).__il2cppRuntimeField_20 = "028FF2";
        typeof(System.String[]).__il2cppRuntimeField_24 = "FF0000";
        typeof(System.String[]).__il2cppRuntimeField_28 = "FF7800";
        typeof(System.String[]).__il2cppRuntimeField_2C = "9600FF";
        typeof(System.String[]).__il2cppRuntimeField_30 = "FFFFFF";
        typeof(System.String[]).__il2cppRuntimeField_34 = "GOLD";
        this.milestoneHexColors = null;
    }

}
