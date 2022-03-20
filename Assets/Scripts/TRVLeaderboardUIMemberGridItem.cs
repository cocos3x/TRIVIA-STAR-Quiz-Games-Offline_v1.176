using UnityEngine;
public class TRVLeaderboardUIMemberGridItem : LeaderboardUIMemberGridItem
{
    // Fields
    private UnityEngine.Sprite firstPlaceBadge;
    private UnityEngine.Sprite secondPlaceBadge;
    private UnityEngine.Sprite thirdPlaceBadge;
    private UnityEngine.UI.Image awardImage;
    
    // Methods
    public override void UpdateUIFromMember(LeaderboardPlayerInfo info)
    {
        UnityEngine.Sprite val_4;
        this.UpdateUIFromMember(info:  info);
        string val_1 = info.ToString(format:  -1774412176);
        UnityEngine.GameObject val_2 = this.awardImage.gameObject;
        if(info < 4)
        {
                0 = 1;
        }
        
        this.awardImage.SetActive(value:  true);
        UnityEngine.GameObject val_3 = this.awardImage.gameObject;
        if(info > 3)
        {
                0 = 1;
        }
        
        this.awardImage.SetActive(value:  true);
        if(info > 3)
        {
                return;
        }
        
        if(info == 1)
        {
                val_4 = this.firstPlaceBadge;
        }
        else
        {
                if(info == 2)
        {
                val_4 = this.secondPlaceBadge;
        }
        else
        {
                if(info != 3)
        {
                return;
        }
        
            val_4 = this.thirdPlaceBadge;
        }
        
        }
        
        this.awardImage.sprite = val_4;
    }
    public TRVLeaderboardUIMemberGridItem()
    {
    
    }

}
