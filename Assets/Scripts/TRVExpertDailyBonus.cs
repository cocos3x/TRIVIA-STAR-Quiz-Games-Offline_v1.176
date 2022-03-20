using UnityEngine;
public class TRVExpertDailyBonus : WGDailyBonusPopup
{
    // Fields
    private UnityEngine.GameObject pickGiftParent;
    private UnityEngine.GameObject giftAnimationScreen;
    private UnityEngine.UI.Image giftImage;
    private UnityEngine.UI.Text tapToOpenText;
    
    // Methods
    protected override void Init_v2()
    {
        this.Init_v2();
    }
    protected override System.Collections.IEnumerator CheckState()
    {
        return this.CheckState();
    }
    protected override void OnEnable_v2()
    {
        this.OnEnable_v2();
    }
    protected override void OnCoinsAnimFinished_v2()
    {
        this.OnCoinsAnimFinished_v2();
    }
    protected override void OnClick_PickAnotherButton(bool result)
    {
        this.OnClick_PickAnotherButton(result:  result);
    }
    protected override void UpdateDailyBonusUI()
    {
        this.UpdateDailyBonusUI();
    }
    protected override void UpdateReward(DailyBonusRevealedRewardInfo info)
    {
        this.UpdateReward(info:  info);
    }
    protected override void OnClick_ContinueButton()
    {
        this.OnClick_ContinueButton();
    }
    protected override void OnClick_CloseButton()
    {
        this.OnClick_CloseButton();
    }
    protected override void ShowPickAnotherGroup(bool showPickAnotherButton)
    {
        this.ShowPickAnotherGroup(showPickAnotherButton:  showPickAnotherButton);
    }
    protected override void ShowFtuxPickGroup()
    {
        this.ShowFtuxPickGroup();
    }
    protected override void ShowFtuxRewardGroup()
    {
        this.ShowFtuxRewardGroup();
    }
    protected override void HidePickAnotherGroup()
    {
        this.HidePickAnotherGroup();
    }
    protected override void ShowPickRewardText()
    {
        this.ShowPickRewardText();
    }
    public override void OnRewardButtonClick(UnityEngine.GameObject reward)
    {
        System.Action val_25;
        var val_26;
        GiftRewardSource val_27;
        var val_28;
        System.Delegate val_30;
        val_25 = 1152921512050304720;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_26 = public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance();
        mem[1152921512579182956] = reward;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_27 = 2;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_27 = ((public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance().__il2cppRuntimeField_14 - 2)) >> 5;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_9 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_26 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        WADGiftRewardManager val_10 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
        System.Collections.Generic.List<GiftReward> val_12 = GetRewards(rewardsSource:  val_27, expertLeveledUp: out  bool val_11 = true, cardsGranted:  0);
        System.Collections.Generic.IEnumerable<TResult> val_13 = System.Linq.Enumerable.Cast<System.Object>(source:  -1668819968);
        System.Collections.Generic.List<TSource> val_14 = System.Linq.Enumerable.ToList<System.Object>(source:  -1668819968);
        val_25 = public static TRVGiftRewardManager WGGiftRewardManager<TRVGiftRewardManager>::get_Instance();
        if(0 == 0)
        {
            goto label_31;
        }
        
        object val_15 = GetComponent<System.Object>();
        val_28 = null;
        val_28 = null;
        val_25 = TRVExpertDailyBonus.<>c.<>9__18_1;
        if(val_25 == 0)
        {
                val_25 = null;
            val_25 = new System.Action(object:  TRVExpertDailyBonus.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3677342544));
            TRVExpertDailyBonus.<>c.<>9__18_1 = val_25;
        }
        
        val_30 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14;
        System.Delegate val_17 = System.Delegate.Combine(a:  val_30, b:  7454720);
        if(val_30 != 0)
        {
                if(val_30 == null)
        {
            goto label_39;
        }
        
        }
        
        val_30 = 0;
        label_39:
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_30;
        label_31:
        UnityEngine.GameObject val_18 = this.gameObject;
        SLCWindow.CloseWindow(window:  -617598704, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVExpertDailyBonus()
    {
    
    }
    private void <OnRewardButtonClick>b__18_0()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.localScale = new UnityEngine.Vector3();
    }

}
