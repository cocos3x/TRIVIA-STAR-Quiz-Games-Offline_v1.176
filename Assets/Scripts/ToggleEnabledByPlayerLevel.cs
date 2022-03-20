using UnityEngine;
public class ToggleEnabledByPlayerLevel : MonoBehaviour
{
    // Fields
    public const string ON_REFRESH_NOTIFICATION = "OnRefreshNotification";
    private int unlockLevel;
    private bool enableAtLevel;
    private bool awake;
    private bool start;
    private bool enable;
    private UnityEngine.GameObject target;
    private bool ToggleInDailyChallenge;
    private bool hideInFTUX;
    private UnityEngine.UI.Button[] _childButtons;
    
    // Properties
    public int getLevelReq { get; }
    private UnityEngine.UI.Button[] GetChildButtons { get; }
    
    // Methods
    public int get_getLevelReq()
    {
        return (int)this.unlockLevel;
    }
    private UnityEngine.UI.Button[] get_GetChildButtons()
    {
        if(this._childButtons != null)
        {
                return;
        }
        
        T[] val_1 = R4 + 20.GetComponentsInChildren<System.Object>(includeInactive:  true);
        mem2[0] = R4 + 20;
    }
    private void Awake()
    {
        if(this.target == 0)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            this.target = this;
        }
        
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -184385456, name:  -1447293216);
        if(this.awake == false)
        {
                return;
        }
        
        this.DoUnlockLogic();
    }
    private void Start()
    {
        if(this.start == false)
        {
                return;
        }
        
        this.DoUnlockLogic();
    }
    private void OnEnable()
    {
        if(this.enable == false)
        {
                return;
        }
        
        this.DoUnlockLogic();
    }
    private void DoUnlockLogic()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if(WGFTUXManager.IsShowing != true)
        {
                if(WGFTUXManager.CanShow == false)
        {
            goto label_3;
        }
        
        }
        
        if(this.hideInFTUX == false)
        {
            goto label_3;
        }
        
        if(this.target != 0)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        val_16 = 0;
        goto label_5;
        label_3:
        if(this.ToggleInDailyChallenge == true)
        {
            goto label_6;
        }
        
        val_17 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
            goto label_15;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_15;
        }
        
        UnityEngine.GameObject val_7 = this.target.gameObject;
        if(this.target != 0)
        {
            goto label_17;
        }
        
        goto label_18;
        label_15:
        if(this.ToggleInDailyChallenge == false)
        {
            goto label_29;
        }
        
        label_6:
        if(this.hideInFTUX != false)
        {
                val_17 = 1152921511748222336;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1448559232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.MakeChildButtonsInteractable(interactable:  (public static DailyChallengeTutorialManager MonoSingleton<DailyChallengeTutorialManager>::get_Instance().__il2cppRuntimeField_D) >> 5);
        }
        
        }
        
        label_29:
        if(this.enableAtLevel != false)
        {
                GameBehavior val_14 = App.getBehavior;
            val_18 = 0;
            if(0 >= this.unlockLevel)
        {
                val_19 = 1;
        }
        
        }
        else
        {
                GameBehavior val_15 = App.getBehavior;
            val_18 = 0;
            if(0 < this.unlockLevel)
        {
                val_19 = 1;
        }
        
        }
        
        val_16 = 1;
        label_5:
        this.target.SetActive(value:  true);
    }
    public void SetLevelRequirement(int level)
    {
        var val_8;
        this.unlockLevel = level;
        val_8 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 >= this.unlockLevel)
        {
                if(this.enableAtLevel != false)
        {
                GameBehavior val_3 = App.getBehavior;
            if(0 >= this.unlockLevel)
        {
                val_8 = 1;
        }
        
        }
        else
        {
                GameBehavior val_4 = App.getBehavior;
            if(0 < this.unlockLevel)
        {
                val_8 = 1;
        }
        
        }
        
            this.target.SetActive(value:  true);
        }
        
        if(this.ToggleInDailyChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_7 = R4.gameObject;
        R4.SetActive(value:  false);
    }
    public void OnRefreshNotification()
    {
        this.DoUnlockLogic();
    }
    private void MakeChildButtonsInteractable(bool interactable)
    {
        goto label_0;
        label_5:
        UnityEngine.UI.Button[] val_1 = this.GetChildButtons;
        ToggleEnabledByPlayerLevel.__il2cppRuntimeField_byval_arg.interactable = interactable;
        0 = 1;
        label_0:
        UnityEngine.UI.Button[] val_2 = this.GetChildButtons;
        if(0 < this.unlockLevel)
        {
            goto label_5;
        }
    
    }
    public ToggleEnabledByPlayerLevel()
    {
        this.enableAtLevel = true;
        this.unlockLevel = true;
        this.start = true;
        this.ToggleInDailyChallenge = true;
        this.hideInFTUX = true;
    }

}
