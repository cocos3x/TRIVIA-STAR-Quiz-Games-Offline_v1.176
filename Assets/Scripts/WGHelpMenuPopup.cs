using UnityEngine;
public class WGHelpMenuPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button howToPlayButton;
    private UGUINetworkedButton privacyButton;
    private UnityEngine.UI.Text versionText;
    private UnityEngine.UI.Text supportIDText;
    
    // Properties
    private string url_privacy { get; }
    
    // Methods
    private string get_url_privacy()
    {
        AppConfigs val_1 = App.Configuration;
        if(1 != 0)
        {
                return;
        }
    
    }
    private void Awake()
    {
        if(this.howToPlayButton != 0)
        {
                UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -30962752, method:  new IntPtr(4263974400));
            this.howToPlayButton.m_OnClick.AddListener(call:  162246656);
        }
        
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  -30962752, method:  new IntPtr(4263979520));
        this.privacyButton.OnConnectionClick = null;
    }
    private void OnEnable()
    {
        string val_1 = DeviceIdPlugin.GetClientVersion();
        Player val_2 = App.Player;
        if(this.supportIDText == 0)
        {
            
        }
    
    }
    private void OnClick_Privacy(bool connected)
    {
        var val_14;
        this.privacyButton.interactable = false;
        if(connected != false)
        {
                string val_1 = this.privacyButton.url_privacy;
            twelvegigs.plugins.SharePlugin.OpenURL(url:  this.privacyButton);
            this.privacyButton.interactable = true;
            return;
        }
        
        object val_2 = new System.Object();
        object val_3 = this.GetComponent<System.Object>();
        System.Action val_4 = new System.Action(object:  this.versionText, method:  new IntPtr(2791752480));
        typeof(WGHelpMenuPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = null;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_7 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_8 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_9 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_14 = null;
        val_14 = null;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        else
        {
                SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        
        object val_10 = GetComponent<System.Object>();
        System.Action val_11 = new System.Action(object:  389296128, method:  new IntPtr(4264249600));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = null;
        object val_12 = this.GetComponent<System.Object>();
        this.versionText = 0;
        UnityEngine.GameObject val_13 = this.gameObject;
        SLCWindow.CloseWindow(window:  -30692672, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickHowToPlay()
    {
        object val_1 = new System.Object();
        object val_2 = this.GetComponent<System.Object>();
        System.Action val_3 = new System.Action(object:  this.versionText, method:  new IntPtr(2791752480));
        typeof(WGHelpMenuPopup.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = null;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_6 = GetComponent<System.Object>();
        System.Action val_7 = new System.Action(object:  389349376, method:  new IntPtr(4264379008));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = null;
        object val_8 = this.GetComponent<System.Object>();
        this.versionText = 0;
        UnityEngine.GameObject val_9 = this.gameObject;
        SLCWindow.CloseWindow(window:  -30563264, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGHelpMenuPopup()
    {
    
    }

}
