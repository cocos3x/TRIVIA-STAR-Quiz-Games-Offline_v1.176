using UnityEngine;
public class WGToggleSaleBanner : MonoBehaviour
{
    // Fields
    public const string NO_ADS_NOTIF_PROGRESS = "noAdsNotifProg";
    private UnityEngine.CanvasGroup cg;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1056015136);
        this.cg = this;
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1056015136);
        System.Action val_5 = new System.Action(object:  -1056015136, method:  new IntPtr(3238927136));
        if(this != 0)
        {
                mem[1152921512140766456] = null;
        }
        else
        {
                mem[24] = null;
        }
        
        mem[1152921512140766452] = 200;
        this.UpdateDisplay();
    }
    private bool ShouldShowBanner()
    {
        var val_12;
        var val_13;
        val_12 = 1;
        if(WGStarterPackController.featureRelavent == true)
        {
                return (bool)val_12;
        }
        
        val_13 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1566656096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(HaveBundlesToShow() == true)
        {
                return (bool)val_12;
        }
        
        }
        
        if((CPlayerPrefs.GetInt(key:  -1055927136, defaultValue:  0)) == 2)
        {
            goto label_13;
        }
        
        val_13 = 1152921504892043264;
        Player val_7 = App.Player;
        if(0.RemovedAds == false)
        {
            goto label_17;
        }
        
        label_13:
        val_12 = 0;
        return (bool)val_12;
        label_17:
        GameBehavior val_9 = App.getBehavior;
        GameEcon val_10 = App.getGameEcon;
        val_13 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) == false)
        {
                val_12 = 0;
        }
        
        return (bool)val_12;
    }
    private void UpdateDisplay()
    {
        if(this.ShouldShowBanner() == true)
        {
                0f = 1f;
        }
        
        this.cg.alpha = 1f;
    }
    public WGToggleSaleBanner()
    {
    
    }

}
