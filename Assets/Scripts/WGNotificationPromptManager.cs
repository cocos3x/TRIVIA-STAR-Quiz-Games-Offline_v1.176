using UnityEngine;
public class WGNotificationPromptManager : MonoSingleton<WGNotificationPromptManager>
{
    // Fields
    private const string timesPrompted = "notifPromptAppearances";
    private const string notifPromptTracking = "nextNotifAtDate";
    
    // Properties
    private System.DateTime notifyAtDate { get; set; }
    private int numTimesSeen { get; set; }
    private bool promptEnabled { get; }
    
    // Methods
    private System.DateTime get_notifyAtDate()
    {
        var val_4;
        var val_5;
        if((CPlayerPrefs.HasKey(key:  26256320)) != false)
        {
                string val_2 = CPlayerPrefs.GetString(key:  26256320);
            val_4 = null;
            val_4 = null;
            System.DateTime val_3 = SLCDateTime.Parse(dateTime:  26280432, defaultValue:  new System.DateTime() {dateData = 1152921513223037888});
            return new System.DateTime() {dateData = val_3.dateData};
        }
        
        val_5 = null;
        val_5 = null;
        this = System.DateTime.MinValue;
        return new System.DateTime() {dateData = System.DateTime.MinValue};
    }
    private void set_notifyAtDate(System.DateTime value)
    {
        string val_1 = ???.ToString();
        CPlayerPrefs.SetString(key:  26256320, val:  26380408);
    }
    private int get_numTimesSeen()
    {
        return CPlayerPrefs.GetInt(key:  26480432, defaultValue:  0);
    }
    private void set_numTimesSeen(int value)
    {
        CPlayerPrefs.SetInt(key:  26480432, val:  value);
    }
    private bool get_promptEnabled()
    {
        GameEcon val_1 = App.getGameEcon;
        if(576 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool ShouldShowNotif()
    {
        return false;
    }
    public void SetPromptSeen()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        GameEcon val_4 = App.getGameEcon;
        System.DateTime val_5 = AddDays(value:  null);
        val_5.dateData.notifyAtDate = new System.DateTime() {dateData = 1152921513223722088};
        int val_8 = val_5.dateData.numTimesSeen;
        val_8.numTimesSeen = val_8 + 1;
        CPlayerPrefs.Save();
    }
    public void SetNotifVisibility(bool enabled)
    {
        if(enabled == false)
        {
                return;
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.RequestNotificationAccess();
    }
    public WGNotificationPromptManager()
    {
    
    }

}
