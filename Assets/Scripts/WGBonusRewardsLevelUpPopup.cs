using UnityEngine;
public class WGBonusRewardsLevelUpPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text bonusLevelText;
    private UnityEngine.UI.Text newLevelDescText;
    
    // Methods
    private void OnEnable()
    {
        this.DisplayLevelUpAnim();
    }
    private void DisplayLevelUpAnim()
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_2 = GetCurrentRewards();
        string val_4 = (public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_8 - 1).ToString();
        string val_5 = Localization.Localize(key:  -361589312, defaultValue:  -361589456, useSingularKey:  false);
        string val_6 = System.String.Format(format:  -361589312, arg0:  13152256);
        System.Collections.IEnumerator val_7 = this.AnimateThenClose(newLevel:  public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_8);
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -361565184);
    }
    private System.Collections.IEnumerator AnimateThenClose(int newLevel)
    {
        typeof(WGBonusRewardsLevelUpPopup.<AnimateThenClose>d__4).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGBonusRewardsLevelUpPopup.<AnimateThenClose>d__4).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGBonusRewardsLevelUpPopup.<AnimateThenClose>d__4).__il2cppRuntimeField_14 = newLevel;
    }
    public WGBonusRewardsLevelUpPopup()
    {
    
    }

}
