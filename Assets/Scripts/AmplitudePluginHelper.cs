using UnityEngine;
public class AmplitudePluginHelper
{
    // Fields
    private static AmplitudePluginHelper.FeatureAccessPoints lastFeatureAccessPoint;
    
    // Properties
    public static AmplitudePluginHelper.FeatureAccessPoints LastFeatureAccessPoint { get; set; }
    
    // Methods
    public static AmplitudePluginHelper.FeatureAccessPoints get_LastFeatureAccessPoint()
    {
        null = null;
    }
    public static void set_LastFeatureAccessPoint(AmplitudePluginHelper.FeatureAccessPoints value)
    {
        null = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = value;
    }
    public static void InjectMetaData(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        Player val_1 = App.Player;
        if(data == 0)
        {
            goto label_3;
        }
        
        if(285196288 != 0)
        {
            goto label_6;
        }
        
        UnityEngine.Debug.LogError(message:  -1875448256);
        return;
        label_3:
        UnityEngine.Debug.LogError(message:  -1875448096);
        return;
        label_6:
        if((data.ContainsKey(key:  -1988561632)) != true)
        {
                string val_4 = Player.GetLevelForTracking();
            data.Add(key:  -1988561632, value:  0);
        }
        
        if((data.ContainsKey(key:  -1987496016)) == true)
        {
                return;
        }
        
        string val_6 = ToString();
        data.Add(key:  -1987496016, value:  -1875435984);
    }
    public static void InjectRegularGlobals(string eventName, System.Collections.Generic.Dictionary<string, object> globals)
    {
        if(mem[35631899] != true)
        {
            
        }
    
    }
    public static void InjectFeatureGlobals(string eventName, System.Collections.Generic.Dictionary<string, object> globals)
    {
        var val_39;
        var val_40;
        Player val_1 = App.Player;
        GameBehavior val_2 = App.getBehavior;
        GameBehavior val_3 = App.getBehavior;
        Player val_4 = App.Player;
        globals.Add(key:  -1875191168, value:  13152256);
        Player val_5 = App.Player;
        globals.Add(key:  -1875191056, value:  13152256);
        Player val_6 = App.Player;
        globals.Add(key:  -1875190928, value:  13152256);
        GameEcon val_7 = App.getGameEcon;
        Player val_8 = App.Player;
        GameEcon val_9 = App.getGameEcon;
        GameEcon val_10 = App.getGameEcon;
        int val_11 = UnityEngine.Mathf.Min(a:  155430912, b:  typeof(App).__il2cppRuntimeField_1E4);
        globals.Add(key:  -1875190784, value:  13152256);
        Player val_12 = App.Player;
        globals.Add(key:  -1875190656, value:  8945664);
        Player val_13 = App.Player;
        globals.Add(key:  -1875190560, value:  13152256);
        WordGameEventsController.InjectEventsTrackingData(data:  globals, onlyTrackEnabledEvents:  false);
        int val_14 = PuzzleCollectionHandler.LifetimePuzzlesCompleted;
        globals.Add(key:  -1875190448, value:  13152256);
        bool val_15 = SeasonPassEventHandler.IsPlusPassActive;
        globals.Add(key:  -1875190320, value:  8945664);
        int val_16 = SnakesAndLaddersEventHandler.CurrentDiceRollsOnEvent;
        globals.Add(key:  -1875190224, value:  13152256);
        SLC.Social.Leagues.LeaguesTracker.InjectLeaguesPlayerGlobals(globals: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_17 = -1875176008);
        int val_18 = WGInviteManager.invitesSend;
        val_39 = 1152921510535002416;
        globals.Add(key:  -1875190128, value:  13152256);
        bool val_19 = WGInviteManager.isInvited;
        globals.Add(key:  -1875190016, value:  8945664);
        int val_20 = WGInviteManager.TotalValidInvites;
        globals.Add(key:  -1875189920, value:  13152256);
        bool val_21 = WGInviteManager.CodeManuallyEntered;
        globals.Add(key:  -1875189776, value:  8945664);
        Player val_22 = App.Player;
        globals.Add(key:  -1875189648, value:  13152256);
        Player val_23 = App.Player;
        globals.Add(key:  -1875189520, value:  13152256);
        Player val_24 = App.Player;
        globals.Add(key:  -1875189408, value:  13152256);
        Player val_25 = App.Player;
        globals.Add(key:  -1875189312, value:  13152256);
        Player val_26 = App.Player;
        globals.Add(key:  -1875189200, value:  13152256);
        Player val_27 = App.Player;
        globals.Add(key:  -1875189088, value:  13152256);
        Player val_28 = App.Player;
        globals.Add(key:  -1875188976, value:  13152256);
        Player val_29 = App.Player;
        globals.Add(key:  -1875188864, value:  globals + 44 + 184);
        Player val_30 = App.Player;
        globals.Add(key:  -1875188752, value:  13152256);
        Player val_31 = App.Player;
        globals.Add(key:  -1875188592, value:  13152256);
        Player val_32 = App.Player;
        globals.Add(key:  -1875188464, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_33 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_40 = 0;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<ZooTile> val_36 = GetLifetimeMonthlyZootiles();
            val_39 = 1152921510535002416;
        }
        
        globals.Add(key:  -1875188368, value:  13152256);
        Player val_37 = App.Player;
        globals.Add(key:  -1875188208, value:  13152256);
        Player val_38 = App.Player;
        globals.Add(key:  -1875188096, value:  13152256);
        if(PiggyBankHandler.iapHigh != null)
        {
                var val_39 = PiggyBankHandler.iapHigh + 196;
            val_39 = val_39 ^ 1;
        }
    
    }
    public static void InjectMetaBehaviorProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> globals, ref System.Collections.Generic.Dictionary<string, object> data)
    {
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AppendAmplitudeUserProperties(globals: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = -1874995520);
    }
    public AmplitudePluginHelper()
    {
    
    }
    private static AmplitudePluginHelper()
    {
    
    }

}
