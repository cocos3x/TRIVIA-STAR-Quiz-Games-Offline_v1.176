using UnityEngine;
public class FacebookComponent : AppComponent
{
    // Properties
    public override bool RunInMainThread { get; }
    
    // Methods
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public FacebookComponent(string gameName, string gameObjectName)
    {
        mem[1152921511244865984] = "FacebookComponent";
    }
    public override void initializeOnMainThread()
    {
        ulong val_2;
        var val_9;
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.Log(message:  -1951819408);
        this.ConfigureAudienceNetwork();
        FacebookPlugin.init(gameObjectName:  static_value_021FA32E, gameName:  -1951795168);
        string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -1993112272, defaultValue:  1788750208);
        if((System.String.op_Inequality(a:  -1993112272, b:  1788750208)) != false)
        {
                if((System.String.op_Inequality(a:  -1993112272, b:  -1993112160)) == true)
        {
                return;
        }
        
        }
        
        FacebookPlugin.requestAppUserId();
        System.DateTime val_7 = System.DateTime.UtcNow;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511244974344}, d2:  new System.DateTime() {dateData = val_2});
        double val_11 = val_9.TotalMilliseconds;
        string val_12 = -1951819296(-1951819296) + 10489856;
        UnityEngine.Debug.Log(message:  -1951819296);
    }
    public void ConfigureAudienceNetwork()
    {
        AudienceNetwork.AdSettings.SetDataProcessingOptions(dataProcessingOptions:  477709520);
    }
    public override void onApplicationPause(bool pauseStatus)
    {
        this.onApplicationPause(pauseStatus:  pauseStatus);
    }

}
