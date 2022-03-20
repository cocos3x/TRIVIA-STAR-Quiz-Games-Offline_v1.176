using UnityEngine;
public class MysteryGiftManager : MonoSingleton<MysteryGiftManager>
{
    // Fields
    private bool recentlyLeveledUp;
    
    // Methods
    public void OnPlayerLevelUp()
    {
        this.recentlyLeveledUp = true;
    }
    public void OnSceneChange()
    {
        var val_11;
        var val_12;
        val_11 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        GameEcon val_2 = App.getGameEcon;
        val_12 = 0;
        if(0 != 342)
        {
                return;
        }
        
        if(WGSubscriptionManager.WillGetFreeTrial_Golden == false)
        {
                return;
        }
        
        if(WGSubscriptionManager.HasSubscribedGoldenTicket == true)
        {
                return;
        }
        
        Player val_5 = App.Player;
        if(static_value_0028010C == true)
        {
                return;
        }
        
        if((R4 + 12) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
        Player val_8 = App.Player;
        Player val_9 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public void OnGameSceneBegan()
    {
        var val_11;
        var val_12;
        val_11 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        GameEcon val_2 = App.getGameEcon;
        val_12 = 0;
        if(0 < 342)
        {
                GameEcon val_3 = App.getGameEcon;
            val_12 = 0;
            if((35671444 == 0) && (WGSubscriptionManager.WillGetFreeTrial_Golden != false))
        {
                if((WGSubscriptionManager.HasSubscribedGoldenTicket != true) && (this.recentlyLeveledUp != false))
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_7 = Localization.Localize(key:  -1150399584, defaultValue:  -1150399456, useSingularKey:  false);
            GameEcon val_8 = App.getGameEcon;
            val_11 = 0;
            string val_9 = System.String.Format(format:  -1150399584, arg0:  13152256);
            val_12 = "mystery_gift_reach_level";
            bool val_10 = ShowMessage(message:  -1150399584);
        }
        
        }
        
        }
        
        this.recentlyLeveledUp = false;
    }
    public MysteryGiftManager()
    {
    
    }

}
