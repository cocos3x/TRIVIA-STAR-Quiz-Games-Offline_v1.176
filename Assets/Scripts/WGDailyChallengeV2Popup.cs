using UnityEngine;
public class WGDailyChallengeV2Popup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button CloseBtn;
    private UnityEngine.UI.Button HelpBtn;
    private UnityEngine.UI.Button mainScreenBtn;
    private UnityEngine.GameObject InfoPopup;
    private WGZooTileRewardPopup zooTileRewardPopup;
    private WGDailyChallengeCalendarDisplay calendar;
    private DailyChallengeProgressUI weeklyProgressUI;
    private DailyChallengeProgressUI monthlyProgressUI;
    public static System.Action onMainScreenBtnClicked;
    public static ZooTile newZooTile;
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.zooTileRewardPopup.gameObject;
        this.zooTileRewardPopup.SetActive(value:  false);
        this.InfoPopup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -70751024, method:  new IntPtr(4224172816));
        this.CloseBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -70751024, method:  new IntPtr(4224182032));
        this.HelpBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -70751024, method:  new IntPtr(4224191248));
        this.mainScreenBtn.m_OnClick.AddListener(call:  162246656);
        this.DisableScreenButton();
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -70751024, name:  -1450078832);
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -70751024, name:  -1451370720);
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -70751024, name:  -1451784672);
    }
    private void OnEnable()
    {
        var val_6;
        ZooTile val_7;
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HideBanner();
        val_6 = null;
        val_6 = null;
        val_7 = WGDailyChallengeV2Popup.newZooTile;
        if(val_7 != 0)
        {
                val_7 = WGDailyChallengeV2Popup.newZooTile;
            this.OpenZooTileRewardPopup(tile:  val_7);
            WGDailyChallengeV2Popup.newZooTile = 0;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                this.weeklyProgressUI.InitializeWeeklyProgress(starsToAnimate:  0);
            this.monthlyProgressUI.InitializeMonthlyProgress(starsToAnimate:  0);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -70597040, method:  new IntPtr(4224345232));
        System.Delegate val_5 = System.Delegate.Combine(a:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_5C, b:  7454720);
        val_8 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_5C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_21;
        }
        
        }
        
        val_8 = 0;
        label_21:
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_5C = val_8;
    }
    private void OnDisable()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  -70476848, method:  new IntPtr(4224345232));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_5C, value:  7454720);
        val_4 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_5C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_5C = val_4;
    }
    public bool IsZooTileRewardPopupActive()
    {
        UnityEngine.GameObject val_1 = this.zooTileRewardPopup.gameObject;
        if(this.zooTileRewardPopup != 0)
        {
                return this.zooTileRewardPopup.activeInHierarchy;
        }
        
        return this.zooTileRewardPopup.activeInHierarchy;
    }
    private void HandleTooltipReadyToShow()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsTooltipReadyToShow() == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.zooTileRewardPopup.gameObject;
        if(this.zooTileRewardPopup.activeInHierarchy != false)
        {
                System.Action val_5 = new System.Action(object:  -70231344, method:  new IntPtr(4224706832));
            this.zooTileRewardPopup.OnZooTileRewardCollected = null;
            return;
        }
        
        this.calendar.HandleTooltipShowing();
    }
    private void HandleTooltipShowing()
    {
        this.calendar.HandleTooltipShowing();
    }
    private void OnMainScreenButtonClicked()
    {
        var val_3;
        System.Action val_4;
        UnityEngine.GameObject val_1 = this.mainScreenBtn.gameObject;
        if(this.mainScreenBtn.activeInHierarchy == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        val_4 = WGDailyChallengeV2Popup.onMainScreenBtnClicked;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = WGDailyChallengeV2Popup.onMainScreenBtnClicked;
        if(val_4 == 0)
        {
                val_4 = 0;
        }
        
        val_4.Invoke();
    }
    private void EnableScreenButton()
    {
        UnityEngine.GameObject val_1 = this.mainScreenBtn.gameObject;
        this.mainScreenBtn.SetActive(value:  true);
    }
    private void DisableScreenButton()
    {
        UnityEngine.GameObject val_1 = this.mainScreenBtn.gameObject;
        this.mainScreenBtn.SetActive(value:  false);
    }
    private void OpenDailyChallengeInfoPopup()
    {
        this.InfoPopup.SetActive(value:  true);
    }
    private void OpenZooTileRewardPopup(ZooTile tile)
    {
        var val_4;
        var val_4 = 26640803;
        val_4 = 8984984 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(App.game == 18)
        {
                GameBehavior val_1 = App.getBehavior;
            0.Setup(rewardSource:  4);
            return;
        }
        
        this.zooTileRewardPopup.Setup(tile:  tile);
        UnityEngine.GameObject val_3 = this.zooTileRewardPopup.gameObject;
        this.zooTileRewardPopup.SetActive(value:  true);
    }
    private void OnRewardCollected()
    {
        this.weeklyProgressUI.InitializeWeeklyProgress(starsToAnimate:  0);
        this.monthlyProgressUI.InitializeMonthlyProgress(starsToAnimate:  0);
    }
    private void ClosePopup()
    {
        var val_8;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -69241136, setDestroyOnDisableState:  true, dontDestroyOnDisable:  true);
        val_8 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            var val_7 = 26644427;
            val_7 = 8986804 + val_7;
            if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_68 = 0;
        }
        
        GameBehavior val_5 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        GameBehavior val_6 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public WGDailyChallengeV2Popup()
    {
    
    }
    private static WGDailyChallengeV2Popup()
    {
    
    }

}
