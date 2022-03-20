using UnityEngine;
public class WGOnTheTrailDayItem : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject rewardAmountGroup;
    private UnityEngine.UI.Text reward;
    private UnityEngine.UI.Text day;
    private UnityEngine.GameObject[] goldenAppleIcons;
    private UnityEngine.UI.Image progressImg;
    private UnityEngine.Sprite successSp;
    private UnityEngine.Sprite failSp;
    
    // Methods
    public void Setup(OnTheTrailEvent.OnTheTrailDayItemStatus status, int day, int reward = 0)
    {
        string val_1 = Localization.Localize(key:  -1141456624, defaultValue:  -1141456528, useSingularKey:  false);
        string val_2 = System.String.Format(format:  1592589744, arg0:  -1141456624, arg1:  13152256);
        if(status == 2)
        {
                this.SetPendingIcons(active:  true);
            string val_3 = reward.ToString();
            if(this.reward != 0)
        {
                return;
        }
        
            return;
        }
        
        if(status == 0)
        {
                36 = 32;
        }
        
        this.day = this.progressImg;
        this.day.sprite = this.successSp;
        this.SetPendingIcons(active:  false);
    }
    private void SetPendingIcons(bool active)
    {
        UnityEngine.GameObject val_3;
        var val_4;
        val_3 = this.rewardAmountGroup;
        val_4 = 0;
        val_3.SetActive(value:  active);
        goto label_1;
        label_5:
        1152921507209181152.SetActive(value:  active);
        val_4 = 1;
        label_1:
        if(val_4 < 1152921507209181152)
        {
            goto label_5;
        }
        
        UnityEngine.GameObject val_1 = this.progressImg.gameObject;
        this.progressImg.SetActive(value:  active ^ 1);
    }
    public WGOnTheTrailDayItem()
    {
    
    }

}
