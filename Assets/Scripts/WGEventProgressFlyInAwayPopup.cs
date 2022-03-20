using UnityEngine;
public class WGEventProgressFlyInAwayPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform flyoutRectTransform;
    private UnityEngine.UI.Text titleText;
    private UnityEngine.UI.Image eventIconImage;
    private UnityEngine.UI.Image rewardIconImage;
    private UnityEngine.UI.Slider progressSlider;
    private UnityEngine.UI.Text textProgress;
    private UnityEngine.Sprite icon_lightningLevel;
    private UnityEngine.Sprite icon_wildWord;
    private UnityEngine.Sprite iconCoins;
    private UnityEngine.Sprite iconGold;
    private UnityEngine.Sprite iconFood;
    private UnityEngine.Sprite iconGiftBox;
    private System.Collections.Generic.List<WGEventProgressFlyInAwayPopup.EventProgressPopupData> eventsProgressPopupData;
    private WGEventProgressFlyInAwayPopup.EventProgressPopupData currentEventProgressPopupData;
    private float progressStart;
    private float progressEnd;
    private string textProgressStart;
    private string textProgressEnd;
    
    // Methods
    public void SetUp(WGEventHandler handler, System.Action onCLoseCallback)
    {
        System.Collections.Generic.List<EventProgressPopupData> val_7;
        object val_1 = new System.Object();
        typeof(WGEventProgressFlyInAwayPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = handler;
        val_7 = this.eventsProgressPopupData;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.eventsProgressPopupData = val_7;
        }
        
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  387698688, method:  new IntPtr(4237634064));
        object val_4 = Find(match:  8040448);
        if(val_7 != 0)
        {
                return;
        }
        
        if(val_7 == 0)
        {
                WordRegion val_5 = WordRegion.instance;
            0.AddLevelCompleteBlocker(blocker:  4);
        }
        
        if(new System.Object() != 0)
        {
                typeof(WGEventProgressFlyInAwayPopup.EventProgressPopupData).__il2cppRuntimeField_8 = typeof(WGEventProgressFlyInAwayPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        else
        {
                mem[8] = typeof(WGEventProgressFlyInAwayPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        
        typeof(WGEventProgressFlyInAwayPopup.EventProgressPopupData).__il2cppRuntimeField_C = onCLoseCallback;
        this.eventsProgressPopupData.Add(item:  387645440);
    }
    private void Start()
    {
        if(this.eventsProgressPopupData == 0)
        {
                return;
        }
        
        if(this.eventsProgressPopupData < 1)
        {
                return;
        }
        
        System.Collections.IEnumerator val_1 = this.ShowPopup();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -57160368);
    }
    private void SetUpUI()
    {
        string val_20;
        var val_21;
        var val_22;
        float val_23;
        bool val_24;
        string val_25;
        var val_26;
        val_20 = 7249292 + 28378728;
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        if(this.currentEventProgressPopupData.eventHandler.myEvent != 0)
        {
                "" = this.currentEventProgressPopupData.eventHandler.myEvent.type;
        }
        
        if((System.String.op_Equality(a:  mem[this.currentEventProgressPopupData.eventHandler.myEvent.type], b:  -1266462304)) == false)
        {
            goto label_4;
        }
        
        this.eventIconImage.sprite = this.icon_lightningLevel;
        this.rewardIconImage.sprite = this.iconCoins;
        this.progressStart = LightningLevelsEventHandler.<Instance>k__BackingField;
        val_21 = 1152921504932937728;
        if((LightningLevelsEventHandler.<Instance>k__BackingField) == 0)
        {
            goto label_10;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = 0;
        if(((LightningLevelsEventHandler.__il2cppRuntimeField_typeHierarchy + (WFOLightningLevelsEventHandler.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_22)
        {
                LightningLevelsEventHandler.<Instance>k__BackingField = 0;
        }
        
        val_23 = LightningLevelsEventHandler.<Instance>k__BackingField;
        goto label_14;
        label_4:
        if((System.String.op_Equality(a:  mem[this.currentEventProgressPopupData.eventHandler.myEvent.type], b:  -1280644912)) == false)
        {
                return;
        }
        
        this.eventIconImage.sprite = this.icon_wildWord;
        this.rewardIconImage.sprite = this.iconGiftBox;
        val_24 = 1152921504928358400;
        float val_20 = (float)WildWeekendHandler.econ_default_award.GetLevelsComplete();
        val_20 = val_20 / (float)WildWeekendHandler.econ_default_award.GetLevelsTotal();
        this.progressStart = val_20;
        float val_21 = (float)WildWeekendHandler.econ_default_award.GetLevelsTotal();
        val_21 = ((float)WildWeekendHandler.econ_default_award.GetLevelsComplete() + 1) / val_21;
        this.progressEnd = val_21;
        string val_9 = WildWeekendHandler.econ_default_award.GetLevelsComplete().ToString();
        string val_11 = WildWeekendHandler.econ_default_award.GetLevelsTotal().ToString();
        val_21 = "{0}/{1} LEVELS";
        string val_12 = System.String.Format(format:  -1322846112, arg0:  -56986676, arg1:  -56986676);
        this.textProgressStart = "{0}/{1} LEVELS";
        int val_13 = WildWeekendHandler.econ_default_award.GetLevelsComplete();
        val_13 = val_13 + 1;
        string val_14 = val_13.ToString();
        string val_16 = WildWeekendHandler.econ_default_award.GetLevelsTotal().ToString();
        val_25 = "{0}/{1} LEVELS";
        string val_17 = System.String.Format(format:  -1322846112, arg0:  -56986676, arg1:  -56986676);
        goto label_26;
        label_10:
        val_23 = 0f;
        label_14:
        float val_18 = val_23.GetNextEventProgressValue();
        this.progressEnd = val_23;
        val_24 = true;
        this.textProgressStart = LightningLevelsEventHandler.<Instance>k__BackingField;
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                val_26 = null;
            val_26 = null;
            val_25 = 0;
            if(((LightningLevelsEventHandler.__il2cppRuntimeField_typeHierarchy + (WFOLightningLevelsEventHandler.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_26)
        {
                LightningLevelsEventHandler.<Instance>k__BackingField = 0;
        }
        
            val_25 = LightningLevelsEventHandler.<Instance>k__BackingField;
        }
        else
        {
                val_25 = 0;
        }
        
        string val_19 = val_25.GetNextLightningEventProgress(spaced:  true);
        label_26:
        this.textProgressEnd = val_25;
        val_20 = this.textProgressStart;
    }
    private System.Collections.IEnumerator ShowPopup()
    {
        object val_1 = new System.Object();
        typeof(WGEventProgressFlyInAwayPopup.<ShowPopup>d__22).__il2cppRuntimeField_8 = 0;
        typeof(WGEventProgressFlyInAwayPopup.<ShowPopup>d__22).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator PlayFallAnimation()
    {
        object val_1 = new System.Object();
        typeof(WGEventProgressFlyInAwayPopup.<PlayFallAnimation>d__23).__il2cppRuntimeField_8 = 0;
        typeof(WGEventProgressFlyInAwayPopup.<PlayFallAnimation>d__23).__il2cppRuntimeField_10 = this;
    }
    private void Close()
    {
        this.StopAllCoroutines();
        WordRegion val_1 = WordRegion.instance;
        0.RemoveLevelCompleteBlocker(blocker:  4);
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -56569008, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGEventProgressFlyInAwayPopup()
    {
    
    }
    private float <PlayFallAnimation>b__23_0()
    {
        return (float)S0;
    }
    private void <PlayFallAnimation>b__23_1(float x)
    {
        this.progressStart = ;
    }
    private void <PlayFallAnimation>b__23_2()
    {
        if(this.progressSlider == 0)
        {
            
        }
    
    }
    private void <PlayFallAnimation>b__23_3()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -55994672, method:  new IntPtr(4238942480));
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  -55994672, method:  new IntPtr(4238943504));
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        UnityEngine.Transform val_8 = this.textProgress.transform;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.textProgress, endValue:  null, duration:  null);
        object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.textProgress, ease:  26);
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.textProgress);
    }
    private void <PlayFallAnimation>b__23_4()
    {
        UnityEngine.Transform val_1 = this.textProgress.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.textProgress, endValue:  null, duration:  null);
    }
    private void <PlayFallAnimation>b__23_5()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -370846240, clipIndex:  0);
    }

}
