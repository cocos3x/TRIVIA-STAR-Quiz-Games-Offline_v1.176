using UnityEngine;
public class ForestFrenzyUI : MonoSingleton<ForestFrenzyUI>
{
    // Fields
    private UnityEngine.CanvasGroup titleGroup;
    private UnityEngine.CanvasGroup growGroup;
    private UnityEngine.CanvasGroup playGroup;
    private UnityEngine.CanvasGroup congratulationsGroup;
    private UnityEngine.CanvasGroup continueGroup;
    private UnityEngine.UI.Image darkOverlay;
    private UnityEngine.UI.Image bottomBackground;
    private UnityEngine.ParticleSystem congratParticleLeft;
    private UnityEngine.ParticleSystem congratParticleRight;
    private UnityEngine.Transform forestContentParent;
    private UnityEngine.UI.Text forestNameText;
    private UnityEngine.UI.Text growthProgressText;
    private UnityEngine.UI.Slider growthProgress;
    private UnityEngine.UI.Text growthCostText;
    private UnityEngine.UI.Text playLevelText;
    private UnityEngine.UI.Button homeButton;
    private UnityEngine.UI.Button forestInfoButton;
    private UnityEngine.UI.Button growButton;
    private UnityEngine.UI.Text growButtonText;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button continueButton;
    private WordForest.WFOForestContent forestContent;
    private UnityEngine.GameObject FTUXTooltip_1;
    private UnityEngine.GameObject FTUXPointer;
    private UnityEngine.UI.Image growButtonGlow;
    private UnityEngine.UI.Button tooltipContinueButton;
    private UnityEngine.UI.Image continueButtonGlow;
    private UnityEngine.Transform continueButtonPointerScaler;
    private WordForest.WFOSeedParticles seedParticlesPrefab;
    private UnityEngine.UI.Text currencyAmountText;
    private UnityEngine.UI.Button button_back_home;
    private UnityEngine.CanvasGroup eventCountdownGroup;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Text tutorialText;
    private ForestFrenzyManager forestManager;
    private int _tutorialCompleted;
    
    // Properties
    private int tutorialCompleted { get; set; }
    
    // Methods
    private int get_tutorialCompleted()
    {
        if(this._tutorialCompleted != 1)
        {
                return (int)this._tutorialCompleted;
        }
        
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1390172864, defaultValue:  0);
        mem2[0] = val_1;
        return val_1;
    }
    private void set_tutorialCompleted(int value)
    {
        this._tutorialCompleted = value;
        UnityEngine.PlayerPrefs.SetInt(key:  -1390172864, value:  value);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void OnFrameSkipperUpdate()
    {
        this.SetTimerText(timeEnd:  new System.DateTime() {dateData = ForestFrenzyEventHandler.<Instance>k__BackingField});
    }
    private void Start()
    {
        var val_29;
        var val_30;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.forestManager = public static ForestFrenzyManager MonoSingleton<ForestFrenzyManager>::get_Instance();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1389757488, method:  new IntPtr(2905138704));
        this.forestInfoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1389757488, method:  new IntPtr(2905147920));
        this.growButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1389757488, method:  new IntPtr(2905157136));
        this.tooltipContinueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1389757488, method:  new IntPtr(2905166352));
        this.button_back_home.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1389757488, method:  new IntPtr(2905175568));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        string val_7 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_8 = App.Player;
        string val_9 = 0.ToString();
        string val_10 = System.String.Format(format:  -1672741904, arg0:  -1389769524);
        var val_29 = 22599572;
        val_29 = 13028384 + val_29;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_29 = null;
        val_29 = null;
        string val_11 = ForestFrenzyEventProgress.accumulatedCurrency.ToString();
        this.InitialiseForestLayout();
        this.InitializeUI();
        this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
        if((MonoExtensions.IsBitSet(value:  this.tutorialCompleted, bit:  2)) != false)
        {
                if((MonoExtensions.IsBitSet(value:  this.tutorialCompleted, bit:  3)) == true)
        {
            goto label_28;
        }
        
        }
        
        val_30 = null;
        val_30 = null;
        if((ForestFrenzyEventProgress.forestMapData.CurrentForestGrowth(includeDamagedTrees:  true)) >= 1)
        {
                this.tutorialCompleted = MonoExtensions.SetBit(value:  this.tutorialCompleted, bit:  5);
            this.tutorialCompleted = MonoExtensions.SetBit(value:  this.tutorialCompleted, bit:  2);
            this.tutorialCompleted = MonoExtensions.SetBit(value:  this.tutorialCompleted, bit:  3);
        }
        
        label_28:
        bool val_24 = MonoExtensions.IsBitSet(value:  this.tutorialCompleted, bit:  2);
        if(val_24 == false)
        {
                val_24 = this;
            this.StartFTUX_1();
        }
        
        System.Action val_25 = new System.Action(object:  -1389757488, method:  new IntPtr(2905166352));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
        UnityEngine.GameObject val_26 = this.gameObject;
        object val_27 = this.AddComponent<System.Object>();
        System.Action val_28 = new System.Action(object:  -1389757488, method:  new IntPtr(2905184784));
        this.congratulationsGroup = null;
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -1389596336, method:  new IntPtr(2905166352));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    private DG.Tweening.Sequence DoCompleteForestSequence()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.titleGroup, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.titleGroup);
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.darkOverlay, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.darkOverlay);
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.growGroup, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  -1389454640, method:  new IntPtr(2905471248));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.growGroup, action:  190734336);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.growGroup);
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.playGroup, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  -1389454640, method:  new IntPtr(2905476368));
        object val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.playGroup, action:  190734336);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.playGroup);
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.eventCountdownGroup, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.eventCountdownGroup);
        DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.congratulationsGroup, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.congratulationsGroup);
        DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  -1389454640, method:  new IntPtr(2905485584));
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.TweenCallback val_20 = new DG.Tweening.TweenCallback(object:  -1389454640, method:  new IntPtr(2905486608));
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.TweenCallback val_22 = new DG.Tweening.TweenCallback(object:  -1389454640, method:  new IntPtr(2905487632));
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
    }
    private void StartFTUX_1()
    {
        this.FTUXTooltip_1.SetActive(value:  true);
        this.FTUXPointer.SetActive(value:  true);
        UnityEngine.GameObject val_1 = this.growButtonGlow.gameObject;
        this.growButtonGlow.SetActive(value:  true);
        string val_2 = Localization.Localize(key:  -1389325488, defaultValue:  -1389325680, useSingularKey:  false);
        string val_3 = this.forestManager.CurrentForestName;
        string val_4 = System.String.Format(format:  -1389325488, arg0:  this.forestManager);
        this.StartGrowButtonPointerAnim();
    }
    private void EndFTUX_1()
    {
        this.FTUXTooltip_1.SetActive(value:  false);
        this.FTUXPointer.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.growButtonGlow.gameObject;
        this.growButtonGlow.SetActive(value:  false);
        this.tutorialCompleted = MonoExtensions.SetBit(value:  this.tutorialCompleted, bit:  2);
    }
    private void InitializeUI()
    {
        var val_3;
        int val_1 = this.forestManager.CurrentForestGrowth;
        WordForest.WFOForestData val_2 = CurrentForestData;
        if(val_1 >= val_3)
        {
                bool val_4 = val_2.stages + 148.IsAtLastForest;
        }
        
        if(val_1 >= val_3)
        {
                0 = 1f;
            1f = 0;
        }
        
        val_2.stages + 24.alpha = 0f;
        PluginExtension.SetColorAlpha(graphic:  val_2.stages + 32, a:  0f);
        val_2.stages + 12.alpha = 0f;
        val_2.stages + 16.alpha = 0f;
        if(val_1 < val_3)
        {
                0 = 1;
        }
        
        val_2.stages + 16.blocksRaycasts = true;
        PluginExtension.SetColorAlpha(graphic:  val_2.stages + 36, a:  0f);
        UnityEngine.GameObject val_5 = val_2.stages + 88.gameObject;
        val_2.stages + 88.SetActive(value:  true);
        val_2.stages + 20.alpha = 0f;
        val_2.stages + 20.blocksRaycasts = true;
        UnityEngine.GameObject val_6 = val_2.stages + 136.gameObject;
        val_2.stages + 136.SetActive(value:  true);
    }
    private void InitialiseForestLayout()
    {
        int val_4;
        var val_7;
        if(this.forestContent != 0)
        {
                UnityEngine.GameObject val_2 = this.forestContent.gameObject;
            UnityEngine.Object.Destroy(obj:  this.forestContent);
            this.forestContent = 0;
        }
        
        WordForest.WFOForestData val_3 = CurrentForestData;
        WordForest.WFOForestContent val_5 = val_3.bgType.GetForestLayout(forestId:  val_4);
        object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  val_3.bgType, parent:  val_3.stages + 48);
        mem2[0] = val_3.bgType;
        val_7 = null;
        val_7 = null;
        val_3.bgType.Initialize(forestMap:  ForestFrenzyEventProgress.forestMapData);
    }
    private void UpdateForestInfo(bool animated = False, bool skipButtonStates = False)
    {
        var val_3;
        var val_14;
        int val_1 = this.forestManager.CurrentForestGrowth;
        WordForest.WFOForestData val_2 = CurrentForestData;
        bool val_4 = val_2.bgType + 148.CurrentForestContainsDamagedTrees;
        WordForest.WFOForestData val_6 = CurrentForestData;
        if(val_4.CurrentForestGrowth < val_3)
        {
                0 = 1;
        }
        
        val_6.stages.interactable = true;
        string val_7 = val_6.bgType + 148.CurrentForestName;
        string val_8 = Localization.Localize(key:  -1388786160, defaultValue:  -1388786240, useSingularKey:  false);
        string val_9 = System.String.Format(format:  -1694782544, arg0:  -1388786160, arg1:  13152256, arg2:  13152256);
        string val_11 = val_6.bgType + 148.CurrentGrowthCost.ToString();
        if(val_4 != false)
        {
                val_14 = "FIX";
        }
        else
        {
                string val_12 = Localization.Localize(key:  -1388785904, defaultValue:  -1388785984, useSingularKey:  false);
            val_14 = "grow_upper";
        }
        
        if(animated != false)
        {
                float val_14 = (float)val_3;
            val_14 = (float)val_1 / val_14;
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOValue(target:  val_6.bgType + 60, endValue:  val_14, duration:  null, snapping:  val_14);
            return;
        }
        
        float val_15 = (float)val_3;
        val_15 = (float)val_1 / val_15;
    }
    private void PlayPlantingAnimation(UnityEngine.Transform treeTransform)
    {
        UnityEngine.Transform val_1 = this.growButton.transform;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.seedParticlesPrefab, parent:  this.growButton);
        UnityEngine.Vector3 val_3 = position;
        this.seedParticlesPrefab.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  3);
    }
    private void OnForestInfoButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void OnGrowButtonClicked()
    {
        var val_6;
        var val_16;
        DG.Tweening.Sequence val_17;
        var val_18;
        var val_19;
        var val_16 = 22594592;
        val_16 = 13033364 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_16 = null;
        val_16 = null;
        int val_1 = CurrentGrowthCost;
        if(ForestFrenzyEventProgress.accumulatedCurrency < val_1)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
            return;
        }
        
        val_17 = val_1.CurrentForestGrowth;
        WordForest.WFOForestData val_5 = CurrentForestData;
        if(val_17 >= val_6)
        {
            goto label_13;
        }
        
        val_5.stages + 148.AddGrowth(damagedTreeIdToFix:  0, onServerResponse:  0);
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_18 = null;
        val_18 = null;
        string val_7 = ForestFrenzyEventProgress.accumulatedCurrency.ToString();
        val_19 = 0;
        bool val_9 = MonoExtensions.IsBitSet(value:  val_5.stages.tutorialCompleted, bit:  2);
        System.Collections.Generic.List<UnityEngine.Transform> val_10 = val_5.stages + 96.AddGrowth(addGrowth:  1);
        goto label_22;
        label_25:
        if((val_5.stages + 96) <= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = val_5.stages + 96 + 8;
        val_17 = val_17 + 0;
        val_5.stages.PlayPlantingAnimation(treeTransform:  (val_5.stages + 96 + 8 + 0) + 16);
        val_19 = 1;
        label_22:
        if(val_19 < (val_5.stages + 96 + 12))
        {
            goto label_25;
        }
        
        val_17 = val_5.stages + 96 + 12.CurrentForestGrowth;
        WordForest.WFOForestData val_12 = CurrentForestData;
        if(val_17 >= val_6)
        {
                DG.Tweening.Sequence val_13 = val_12.stages.DoCompleteForestSequence();
            val_17 = val_12.stages;
            val_12.stages + 96.AddAnimationSequence(nextSequence:  val_17);
        }
        
        val_12.stages.UpdateForestInfo(animated:  true, skipButtonStates:  false);
        bool val_15 = MonoExtensions.IsBitSet(value:  val_12.stages.tutorialCompleted, bit:  2);
        if(val_15 == false)
        {
                val_15 = val_12.stages;
            val_15.EndFTUX_1();
        }
        
        return;
        label_13:
        val_5.stages + 80.interactable = false;
    }
    private void RewardForestComplete()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardForestComplete();
    }
    private void OnAndroidBackButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseForestScene(playClicked:  false);
    }
    private void StartGrowButtonPointerAnim()
    {
        int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.growButtonGlow, complete:  false);
        PluginExtension.SetColorAlpha(graphic:  this.growButtonGlow, a:  null);
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.growButtonGlow, endValue:  null, duration:  null);
        object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.growButtonGlow, ease:  7);
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.growButtonGlow);
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.growButtonGlow, endValue:  null, duration:  null);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.growButtonGlow, ease:  7);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.growButtonGlow);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
        UnityEngine.Transform val_10 = this.FTUXPointer.transform;
        int val_11 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.FTUXPointer, complete:  false);
        DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_13 = this.FTUXPointer.transform;
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.FTUXPointer, endValue:  null, duration:  null);
        object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.FTUXPointer, ease:  5);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.FTUXPointer);
        UnityEngine.Transform val_17 = this.FTUXPointer.transform;
        DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.FTUXPointer, endValue:  null, duration:  null);
        object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.FTUXPointer, ease:  5);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.FTUXPointer);
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        object val_22 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
    }
    private void OnTooltipContinueButtonClicked()
    {
        UnityEngine.Debug.LogError(message:  -1387892240);
    }
    private void OnPlayButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnPlayLevelButtonClicked();
    }
    private void SetTimerText(System.DateTime timeEnd)
    {
        long val_6;
        ulong val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_18 = R2;
        val_19 = 0;
        val_20 = null;
        val_20 = null;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_18}, d2:  new System.DateTime() {dateData = System.DateTime.MaxValue})) != false)
        {
                if(this.timerText != 0)
        {
                return;
        }
        
            return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921511809133608});
        val_21 = null;
        val_21 = null;
        if((System.TimeSpan.Compare(t1:  new System.TimeSpan() {_ticks = val_6}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == 1)
        {
                val_22 = null;
            val_22 = null;
        }
        
        val_19 = "00";
        string val_10 = System.TimeSpan.Zero.Days.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_12 = System.TimeSpan.Zero.Hours.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_14 = System.TimeSpan.Zero.Minutes.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_16 = System.TimeSpan.Zero.Seconds.ToString(format:  -1827641632);
        val_18;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_18;
        string val_17 = System.String.Format(format:  -1467818752, args:  472754880);
    }
    public ForestFrenzyUI()
    {
        this._tutorialCompleted = 0;
    }
    private void <DoCompleteForestSequence>b__42_0()
    {
        this.growGroup.blocksRaycasts = false;
    }
    private void <DoCompleteForestSequence>b__42_1()
    {
        this.playGroup.blocksRaycasts = true;
    }
    private void <DoCompleteForestSequence>b__42_2()
    {
        this.congratParticleLeft.Play();
    }
    private void <DoCompleteForestSequence>b__42_3()
    {
        this.congratParticleRight.Play();
    }
    private void <DoCompleteForestSequence>b__42_4()
    {
        this.RewardForestComplete();
    }

}
