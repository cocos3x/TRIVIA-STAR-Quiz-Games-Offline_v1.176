using UnityEngine;
public class AdViewScene : BaseScene
{
    // Fields
    private AudienceNetwork.AdView adView;
    private AudienceNetwork.AdPosition currentAdViewPosition;
    private UnityEngine.ScreenOrientation currentScreenOrientation;
    public UnityEngine.UI.Text statusLabel;
    private AudienceNetwork.AdSize[] adSizeArray;
    private int currentAdSize;
    public UnityEngine.UI.Button loadAdButton;
    
    // Methods
    private void OnDestroy()
    {
        if((AudienceNetwork.AdView.op_Implicit(obj:  this.adView)) != false)
        {
                this.adView.Dispose();
        }
        
        UnityEngine.Debug.Log(message:  2111127616);
    }
    private void Awake()
    {
        AudienceNetwork.AudienceNetworkAds.Initialize();
        this.SetLoadAddButtonText();
        SettingsScene.InitializeSettings();
    }
    private void SetLoadAddButtonText()
    {
        object val_1 = this.loadAdButton.GetComponentInChildren<System.Object>();
        var val_3 = this.adSizeArray[this.currentAdSize][16];
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        string val_2 = 2111400896 + 467410944 + 1009293344;
        if(this.loadAdButton == 0)
        {
            
        }
    
    }
    public void LoadBanner()
    {
        if((AudienceNetwork.AdView.op_Implicit(obj:  this.adView)) != false)
        {
                this.adView.Dispose();
        }
        
        AudienceNetwork.AdView val_2 = new AudienceNetwork.AdView(placementId:  2111607312, size:  this.adSizeArray[this.currentAdSize]);
        this.adView = null;
        UnityEngine.GameObject val_3 = this.gameObject;
        Register(gameObject:  2111656000);
        this.currentAdViewPosition = 0;
        AudienceNetwork.FBAdViewBridgeCallback val_4 = new AudienceNetwork.FBAdViewBridgeCallback(object:  2111656000, method:  new IntPtr(2111611520));
        this.adView.AdViewDidLoad = 467197952;
        AudienceNetwork.FBAdViewBridgeErrorCallback val_5 = new AudienceNetwork.FBAdViewBridgeErrorCallback(object:  2111656000, method:  new IntPtr(2111616640));
        this.adView.AdViewDidFailWithError = 467251200;
        AudienceNetwork.FBAdViewBridgeCallback val_6 = new AudienceNetwork.FBAdViewBridgeCallback(object:  2111656000, method:  new IntPtr(2111621760));
        this.adView.AdViewWillLogImpression = 467197952;
        AudienceNetwork.FBAdViewBridgeCallback val_7 = new AudienceNetwork.FBAdViewBridgeCallback(object:  2111656000, method:  new IntPtr(2111626880));
        this.adView.AdViewDidClick = 467197952;
        this.adView.LoadAd();
    }
    public void ChangeBannerSize()
    {
        this.currentAdSize = this.currentAdSize + 1;
        this.currentAdSize = ;
        this.SetLoadAddButtonText();
    }
    public void NextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  2112003456);
    }
    public void ChangePosition()
    {
        if(this.currentAdViewPosition == 0)
        {
            goto label_0;
        }
        
        if(this.currentAdViewPosition == 2)
        {
            goto label_1;
        }
        
        if(this.currentAdViewPosition != 1)
        {
                return;
        }
        
        this.SetAdViewPosition(adPosition:  2);
        return;
        label_0:
        this.SetAdViewPosition(adPosition:  1);
        return;
        label_1:
        this.SetAdViewPosition(adPosition:  0);
    }
    private void OnRectTransformDimensionsChange()
    {
        if((AudienceNetwork.AdView.op_Implicit(obj:  this.adView)) == false)
        {
                return;
        }
        
        UnityEngine.ScreenOrientation val_2 = UnityEngine.Screen.orientation;
        if(0 == this.currentScreenOrientation)
        {
                return;
        }
        
        R4.SetAdViewPosition(adPosition:  R4 + 16);
        UnityEngine.ScreenOrientation val_3 = UnityEngine.Screen.orientation;
        mem2[0] = 0;
    }
    private void SetAdViewPosition(AudienceNetwork.AdPosition adPosition)
    {
        AudienceNetwork.AdPosition val_3;
        var val_4;
        if(adPosition == 0)
        {
            goto label_0;
        }
        
        if(adPosition == 2)
        {
            goto label_1;
        }
        
        if(adPosition != 1)
        {
                return;
        }
        
        val_3 = 1;
        val_4 = 1;
        goto label_4;
        label_0:
        val_3 = 0;
        bool val_1 = this.adView.Show(y:  null);
        goto label_6;
        label_1:
        val_3 = 2;
        val_4 = 2;
        label_4:
        bool val_2 = this.adView.Show(position:  2);
        label_6:
        this.currentAdViewPosition = val_3;
    }
    public AdViewScene()
    {
        AudienceNetwork.AdSize[] val_3;
        var val_4;
        val_3 = 0;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(467410944)});
        val_4 = null;
        System.Array val_2 = System.Enum.GetValues(enumType:  467410944);
        if(val_4 != 0)
        {
                val_4 = val_4;
            val_3 = val_4;
            if(val_4 == 0)
        {
                val_3 = 0;
        }
        
        }
        
        this.adSizeArray = val_3;
    }
    private void <LoadBanner>b__10_0()
    {
        UnityEngine.ScreenOrientation val_1 = UnityEngine.Screen.orientation;
        this.currentScreenOrientation = 0;
        bool val_2 = this.adView.Show(y:  null);
        if(this.adView.IsValid() == true)
        {
                "invalid" = "valid";
        }
        
        string val_4 = 2112637472 + 2112633200 + 1297836480;
        UnityEngine.Debug.Log(message:  2112637584);
    }
    private void <LoadBanner>b__10_1(string error)
    {
        string val_1 = 2112766064 + error;
        string val_2 = 2112766064 + error;
        UnityEngine.Debug.Log(message:  2112766064);
    }
    private void <LoadBanner>b__10_2()
    {
        UnityEngine.Debug.Log(message:  2112894592);
    }
    private void <LoadBanner>b__10_3()
    {
        UnityEngine.Debug.Log(message:  2113014912);
    }

}
