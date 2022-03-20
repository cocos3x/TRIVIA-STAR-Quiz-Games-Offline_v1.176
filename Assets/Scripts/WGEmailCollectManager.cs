using UnityEngine;
public class WGEmailCollectManager : MonoSingleton<WGEmailCollectManager>
{
    // Fields
    private System.DateTime _LastRequestedTime;
    
    // Properties
    private System.DateTime LastRequestedTime { get; set; }
    public static bool IsAvailable { get; }
    
    // Methods
    private System.DateTime get_LastRequestedTime()
    {
        var val_5;
        ulong val_8;
        var val_9;
        var val_10;
        string val_11;
        var val_12;
        val_8 = mem[R1 + 16];
        val_8 = R1 + 16;
        val_9 = null;
        val_10 = mem[R1 + 16 + 4];
        val_10 = R1 + 16 + 4;
        val_9 = null;
        val_11 = val_10;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_8}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                val_10 = "wg_last_email_request";
            string val_2 = CPlayerPrefs.GetString(key:  -59350544);
            val_8 = "wg_last_email_request";
            val_12 = null;
            val_12 = null;
            System.DateTime val_3 = SLCDateTime.Parse(dateTime:  -59338480, defaultValue:  new System.DateTime() {dateData = 1152921513137431024});
            mem2[0] = val_5;
            string val_6 = R1 + 16;
            string val_7 = val_6.ToString();
            val_11 = val_6;
            CPlayerPrefs.SetString(key:  -59350544, val:  val_11);
        }
        
        this = R1 + 16;
        return new System.DateTime() {dateData = R1 + 16};
    }
    private void set_LastRequestedTime(System.DateTime value)
    {
        this._LastRequestedTime = R2;
        mem[1152921513137567156] = R3;
        string val_1 = this._LastRequestedTime.ToString();
        CPlayerPrefs.SetString(key:  -59350544, val:  -59214416);
    }
    public static bool get_IsAvailable()
    {
        GameBehavior val_1 = App.getBehavior;
        GameEcon val_2 = App.getGameEcon;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  3);
    }
    public bool CheckAvailable()
    {
        var val_5;
        if(WGEmailCollectManager.IsAvailable == false)
        {
                return false;
        }
        
        if(this.CanCollect() == false)
        {
                return false;
        }
        
        var val_4 = 28422357;
        val_4 = 7205068 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
                return false;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private bool CanCollect()
    {
        var val_7;
        var val_15;
        var val_27;
        Player val_1 = App.Player;
        string val_2 = -58902432(-58902432) + 34483956 + -2100450224(-2100450224);
        UnityEngine.Debug.Log(message:  -58902432);
        string val_4 = FacebookPlugin.IsLoggedIn.ToString();
        string val_5 = -58902304(-58902304) + -58889969(-58889969);
        UnityEngine.Debug.Log(message:  -58902304);
        System.DateTime val_6 = DateTimeCheat.UtcNow;
        string val_9 = val_7.ToString();
        System.DateTime val_10 = LastRequestedTime;
        GameEcon val_13 = App.getGameEcon;
        System.DateTime val_14 = AddDays(value:  null);
        string val_17 = val_15.ToString();
        string val_18 = -58902176(-58902176) + -58889984(-58889984) + -58902048(-58902048) + -58889984(-58889984);
        UnityEngine.Debug.Log(message:  -58902176);
        Player val_19 = App.Player;
        val_27 = 0;
        string val_20 = 34483956.Trim();
        if((System.String.IsNullOrEmpty(value:  34483956)) == false)
        {
                return true;
        }
        
        System.DateTime val_22 = DateTimeCheat.UtcNow;
        System.DateTime val_23 = 0.LastRequestedTime;
        GameEcon val_24 = App.getGameEcon;
        System.DateTime val_25 = AddDays(value:  null);
        if((val_7.CompareTo(value:  new System.DateTime() {dateData = 1152921513137891576})) > 0)
        {
                val_27 = 1;
        }
        
        return true;
    }
    public void HandleResponded()
    {
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        this.LastRequestedTime = new System.DateTime();
        CPlayerPrefs.Save();
    }
    public WGEmailCollectManager()
    {
        var val_1 = null;
        this._LastRequestedTime = System.DateTime.MinValue;
    }

}
