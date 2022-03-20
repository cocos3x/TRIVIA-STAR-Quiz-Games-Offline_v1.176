using UnityEngine;
public class EventListItemContentLeaderboard : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text rank_text;
    private UnityEngine.UI.Text rank_suffix_text;
    private UnityEngine.GameObject rank_suffix_plus_text;
    private UnityEngine.UI.Text apples_text;
    
    // Methods
    private void Awake()
    {
        this.rank_suffix_plus_text.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.rank_suffix_text.gameObject;
        this.rank_suffix_text.SetActive(value:  false);
    }
    public void SetupLeaderboardPlayerInfo(string rank, string suffix, string apples)
    {
        UnityEngine.GameObject val_1 = this.rank_suffix_text.gameObject;
        this.rank_suffix_text.SetActive(value:  (System.String.IsNullOrEmpty(value:  suffix)) ^ 1);
        this.rank_suffix_plus_text.SetActive(value:  System.String.IsNullOrEmpty(value:  suffix));
        if(this.apples_text == 0)
        {
            
        }
    
    }
    public EventListItemContentLeaderboard()
    {
    
    }

}
