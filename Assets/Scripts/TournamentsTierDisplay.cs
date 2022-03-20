using UnityEngine;
public class TournamentsTierDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text normalTierText;
    private TMPro.TextMeshProUGUI fancyTierText;
    
    // Methods
    public void RefreshDisplay(int tierIndex)
    {
        var val_8;
        UnityEngine.GameObject val_1 = this.normalTierText.gameObject;
        if(tierIndex != 0)
        {
                tierIndex = 1;
        }
        
        this.normalTierText.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.fancyTierText.gameObject;
        this.fancyTierText.SetActive(value:  this.fancyTierText >> 5);
        val_8 = null;
        val_8 = null;
        System.String[] val_4 = TournamentsEconomy.TierNames + (tierIndex << 2);
        string val_5 = TournamentsEconomy.GetLocalizedTierNameForTierName(tierName:  (TournamentsEconomy.TierNames + (tierIndex) << 2) + 16);
        string val_6 = (TournamentsEconomy.TierNames + (tierIndex) << 2) + 16.ToUpper();
        this.fancyTierText.text = (TournamentsEconomy.TierNames + (tierIndex) << 2) + 16;
        string val_7 = TournamentsEconomy.GetFormattedColorizedTierName(tierIndex:  tierIndex);
        if(this.normalTierText == 0)
        {
            
        }
    
    }
    public TournamentsTierDisplay()
    {
    
    }

}
