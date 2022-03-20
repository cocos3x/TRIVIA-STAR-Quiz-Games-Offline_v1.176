using UnityEngine;
public static class UpdatePrompt
{
    // Fields
    private const string deviceVersionCode = "device_version_code";
    private static string versionCode;
    private static string storeUrl;
    private static twelvegigs.storage.JsonDictionary configuration;
    
    // Methods
    public static void Init(twelvegigs.storage.JsonDictionary serverConfiguration)
    {
        int val_21;
        int val_25;
        int val_26;
        int val_27;
        twelvegigs.storage.JsonDictionary val_31;
        int val_32;
        UpdatePrompt.configuration = serverConfiguration;
        if(UpdatePrompt.configuration == 0)
        {
                return;
        }
        
        string val_1 = UpdatePrompt.configuration.getString(key:  -1981329008, defaultValue:  1098586544);
        UpdatePrompt.versionCode = UpdatePrompt.configuration;
        string val_2 = UpdatePrompt.configuration.getString(key:  -1981328896, defaultValue:  1098586544);
        UpdatePrompt.storeUrl = UpdatePrompt.configuration;
        string val_3 = DeviceIdPlugin.GetClientVersion();
        bool val_4 = UpdatePrompt.versionCode.Contains(value:  -1981328800);
        val_31 = 0;
        bool val_5 = UpdatePrompt.versionCode.Contains(value:  -1981328720);
        bool val_6 = UpdatePrompt.versionCode.Contains(value:  null);
        System.Text.RegularExpressions.Regex val_7 = new System.Text.RegularExpressions.Regex(pattern:  -1981328640);
        float val_8 = UpdatePrompt.getNumericVersion(versionCode:  null);
        float val_9 = UpdatePrompt.getNumericVersion(versionCode:  UpdatePrompt.versionCode);
        if(UpdatePrompt.versionCode < 0)
        {
                0 = 1;
        }
        
        string val_10 = -1981328560(-1981328560) + UpdatePrompt.versionCode + -1981328432(-1981328432) + null;
        UnityEngine.Debug.Log(message:  -1981328560);
        typeof(System.String[]).__il2cppRuntimeField_10 = "UPDATE PROMPT: skip = ";
        string val_11 = val_4.ToString();
        typeof(System.String[]).__il2cppRuntimeField_14 = ;
        typeof(System.String[]).__il2cppRuntimeField_18 = ", force = ";
        string val_12 = val_5.ToString();
        typeof(System.String[]).__il2cppRuntimeField_1C = ;
        typeof(System.String[]).__il2cppRuntimeField_20 = ", versionMatchesCurrent = ";
        string val_13 = val_6.ToString();
        typeof(System.String[]).__il2cppRuntimeField_24 = ;
        typeof(System.String[]).__il2cppRuntimeField_28 = ", versionLessThanCurrent = ";
        string val_14 = 1.ToString();
        typeof(System.String[]).__il2cppRuntimeField_2C = ;
        string val_15 = +477709520;
        UnityEngine.Debug.Log(message:  477709520);
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        Player val_17 = App.Player;
        if((28950032.ContainsKey(key:  -1981326832)) != false)
        {
                decimal val_19 = Item[28950032];
            decimal val_20 = System.Decimal.op_Implicit(value:  -1981310700);
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {lo = 1}, d2:  new System.Decimal() {mid = val_21})) == false)
        {
                return;
        }
        
            if(val_5 != true)
        {
                bool val_23 = 28950032.Remove(key:  -1981326832);
            decimal val_24 = System.Decimal.op_Implicit(value:  -1981310684);
            val_32 = val_27;
            val_31 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Decimal>::Add(System.String key, System.Decimal value);
            28950032.Add(key:  -1981326832, value:  new System.Decimal() {flags = val_25, hi = val_26, lo = 1, mid = val_32});
            0.SaveState();
        }
        
            bool val_31 = val_4;
            val_31 = val_6 | val_31;
            if(28950032 != 0)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_29 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_31 = UpdatePrompt.storeUrl;
            if(val_5 == true)
        {
                val_5 = 1;
        }
        
            Setup(url:  val_31, mustUpdate:  true);
            return;
        }
        
        decimal val_30 = System.Decimal.op_Implicit(value:  -1981310684);
        val_32 = val_27;
        val_31 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Decimal>::Add(System.String key, System.Decimal value);
        28950032.Add(key:  -1981326832, value:  new System.Decimal() {flags = val_25, hi = val_26, lo = 1, mid = val_32});
        0.SaveState();
    }
    public static void DebugResetPlayerStatsVersion()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        Player val_1 = App.Player;
        string val_2 = DeviceIdPlugin.GetClientVersion();
        if((28950032.ContainsKey(key:  -1981326832)) != false)
        {
                bool val_4 = 28950032.Remove(key:  -1981326832);
        }
        
        decimal val_5 = System.Decimal.op_Implicit(value:  -1981194568);
        28950032.Add(key:  -1981326832, value:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_8, mid = val_9});
        0.SaveState();
    }
    private static float getNumericVersion(string versionCode)
    {
        System.Text.RegularExpressions.Regex val_1 = new System.Text.RegularExpressions.Regex(pattern:  -1981090432);
        System.Text.RegularExpressions.Match val_2 = Match(input:  versionCode);
        if(Success == false)
        {
                return (float)S0;
        }
        
        System.Text.RegularExpressions.Group val_4 = Item[0];
        System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
        return System.Single.Parse(s:  105803776, provider:  0);
    }

}
