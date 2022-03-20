using UnityEngine;
public class EventListItemContentVipParty : EventListItemContent
{
    // Fields
    private UnityEngine.UI.Text vipStatus;
    
    // Methods
    public void SetupVipStatus(bool isVIP)
    {
        if(isVIP == true)
        {
                "BECOME VIP NOW" = "VIP PRIVILEGES";
        }
        
        if(isVIP == true)
        {
                "become_vip_now_upper" = "vip_privileges_upper";
        }
        
        string val_1 = Localization.Localize(key:  -987149968, defaultValue:  -987150160, useSingularKey:  false);
        if(this.vipStatus == 0)
        {
            
        }
    
    }
    public EventListItemContentVipParty()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
