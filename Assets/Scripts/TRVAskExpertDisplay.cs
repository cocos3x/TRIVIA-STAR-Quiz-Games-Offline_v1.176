using UnityEngine;
public class TRVAskExpertDisplay : FrameSkipper
{
    // Fields
    private UnityEngine.UI.Image expertImage;
    private UnityEngine.UI.Image lockImage;
    private UnityEngine.UI.Image cooldownOverlay;
    private UnityEngine.UI.Text expertName;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Text speedupCostText;
    private TRVExpertProficiencyDisplay proficiencyDisplay;
    private UnityEngine.UI.Button speedUpButton;
    private UnityEngine.UI.Button askExpertButton;
    private UnityEngine.GameObject timerParent;
    private TRVExpert _expert;
    private TRVExpertProgressData myProgressData;
    private string displayingProf;
    public System.Action onClickAction;
    public System.Action onClickSpeedUp;
    
    // Methods
    public void Init(TRVExpert expert, TRVExpertProgressData progData, string profToDisplay)
    {
        ulong val_8;
        var val_11;
        TRVExpertProgressData val_29;
        string val_30;
        System.Collections.Generic.List<TRVCategoryProficiencies> val_31;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_32;
        var val_33;
        val_29 = progData;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_30 = val_1;
            typeof(TRVAskExpertDisplay.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = profToDisplay;
            this._expert = expert;
            this.myProgressData = val_29;
        }
        else
        {
                val_30 = 8;
            mem[8] = profToDisplay;
            this._expert = expert;
            this.myProgressData = val_29;
        }
        
        this.displayingProf = val_30;
        UnityEngine.GameObject val_2 = this.cooldownOverlay.gameObject;
        this.cooldownOverlay.SetActive(value:  false);
        this.expertImage.sprite = expert.mySprite;
        string val_3 = expert.GetLocalizedName;
        this.timerParent.SetActive(value:  false);
        if(val_29 != 0)
        {
                val_31 = progData.<proficiencies>k__BackingField;
            val_32 = null;
            val_33 = 1152921512569788720;
        }
        else
        {
                val_31 = expert.myProfs;
            val_32 = null;
            val_33 = 1152921512569793840;
        }
        
        val_32 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  350531584, method:  new IntPtr(3667979568));
        object val_5 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  val_31, predicate:  7720960);
        this.proficiencyDisplay.DisplayProf(data:  val_31);
        UnityEngine.GameObject val_6 = this.lockImage.gameObject;
        if(val_29 != 0)
        {
                this.lockImage.SetActive(value:  false);
            System.DateTime val_7 = DateTimeCheat.UtcNow;
            System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512569893840}, d2:  new System.DateTime() {dateData = val_8});
            double val_13 = val_11.TotalSeconds;
            val_31 = 1152921504901095424;
            val_29 = 1152921512367249648;
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_30 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance();
            int val_15 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getExpertCooldown;
            val_15 = val_15 * 3600;
            this.timerParent.SetActive(value:  true);
            System.Action val_16 = new System.Action(object:  -626875664, method:  new IntPtr(3667990832));
            mem[1152921512569905928] = null;
            this.askExpertButton.interactable = false;
            UnityEngine.GameObject val_17 = this.speedUpButton.gameObject;
            this.speedUpButton.SetActive(value:  true);
            UnityEngine.GameObject val_18 = this.cooldownOverlay.gameObject;
            this.cooldownOverlay.SetActive(value:  true);
            UnityEngine.GameObject val_19 = this.lockImage.gameObject;
            this.lockImage.SetActive(value:  false);
            this.speedUpButton.m_OnClick.RemoveAllListeners();
            UnityEngine.Events.UnityAction val_20 = new UnityEngine.Events.UnityAction(object:  -626875664, method:  new IntPtr(3668024624));
            this.speedUpButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_23 = (public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 16).ToString();
            if(this.speedupCostText != 0)
        {
                return;
        }
        
            return;
        }
        
        this.lockImage.SetActive(value:  true);
        UnityEngine.GameObject val_24 = this.timerText.gameObject;
        this.timerText.SetActive(value:  false);
        UnityEngine.GameObject val_25 = this.speedUpButton.gameObject;
        this.speedUpButton.SetActive(value:  false);
        this.askExpertButton.interactable = false;
    }
    private void UpdateTimeRemaining()
    {
        ulong val_2;
        var val_5;
        var val_15;
        float val_24;
        var val_25;
        var val_26;
        float val_27;
        var val_28;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        val_24 = 1152921504616751104;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512570145176}, d2:  new System.DateTime() {dateData = val_2});
        val_25 = 0;
        val_26 = 1152921504901095424;
        val_27 = 1152921512367249648;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_28 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance();
        int val_9 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getExpertCooldown;
        val_9 = val_9 * 3600;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_11 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getExpertCooldown;
        System.DateTime val_12 = AddHours(value:  val_5.TotalSeconds);
        val_27 = 0;
        System.DateTime val_13 = DateTimeCheat.UtcNow;
        System.TimeSpan val_14 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512570145168}, d2:  new System.DateTime());
        val_25 = "0";
        string val_18 = val_15.Hours.ToString(format:  1254115712);
        val_26 = ;
        string val_20 = val_15.Minutes.ToString(format:  1254115712);
        string val_22 = val_15.Seconds.ToString(format:  1254115712);
        string val_23 = System.String.Format(format:  -626648400, arg0:  -626636372, arg1:  -626636372, arg2:  -626636372);
        if(this.timerText != 0)
        {
                return;
        }
    
    }
    private void PressSpeedUp()
    {
        if(this.onClickSpeedUp == 0)
        {
                return;
        }
        
        this.onClickSpeedUp.Invoke();
    }
    private void PressAskExpert()
    {
        if(this.onClickAction == 0)
        {
                return;
        }
        
        this.onClickAction.Invoke();
    }
    public TRVAskExpertDisplay()
    {
    
    }

}
