using UnityEngine;
public class EditProfileButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    
    // Methods
    private void Awake()
    {
        if(this.ProfileUnlocked() != true)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            this.SetActive(value:  false);
        }
        
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1720745472, method:  new IntPtr(2574196800));
        this.button.m_OnClick.AddListener(call:  162246656);
    }
    private void OnButtonClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private bool ProfileUnlocked()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = 1152921504892043264;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        val_6 = 1;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  5614709)) == true)
        {
                return true;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 != 0)
        {
                val_5 = 8834124 + 26794830;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_7 = null;
            val_7 = null;
            if(TournamentsManager.pp_last_tournament != null)
        {
                return true;
        }
        
        }
        
        var val_5 = 26793164;
        val_5 = 8834260 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(LeaderboardEventHandler.instance != 0)
        {
                val_6 = 1;
        }
        
        return true;
    }
    public EditProfileButton()
    {
    
    }

}
