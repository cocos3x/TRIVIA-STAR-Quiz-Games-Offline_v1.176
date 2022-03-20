using UnityEngine;
public class WGMoreGamesItem : MonoBehaviour
{
    // Fields
    private UGUINetworkedButtonMultiGraphic entireButton;
    private UGUINetworkedButtonMultiGraphic installButton;
    private UnityEngine.UI.RawImage icon;
    private UnityEngine.UI.Text[] installOrPlayTexts;
    private UnityEngine.GameObject installedGroup;
    private string packageName;
    private twelvegigs.plugins.InstalledAppsPlugin.GameApp myGameApp;
    private bool imageLoaded;
    
    // Methods
    private void Awake()
    {
        var val_5;
        var val_6;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  22634688, method:  new IntPtr(22605568));
        System.Delegate val_2 = System.Delegate.Combine(a:  static_value_021FADE3, b:  7401472);
        val_5 = 35630563;
        val_5 = 0;
        mem2[0] = val_5;
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  22634688, method:  new IntPtr(22605568));
        System.Delegate val_4 = System.Delegate.Combine(a:  0, b:  7401472);
        val_6 = val_5;
        if(val_6 != 0)
        {
                if(1179403647 == null)
        {
            goto label_8;
        }
        
        }
        
        val_6 = 0;
        label_8:
        mem2[0] = val_6;
    }
    public void SetParams(bool state, twelvegigs.plugins.InstalledAppsPlugin.GameApp gameApp)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(state != false)
        {
                this.SetActive(value:  true);
            this.packageName = gameApp.packageName;
            this.LoadAsset(_assetName:  gameApp.assetName);
            if(((int)gameApp.isInstalled & 255) != 0)
        {
                (int)gameApp.isInstalled & 255 = 1;
        }
        
            this.CheckInstallation(isInstalled:  true);
            this.myGameApp = gameApp.uniqueName;
            mem[1152921513219536488] = gameApp.packageName;
            mem[1152921513219536492] = gameApp.assetName;
            mem[1152921513219536496] = gameApp.isInstalled;
            return;
        }
        
        this.SetActive(value:  false);
    }
    public void CheckInstallation(bool isInstalled)
    {
        var val_4;
        UnityEngine.GameObject val_1 = this.installButton.gameObject;
        val_4 = 0;
        this.installButton.SetActive(value:  isInstalled ^ 1);
        this.installedGroup.SetActive(value:  isInstalled);
        goto label_4;
        label_9:
        if(isInstalled == true)
        {
                "install_upper" = "installed_upper";
        }
        
        if(isInstalled == true)
        {
                "INSTALL" = "INSTALLED";
        }
        
        string val_3 = Localization.Localize(key:  22888128, defaultValue:  -269296096, useSingularKey:  false);
        val_4 = 1;
        label_4:
        if(val_4 < this.installOrPlayTexts[val_4])
        {
            goto label_9;
        }
    
    }
    private void InstallOrPlayClicked(bool connectionStatus)
    {
        var val_9;
        var val_10;
        var val_11;
        System.Func<System.Boolean> val_13;
        var val_14;
        val_9 = 35630565;
        if(0 != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.packageName)) == true)
        {
                return;
        }
        
            var val_9 = 27098595;
            val_9 = 8527192 + val_9;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            val_9 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_2 = 23131312 + 295313408;
            twelvegigs.plugins.InstalledAppsPlugin.OpenApp(package:  this.packageName, referrerMarket:  23131312);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_11 = null;
        val_11 = null;
        val_13 = WGMoreGamesItem.<>c.<>9__10_0;
        if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Func<System.Boolean>(object:  WGMoreGamesItem.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(23135536));
            WGMoreGamesItem.<>c.<>9__10_0 = val_13;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_13;
        val_14 = null;
        val_14 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void LoadAsset(string _assetName)
    {
        var val_7;
        bool val_1 = System.String.IsNullOrEmpty(value:  _assetName);
        if(val_1 == false)
        {
                val_1 = this.imageLoaded;
            goto label_1;
        }
        
        return;
        label_1:
        string val_2 = -268809296(-268809296) + _assetName;
        if((twelvegigs.net.ImageRequest.LoadFromPreCache(filename:  -268809296, textureToSet: out  UnityEngine.Texture2D val_3 = 23272820)) != false)
        {
                val_7 = 0;
        }
        else
        {
                if((twelvegigs.net.ImageRequest.ImageInLocal(imgPath:  -268809296)) == false)
        {
                return;
        }
        
            UnityEngine.Texture2D val_6 = twelvegigs.net.ImageRequest.LoadLocally(remoteURL:  null, fileName:  -268809296);
            val_7 = 0;
        }
        
        this.OnImageLoaded(t:  0);
    }
    private void OnImageLoaded(UnityEngine.Texture2D t)
    {
        UnityEngine.UI.RawImage val_3;
        this.imageLoaded = true;
        val_3 = 1152921504765685760;
        if(t == 0)
        {
                return;
        }
        
        val_3 = this.icon;
        if(val_3 == 0)
        {
                return;
        }
        
        this.icon.texture = t;
    }
    public WGMoreGamesItem()
    {
    
    }

}
