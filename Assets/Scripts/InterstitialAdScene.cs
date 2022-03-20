using UnityEngine;
public class InterstitialAdScene : BaseScene
{
    // Fields
    private AudienceNetwork.InterstitialAd interstitialAd;
    private bool isLoaded;
    private bool didClose;
    public UnityEngine.UI.Text statusLabel;
    
    // Methods
    private void Awake()
    {
        AudienceNetwork.AudienceNetworkAds.Initialize();
        SettingsScene.InitializeSettings();
    }
    public void LoadInterstitial()
    {
        var val_9;
        AudienceNetwork.FBInterstitialAdBridgeCallback val_11;
        var val_13;
        AudienceNetwork.FBInterstitialAdBridgeCallback val_15;
        AudienceNetwork.InterstitialAd val_1 = new AudienceNetwork.InterstitialAd(placementId:  2111607312);
        this.interstitialAd = null;
        UnityEngine.GameObject val_2 = this.gameObject;
        Register(gameObject:  2113642256);
        AudienceNetwork.FBInterstitialAdBridgeCallback val_3 = new AudienceNetwork.FBInterstitialAdBridgeCallback(object:  2113642256, method:  new IntPtr(2113587536));
        this.interstitialAd.InterstitialAdDidLoad = 468156416;
        AudienceNetwork.FBInterstitialAdBridgeErrorCallback val_4 = new AudienceNetwork.FBInterstitialAdBridgeErrorCallback(object:  2113642256, method:  new IntPtr(2113592656));
        this.interstitialAd.InterstitialAdDidFailWithError = 468209664;
        val_9 = null;
        val_9 = null;
        val_11 = InterstitialAdScene.<>c.<>9__5_2;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new AudienceNetwork.FBInterstitialAdBridgeCallback(object:  InterstitialAdScene.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2113597776));
            InterstitialAdScene.<>c.<>9__5_2 = val_11;
        }
        
        this.interstitialAd.InterstitialAdWillLogImpression = 468156416;
        val_13 = null;
        val_13 = null;
        val_15 = InterstitialAdScene.<>c.<>9__5_3;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new AudienceNetwork.FBInterstitialAdBridgeCallback(object:  InterstitialAdScene.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2113602896));
            InterstitialAdScene.<>c.<>9__5_3 = val_15;
        }
        
        this.interstitialAd.InterstitialAdDidClick = 468156416;
        AudienceNetwork.FBInterstitialAdBridgeCallback val_7 = new AudienceNetwork.FBInterstitialAdBridgeCallback(object:  2113642256, method:  new IntPtr(2113608016));
        this.interstitialAd.InterstitialAdDidClose = 468156416;
        AudienceNetwork.FBInterstitialAdBridgeCallback val_8 = new AudienceNetwork.FBInterstitialAdBridgeCallback(object:  2113642256, method:  new IntPtr(2113613136));
        this.interstitialAd.interstitialAdActivityDestroyed = null;
        this.interstitialAd.LoadAd();
    }
    public void ShowInterstitial()
    {
        var val_3 = this;
        if(this.isLoaded != false)
        {
                bool val_1 = this.interstitialAd.Show();
            this.isLoaded = false;
            if(this.statusLabel != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        }
        else
        {
                if((R4 + 20) != 0)
        {
            goto R4 + 20 + 788;
        }
        
        }
    
    }
    private void OnDestroy()
    {
        if(this.interstitialAd != 0)
        {
                this.interstitialAd.Dispose();
        }
        
        UnityEngine.Debug.Log(message:  2113895664);
    }
    public void NextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  2114011904);
    }
    public InterstitialAdScene()
    {
    
    }
    private void <LoadInterstitial>b__5_0()
    {
        UnityEngine.Debug.Log(message:  2114236000);
        this.isLoaded = true;
        this.didClose = false;
        if(this.interstitialAd.IsValid() == true)
        {
                "invalid" = "valid";
        }
        
        string val_2 = 2114244448 + 2112633200 + 2114240224;
        if(this.statusLabel == 0)
        {
            
        }
    
    }
    private void <LoadInterstitial>b__5_1(string error)
    {
        string val_1 = 2114368848 + error;
        UnityEngine.Debug.Log(message:  2114368848);
        if(this.statusLabel == 0)
        {
            
        }
    
    }
    private void <LoadInterstitial>b__5_4()
    {
        UnityEngine.Debug.Log(message:  2114493488);
        this.didClose = true;
        if(this.interstitialAd == 0)
        {
                return;
        }
        
        this.interstitialAd.Dispose();
    }
    private void <LoadInterstitial>b__5_5()
    {
        if(this.didClose == true)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  2114613808);
        UnityEngine.Debug.Log(message:  2114614000);
    }

}
