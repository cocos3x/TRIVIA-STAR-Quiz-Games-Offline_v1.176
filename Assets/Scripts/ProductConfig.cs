using UnityEngine;
[Serializable]
public class ProductConfig
{
    // Fields
    public string appName;
    public string packageName;
    public string gameCode;
    public string freeOrHd;
    public System.Collections.Generic.List<string> icons;
    public System.Collections.Generic.List<string> splashScreens;
    public System.Collections.Generic.List<string> allowedOrientations;
    public string marketUrl;
    public string applovinSdkKey;
    public string helpshiftApiKey;
    public string helpshiftDomainName;
    public string helpshiftAppId;
    public string adjustAppToken;
    public string singularAppToken;
    public string bannerAdUnitId;
    public string rewardedVideAdUnitId;
    public string interstitialAdUnitId;
    public string safeDKAppId;
    public string safeDKAppKey;
    public string adMobAppID;
    
    // Methods
    public ProductConfig()
    {
        this.appName = "";
        this.packageName = "";
        this.gameCode = "";
        this.freeOrHd = "free|hd";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_1 != 0)
        {
                Add(item:  -1769839376);
        }
        else
        {
                Add(item:  -1769839376);
        }
        
        Add(item:  -1769839216);
        if(val_1 != 0)
        {
                Add(item:  -1769839056);
        }
        else
        {
                Add(item:  -1769839056);
        }
        
        Add(item:  -1769838912);
        if(val_1 != 0)
        {
                Add(item:  -1769838768);
        }
        else
        {
                Add(item:  -1769838768);
        }
        
        Add(item:  -1769838624);
        this.icons = val_1;
        Add(item:  -1769838480);
        this.splashScreens = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_3 != 0)
        {
                Add(item:  -1769838304);
        }
        else
        {
                Add(item:  -1769838304);
        }
        
        Add(item:  -1769838192);
        this.allowedOrientations = val_3;
        this.marketUrl = "Marke URL of this app";
        this.applovinSdkKey = "";
        this.helpshiftApiKey = "";
        this.helpshiftDomainName = "Domain Name for Helpshift";
        this.helpshiftAppId = "";
        this.adjustAppToken = "";
        this.singularAppToken = "37e39f320951fdc5297544ebf2825322";
        this.safeDKAppKey = "";
        this.adMobAppID = "";
    }

}
