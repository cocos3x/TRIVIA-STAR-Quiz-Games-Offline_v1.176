using UnityEngine;
public class TRVLPNManager : FrameSkipper
{
    // Fields
    private const string PP_Sent_TRV_KEEPP = "PP_Sent_TRV_KEEPP";
    private const int frequency = 30;
    
    // Methods
    private void Start()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -514442032)) != false)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  -514417920);
            return;
        }
        
        mem[1152921512682363668] = 300;
    }
    protected override void UpdateLogic()
    {
        this.SendNotification();
    }
    private void SendNotification()
    {
        ulong val_7;
        ulong val_9;
        string val_10;
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  29);
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.DateTime val_4 = Date;
        Player val_5 = App.Player;
        System.DateTime val_6 = Date;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_9}, d2:  new System.DateTime() {dateData = val_7})) != false)
        {
                UnityEngine.GameObject val_12 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  -514193760);
            return;
        }
        
        System.DateTime val_13 = DateTimeCheat.UtcNow;
        System.DateTime val_14 = AddMinutes(value:  null);
        string val_15 = System.Environment.NewLine;
        string val_16 = System.String.Format(format:  -514217920, arg0:  0);
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  29, when:  new System.DateTime() {dateData = twelvegigs.plugins.LocalNotificationsPlugin.__il2cppRuntimeField_cctor_finished}, optMessage:  val_10, extraData:  "Keep playing!{0}Your next question is ready!");
        UnityEngine.PlayerPrefs.SetInt(key:  -514442032, value:  10);
        bool val_17 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public TRVLPNManager()
    {
    
    }

}
