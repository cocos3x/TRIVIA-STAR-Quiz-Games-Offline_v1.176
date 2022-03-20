using UnityEngine;
public class RewardedVideoAdScene : BaseScene
{
    // Fields
    private AudienceNetwork.RewardedVideoAd rewardedVideoAd;
    private bool isLoaded;
    private bool didClose;
    public UnityEngine.UI.Text statusLabel;
    
    // Methods
    private void Awake()
    {
        AudienceNetwork.AudienceNetworkAds.Initialize();
        SettingsScene.InitializeSettings();
    }
    public void LoadRewardedVideo()
    {
        var val_13;
        var val_14;
        AudienceNetwork.FBRewardedVideoAdBridgeCallback val_16;
        var val_17;
        AudienceNetwork.FBRewardedVideoAdBridgeCallback val_19;
        var val_20;
        AudienceNetwork.FBRewardedVideoAdBridgeCallback val_22;
        var val_23;
        AudienceNetwork.FBRewardedVideoAdBridgeCallback val_25;
        AudienceNetwork.RewardedVideoAd val_1 = null;
        val_13 = "YOUR_PLACEMENT_ID";
        val_1 = new AudienceNetwork.RewardedVideoAd(placementId:  2111607312);
        this.rewardedVideoAd = val_1;
        if(new AudienceNetwork.RewardData() != 0)
        {
                typeof(AudienceNetwork.RewardData).__il2cppRuntimeField_8 = "USER_ID";
        }
        else
        {
                mem[8] = "USER_ID";
        }
        
        typeof(AudienceNetwork.RewardData).__il2cppRuntimeField_C = "REWARD_ID";
        AudienceNetwork.RewardedVideoAd val_3 = new AudienceNetwork.RewardedVideoAd(placementId:  2111607312, rewardData:  468955136);
        UnityEngine.GameObject val_4 = this.gameObject;
        this.rewardedVideoAd.Register(gameObject:  2115363952);
        AudienceNetwork.FBRewardedVideoAdBridgeCallback val_5 = new AudienceNetwork.FBRewardedVideoAdBridgeCallback(object:  2115363952, method:  new IntPtr(2115298992));
        this.rewardedVideoAd.RewardedVideoAdDidLoad = 468742144;
        AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback val_6 = new AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback(object:  2115363952, method:  new IntPtr(2115304112));
        this.rewardedVideoAd.RewardedVideoAdDidFailWithError = 468795392;
        val_14 = null;
        val_14 = null;
        val_16 = RewardedVideoAdScene.<>c.<>9__5_2;
        if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new AudienceNetwork.FBRewardedVideoAdBridgeCallback(object:  RewardedVideoAdScene.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2115309232));
            RewardedVideoAdScene.<>c.<>9__5_2 = val_16;
        }
        
        this.rewardedVideoAd.RewardedVideoAdWillLogImpression = 468742144;
        val_17 = null;
        val_17 = null;
        val_19 = RewardedVideoAdScene.<>c.<>9__5_3;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new AudienceNetwork.FBRewardedVideoAdBridgeCallback(object:  RewardedVideoAdScene.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2115314352));
            RewardedVideoAdScene.<>c.<>9__5_3 = val_19;
        }
        
        this.rewardedVideoAd.RewardedVideoAdDidClick = 468742144;
        val_20 = null;
        val_20 = null;
        val_22 = RewardedVideoAdScene.<>c.<>9__5_4;
        if(val_22 == 0)
        {
                val_22 = null;
            val_22 = new AudienceNetwork.FBRewardedVideoAdBridgeCallback(object:  RewardedVideoAdScene.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2115319472));
            RewardedVideoAdScene.<>c.<>9__5_4 = val_22;
        }
        
        this.rewardedVideoAd.RewardedVideoAdDidSucceed = 468742144;
        val_23 = null;
        val_23 = null;
        val_25 = RewardedVideoAdScene.<>c.<>9__5_5;
        if(val_25 == 0)
        {
                val_25 = null;
            val_25 = new AudienceNetwork.FBRewardedVideoAdBridgeCallback(object:  RewardedVideoAdScene.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2115324592));
            RewardedVideoAdScene.<>c.<>9__5_5 = val_25;
        }
        
        this.rewardedVideoAd.RewardedVideoAdDidFail = 468742144;
        AudienceNetwork.FBRewardedVideoAdBridgeCallback val_11 = new AudienceNetwork.FBRewardedVideoAdBridgeCallback(object:  2115363952, method:  new IntPtr(2115329712));
        this.rewardedVideoAd.RewardedVideoAdDidClose = 468742144;
        AudienceNetwork.FBRewardedVideoAdBridgeCallback val_12 = new AudienceNetwork.FBRewardedVideoAdBridgeCallback(object:  2115363952, method:  new IntPtr(2115334832));
        this.rewardedVideoAd.RewardedVideoAdActivityDestroyed = 468742144;
        this.rewardedVideoAd.LoadAd();
    }
    public void ShowRewardedVideo()
    {
        var val_3 = this;
        if(this.isLoaded != false)
        {
                bool val_1 = this.rewardedVideoAd.Show();
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
        if(this.rewardedVideoAd != 0)
        {
                this.rewardedVideoAd.Dispose();
        }
        
        UnityEngine.Debug.Log(message:  2115629488);
    }
    public void NextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  2115745728);
    }
    public RewardedVideoAdScene()
    {
    
    }
    private void <LoadRewardedVideo>b__5_0()
    {
        UnityEngine.Debug.Log(message:  2115969840);
        this.isLoaded = true;
        this.didClose = false;
        if(this.rewardedVideoAd.IsValid() == true)
        {
                "invalid" = "valid";
        }
        
        string val_2 = 2114244448 + 2112633200 + 2114240224;
        if(this.statusLabel == 0)
        {
            
        }
    
    }
    private void <LoadRewardedVideo>b__5_1(string error)
    {
        string val_1 = 2116102448 + error;
        UnityEngine.Debug.Log(message:  2116102448);
        if(this.statusLabel == 0)
        {
            
        }
    
    }
    private void <LoadRewardedVideo>b__5_6()
    {
        UnityEngine.Debug.Log(message:  2116227088);
        this.didClose = true;
        if(this.rewardedVideoAd == 0)
        {
                return;
        }
        
        this.rewardedVideoAd.Dispose();
    }
    private void <LoadRewardedVideo>b__5_7()
    {
        if(this.didClose == true)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  2116347408);
        UnityEngine.Debug.Log(message:  2116347600);
    }

}
