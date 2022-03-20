using UnityEngine;
public class WGToggleNotificationsToggle : WGMyToggle
{
    // Methods
    protected override void Start()
    {
        var val_2;
        this.Start();
        if(static_value_021FBA0A == 0)
        {
                return;
        }
        
        var val_2 = 25491505;
        val_2 = 10140604 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        this.isOn = true;
    }
    public override void OnToggleChange(bool state)
    {
        if(state != false)
        {
                twelvegigs.plugins.LocalNotificationsPlugin.DisableNotifications();
        }
        else
        {
                twelvegigs.plugins.LocalNotificationsPlugin.EnableNotifications();
        }
        
        this.OnToggleChange(state:  state);
    }
    public WGToggleNotificationsToggle()
    {
    
    }

}
