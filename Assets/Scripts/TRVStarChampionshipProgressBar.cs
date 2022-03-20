using UnityEngine;
public class TRVStarChampionshipProgressBar : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform giftIcons;
    private UnityEngine.Transform completedIcons;
    private UnityEngine.UI.Image progressFill;
    
    // Methods
    public void UpdateProgressBar(float progress, int tier)
    {
        var val_5 = 0;
        this.progressFill.fillAmount = progress;
        do
        {
            UnityEngine.Transform val_1 = this.giftIcons.GetChild(index:  0);
            UnityEngine.GameObject val_2 = this.giftIcons.gameObject;
            if(val_5 > R2)
        {
                0 = 1;
        }
        
            this.giftIcons.SetActive(value:  true);
            UnityEngine.Transform val_3 = this.completedIcons.GetChild(index:  0);
            UnityEngine.GameObject val_4 = this.completedIcons.gameObject;
            if(val_5 <= R2)
        {
                0 = 1;
        }
        
            this.completedIcons.SetActive(value:  true);
            val_5 = val_5 + 1;
        }
        while(val_5 != 4);
    
    }
    public TRVStarChampionshipProgressBar()
    {
    
    }

}
