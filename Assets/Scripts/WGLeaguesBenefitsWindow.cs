using UnityEngine;
public class WGLeaguesBenefitsWindow : MonoBehaviour
{
    // Fields
    private UGUINetworkedButton joinClubButton;
    private UnityEngine.UI.Button showInfoButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text benifitText;
    
    // Methods
    private void Awake()
    {
        var val_8;
        System.Action<System.Boolean> val_9;
        var val_10;
        UnityEngine.Events.UnityAction val_11;
        val_8 = 1152921504614248448;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -1725997088, method:  new IntPtr(2568918560));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.joinClubButton.OnConnectionClick, b:  7401472);
        val_9 = this.joinClubButton.OnConnectionClick;
        if(val_9 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_9 = 0;
        label_4:
        this.joinClubButton.OnConnectionClick = val_9;
        val_10 = 1152921504769093632;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1725997088, method:  new IntPtr(2568927776));
        this.showInfoButton.m_OnClick.AddListener(call:  162246656);
        val_11 = null;
        val_11 = new UnityEngine.Events.UnityAction(object:  -1725997088, method:  new IntPtr(2568936992));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        if(this.benifitText == 0)
        {
                return;
        }
        
        GameBehavior val_6 = App.getBehavior;
        if(this.benifitText == 0)
        {
            
        }
    
    }
    private void onClick_ShowInfo()
    {
        var val_7;
        System.Action val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        val_7 = null;
        val_7 = null;
        val_9 = WGLeaguesBenefitsWindow.<>c.<>9__5_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  WGLeaguesBenefitsWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2569093024));
            WGLeaguesBenefitsWindow.<>c.<>9__5_0 = val_9;
        }
        
        val_10 = 1;
        System.Delegate val_5 = System.Delegate.Combine(a:  1, b:  7454720);
        if(val_10 != 0)
        {
                if(21384261 == null)
        {
            goto label_13;
        }
        
        }
        
        val_10 = 0;
        label_13:
        mem[20] = val_10;
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1725849248, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnConnectionClick(bool connected)
    {
        WGLeaguesBenefitsWindow val_13;
        var val_14;
        System.String[] val_15;
        var val_16;
        WGLeaguesBenefitsWindow val_17;
        var val_18;
        val_13 = this;
        if(connected != false)
        {
                val_14 = 13;
            if(SceneDictator.IsInGameScene() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == true)
        {
                val_14 = 15;
        }
        
        }
        
            val_15 = 6919328 + 28706463;
            if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
            val_16 = null;
            val_16 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = 15;
            GameBehavior val_4 = App.getBehavior;
            if(0 != 4)
        {
                GameBehavior val_5 = App.getBehavior;
        }
        
            val_17 = val_13;
        }
        else
        {
                GameBehavior val_7 = App.getBehavior;
            string val_9 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_10 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            val_15 = null;
            string val_11 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_18 = 0;
            if(val_18 == 0)
        {
                val_18 = 0;
        }
        
            val_18.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  val_15, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
            val_17 = val_13;
        }
        
        UnityEngine.GameObject val_12 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1725735552, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGLeaguesBenefitsWindow()
    {
    
    }
    private void <Awake>b__4_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1725511552, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
