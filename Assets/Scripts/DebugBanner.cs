using UnityEngine;
public class DebugBanner : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform staticBanner;
    private UnityEngine.UI.Text staticBannerText;
    private UnityEngine.Transform dynamicBanner;
    private UnityEngine.GameObject dynamicLogPrefab;
    private float dynamicLogTime;
    private FrameSkipper frameSkipper;
    private static bool isInitialized;
    
    // Methods
    private void Awake()
    {
        var val_11;
        UnityEngine.GameObject val_13;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
            goto label_4;
        }
        
        val_11 = null;
        val_11 = null;
        if(DebugBanner.isInitialized == false)
        {
            goto label_7;
        }
        
        label_4:
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.Object.DestroyImmediate(obj:  -343312944);
        return;
        label_7:
        DebugBanner.isInitialized = true;
        UnityEngine.GameObject val_4 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -343312944);
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.UI.LayoutElement val_6 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -343312944);
        this.frameSkipper = this;
        System.Action val_7 = new System.Action(object:  -343312944, method:  new IntPtr(3951625120));
        System.Delegate val_8 = System.Delegate.Combine(a:  this.dynamicLogPrefab, b:  7454720);
        val_13 = this.dynamicLogPrefab;
        if(val_13 != 0)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        val_13 = 0;
        label_18:
        this.dynamicLogPrefab = val_13;
        MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.dynamicBanner);
        this.ToggleDebugBanner();
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -343312944, name:  -343337056);
        NotificationCenter val_10 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -343312944, name:  -901875952);
    }
    private void UpdateStaticLog()
    {
        Player val_1 = App.Player;
        if(0 == 0)
        {
                "Hacker" = "";
        }
        
        Player val_2 = App.Player;
        if(16 == 0)
        {
                "Troll" = "";
        }
        
        Player val_3 = App.Player;
        if(0.NetworkPurchaser == true)
        {
                "" = "NetworkPurchaser";
        }
        
        string val_5 = System.String.Format(format:  -343208560, arg0:  1098586544, arg1:  1098586544, arg2:  -343208304);
        if(this.staticBannerText == 0)
        {
            
        }
    
    }
    private void UpdateDynamicLog(Notification notif)
    {
        object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.dynamicLogPrefab, parent:  this.dynamicBanner);
        string val_2 = notif.data.ToString();
        object val_3 = this.dynamicLogPrefab.GetComponent<System.Object>();
        System.Collections.IEnumerator val_4 = this.DestroyLogCoroutine(obj:  this.dynamicLogPrefab);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -343050688);
    }
    private System.Collections.IEnumerator DestroyLogCoroutine(UnityEngine.GameObject obj)
    {
        typeof(DebugBanner.<DestroyLogCoroutine>d__10).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(DebugBanner.<DestroyLogCoroutine>d__10).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(DebugBanner.<DestroyLogCoroutine>d__10).__il2cppRuntimeField_14 = obj;
    }
    private void ToggleDebugBanner()
    {
        int val_5 = UnityEngine.PlayerPrefs.GetInt(key:  -901988064, defaultValue:  0);
        UnityEngine.GameObject val_2 = this.staticBanner.gameObject;
        val_5 = (val_5 - 1) >> 5;
        this.staticBanner.SetActive(value:  val_5);
        UnityEngine.GameObject val_4 = this.dynamicBanner.gameObject;
        this.dynamicBanner.SetActive(value:  val_5);
    }
    public DebugBanner()
    {
        this.dynamicLogTime = 3f;
    }
    private static DebugBanner()
    {
    
    }

}
