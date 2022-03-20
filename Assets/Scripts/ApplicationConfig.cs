using UnityEngine;
public class ApplicationConfig : ScriptableObject
{
    // Fields
    public string gameName;
    public string gamePathName;
    public string internalAcronym;
    public ApplicationConfig.BonusCollectType bonusCollectType;
    public string facebook_app_id;
    public string facebook_display_name;
    public string facebook_page_id;
    public string facebook_permissions;
    public string amplitudeApiKey;
    public string companyName;
    public string gmsAppId;
    public string googleAnalyticsTrackingId;
    public string deeplinkScheme;
    public string domainName;
    public string vip_email;
    public bool uploadLevelGenerationStatistics;
    public AndroidConfig Free_Android;
    public IosConfig Free_Ios;
    public WebGLConfig Free_Webgl;
    public string APPLOVIN_SDK_KEY;
    public string propertiesFile;
    public string antProjectName;
    public string gameObjectName;
    private string StagingServerURL;
    private string ProductionServerURL;
    public string ResourcesDataPath;
    public System.Collections.Generic.List<string> EnabledScenes;
    public string[] ResourcesToDisable;
    public bool isUmbrella;
    public bool deprecated;
    public int priority;
    public string googleSheetForMachines;
    public string staging_path;
    public string BuildTime;
    public string GitBranch;
    public string GDPR_TOS_URL;
    public string GDPR_Privacy_URL;
    
    // Properties
    public string Environment { get; }
    
    // Methods
    public string Key(string key)
    {
        if((System.String.op_Equality(a:  key, b:  -1772300384)) == false)
        {
                return this.GetPropertyForPlatform(key:  key);
        }
    
    }
    public string GetSupportEmail(int amountPurchased)
    {
        if(amountPurchased < 91)
        {
                return this.GetPropertyForPlatform(key:  -1772171904);
        }
    
    }
    public string GetSupportUrl()
    {
        if(this.Free_Android != 0)
        {
                return;
        }
    
    }
    private string GetPropertyForPlatform(string key)
    {
        if(this.Free_Android == 0)
        {
                return;
        }
        
        if(((AndroidConfig.__il2cppRuntimeField_typeHierarchy + (AndroidConfig.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.Free_Android = 0;
        }
        
        System.Type val_1 = this.Free_Android.GetType();
        35631981 = this.Free_Android;
        System.Reflection.FieldInfo val_2 = val_5.GetField(name:  key);
        if((System.Reflection.FieldInfo.op_Inequality(left:  0, right:  0)) == false)
        {
                return;
        }
        
        if(35631981 == 0)
        {
            
        }
    
    }
    private ProductConfig ChooseConfig()
    {
    
    }
    public bool HasCustomEndpoint()
    {
        return false;
    }
    public string GetServerURL()
    {
    
    }
    public string GetServerProductionURL()
    {
    
    }
    public string GetAdminURL()
    {
        string val_1 = System.String.Copy(str:  this.ProductionServerURL);
        if(this.ProductionServerURL != null)
        {
                return this.ProductionServerURL.Replace(oldValue:  -1771322192, newValue:  -1771322272);
        }
        
        return this.ProductionServerURL.Replace(oldValue:  -1771322192, newValue:  -1771322272);
    }
    public bool IsProduction()
    {
        return true;
    }
    public string get_Environment()
    {
    
    }
    public ApplicationConfig()
    {
        this.gameName = "";
        this.gamePathName = "";
        this.internalAcronym = "";
        this.facebook_app_id = "";
        this.facebook_display_name = "";
        this.facebook_page_id = "";
        this.facebook_permissions = "email";
        this.amplitudeApiKey = "";
        this.companyName = "Super Lucky Casino";
        this.vip_email = "";
        this.ProductionServerURL = "Production Server URL";
        this.ResourcesDataPath = "Resources Data path for this game";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  -1770980960);
        this.EnabledScenes = null;
        typeof(System.String[]).__il2cppRuntimeField_10 = "override_me";
        this.priority = 1;
        this.ResourcesToDisable = null;
        this.GDPR_TOS_URL = "";
        this.GDPR_Privacy_URL = "";
    }

}
