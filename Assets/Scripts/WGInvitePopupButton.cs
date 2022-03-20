using UnityEngine;
public class WGInvitePopupButton : MyButton
{
    // Fields
    private UnityEngine.UI.Slider tierProgression;
    private UnityEngine.UI.Text invitesProgressionText;
    private UnityEngine.GameObject notificationIcon;
    private UnityEngine.GameObject completedGroup;
    
    // Methods
    protected override void Start()
    {
        this.Start();
        if(WGInviteManager.IsEnabled != false)
        {
                NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -9632752, name:  -2037002944);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -9632752, name:  -13064528);
            if(WGInviteManager.isV2 == false)
        {
                return;
        }
        
            R4.SetupProgression();
            return;
        }
        
        UnityEngine.GameObject val_5 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnInvitesReady()
    {
        if(WGInviteManager.isV2 == false)
        {
                return;
        }
        
        R4.SetupProgression();
    }
    private void SetupProgression()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_2 = InvitesCollected;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_5 = NextTargetTierInvites();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_16 = (float)(val_5 - public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance().__il2cppRuntimeField_18);
        val_16 = ((float)(val_2 - public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance().__il2cppRuntimeField_18)) / val_16;
        string val_9 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(InvitesCollected >= NextTargetTierInvites())
        {
                0 = 1;
        }
        
        this.notificationIcon.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(InvitesCollected >= NextTargetTierInvites())
        {
                0 = 1;
        }
        
        this.completedGroup.SetActive(value:  true);
    }
    private void OnDeferredReady()
    {
        UnityEngine.GameObject val_1 = R4.gameObject;
        R4.SetActive(value:  WGInviteManager.IsEnabled);
    }
    public override void OnButtonClick()
    {
        WGInvite val_1 = WGInviteManager.ShowInvitePopup(status:  0);
        this.OnButtonClick();
    }
    public WGInvitePopupButton()
    {
    
    }

}
