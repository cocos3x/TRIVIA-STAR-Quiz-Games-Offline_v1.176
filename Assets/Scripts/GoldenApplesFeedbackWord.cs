using UnityEngine;
public class GoldenApplesFeedbackWord : MonoSingleton<GoldenApplesFeedbackWord>
{
    // Fields
    protected UnityEngine.CanvasGroup canvasGroup;
    protected UnityEngine.UI.Text feedbackWord;
    protected TMPro.TextMeshProUGUI feedbackWord_TMPro;
    protected UnityEngine.UI.Text plusApplesText;
    protected UnityEngine.Transform particleSpawnTransform;
    protected UnityEngine.GameObject appleFeedbackGroup;
    public float FadeInDelay;
    public float FadeInTime;
    public float FadeOutDelay;
    public float FadeOutTime;
    public DG.Tweening.Ease FadeInEase;
    public DG.Tweening.Ease FadeOutEase;
    private int applesToEarn;
    protected System.Collections.Generic.Queue<string> wordQueue;
    protected System.Collections.Generic.Queue<int> applesnumQueue;
    private UnityEngine.Transform particleDestinationTransform;
    private GoldenApplesParticles appleParticle;
    private UnityEngine.GameObject appleParticleSystemPrefab;
    
    // Properties
    private WordIQFeedbackWord iqFeedbackWord { get; }
    protected virtual bool extraWordsAllowed { get; }
    public UnityEngine.GameObject AppleParticleSystemPrefab { get; }
    
    // Methods
    private WordIQFeedbackWord get_iqFeedbackWord()
    {
        return MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    protected virtual bool get_extraWordsAllowed()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public UnityEngine.GameObject get_AppleParticleSystemPrefab()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(0 == 0)
        {
                return;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 == 0)
        {
                return;
        }
        
        ThemesHandler val_5 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.GoldCurrencyParticleSystem;
        }
        
        return 2621443.GoldCurrencyParticleSystem;
    }
    public void OnWordStreakUpdated(bool extra)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_1 = WordStreak.CurrentStreak;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        UnityEngine.Debug.LogErrorFormat(format:  -1240363216, args:  472754880);
    }
    private void Start()
    {
        UnityEngine.Transform val_12;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1240216816, name:  -2084145088);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1240216816, name:  -2067500288);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1240216816, name:  -2067500192);
        val_12 = 1152921504765685760;
        object val_4 = UnityEngine.Object.FindObjectOfType<System.Object>();
        if((-1240251056) != 0)
        {
                UnityEngine.Transform val_6 = AppleIcon;
            this.particleDestinationTransform = public static GoldenApplesStatView UnityEngine.Object::FindObjectOfType<GoldenApplesStatView>();
        }
        
        UnityEngine.GameObject val_7 = this.AppleParticleSystemPrefab;
        if((-1240216816) != 0)
        {
                UnityEngine.GameObject val_9 = this.AppleParticleSystemPrefab;
            val_12 = this.particleSpawnTransform;
            object val_10 = UnityEngine.Object.Instantiate<System.Object>(original:  -1240216816, parent:  val_12);
            object val_11 = this.GetComponent<System.Object>();
            this.appleParticle = this;
        }
        
        this.canvasGroup.alpha = null;
    }
    protected virtual void OnValidWordSubmitted(string validWord, bool isExtra)
    {
        var val_26;
        var val_27;
        int val_28;
        var val_29;
        var val_30;
        var val_31;
        string val_32;
        int val_34;
        Player val_1 = App.Player;
        val_26 = 0;
        GameEcon val_2 = App.getGameEcon;
        val_27 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) != true)
        {
                if(GoldenApplesManager.GoldenAppleFtuxShow == false)
        {
                return;
        }
        
        }
        
        if(isExtra != false)
        {
                if(this == 0)
        {
                return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2092883744) == 0)
        {
                UnityEngine.Debug.LogError(message:  -1240116528);
            return;
        }
        
        val_26 = WordStreak.CurrentStreak;
        GameBehavior val_8 = App.getBehavior;
        val_27 = 0;
        if((val_26 < 0) && (isExtra != true))
        {
                return;
        }
        
        if(WordStreak.CurrentStreak < 7)
        {
                val_28 = WordStreak.CurrentStreak;
        }
        else
        {
                int val_12 = WordStreak.CurrentStreak;
            val_12 = val_12 - 1;
            val_12 = val_12 - 4294967298;
            val_28 = val_12 + 4;
        }
        
        val_29 = null;
        val_29 = null;
        if((WordStreak.streakFeedback.ContainsKey(key:  val_28)) != false)
        {
                val_30 = null;
            val_30 = null;
            string val_14 = WordStreak.streakFeedback.Item[val_28];
            val_31 = WordStreak.streakFeedback;
        }
        else
        {
                val_31 = "";
        }
        
        if(isExtra != false)
        {
                val_32 = "EXTRA WORD";
            val_31 = "extra_word_upper";
        }
        else
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 95;
            System.String[] val_15 = Split(separator:  478563824);
            string val_16 = "".__il2cppRuntimeField_10.ToUpper();
            val_32 = "".__il2cppRuntimeField_10;
        }
        
        string val_17 = Localization.Localize(key:  1098586544, defaultValue:  val_32, useSingularKey:  false);
        this.wordQueue.Enqueue(item:  1098586544);
        if(this != 0)
        {
                int val_19 = WordStreak.CurrentStreak;
        }
        
        val_34 = UnityEngine.Mathf.Min(a:  WordStreak.CurrentStreak - 1, b:  10);
        if(GoldenMultiplierManager.IsAvaialable != true)
        {
                val_34 = (WGSubscriptionManager.GetAdditionalPoints(basePoints:  val_34)) + val_34;
        }
        
        this.applesnumQueue.Enqueue(item:  val_34);
    }
    protected void OnDragBegin()
    {
        this.canvasGroup.alpha = null;
    }
    protected void OnFadeOutBegin()
    {
        var val_6 = this;
        if(true <= 0)
        {
                WordIQFeedbackWord val_1 = this.iqFeedbackWord;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  1, y:  0);
            if(val_2 == false)
        {
                return;
        }
        
            WordIQFeedbackWord val_3 = val_2.iqFeedbackWord;
            if(val_2.WantsToShow() == false)
        {
                return;
        }
        
        }
        
        R4.Invoke(methodName:  -1239855312, time:  null);
    }
    protected void OnFadeOutComplete()
    {
        this.Invoke(methodName:  -1239739136, time:  null);
    }
    protected void FadeIn()
    {
        DG.Tweening.TweenCallback val_20;
        if((true >= 1) && (true > 0))
        {
                WordIQFeedbackWord val_1 = this.iqFeedbackWord;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  1, y:  0);
            if(val_2 != false)
        {
                WordIQFeedbackWord val_3 = val_2.iqFeedbackWord;
            val_2 + 12.SetActive(value:  false);
        }
        
            val_20 = 1;
            this.appleFeedbackGroup.SetActive(value:  true);
        }
        else
        {
                WordIQFeedbackWord val_4 = this.iqFeedbackWord;
            val_20 = 0;
            bool val_5 = UnityEngine.Object.op_Inequality(x:  1, y:  0);
            if(val_5 != false)
        {
                WordIQFeedbackWord val_6 = val_5.iqFeedbackWord;
            val_20 = 0;
            bool val_7 = val_5.WantsToShow();
            if(val_7 != false)
        {
                WordIQFeedbackWord val_8 = val_7.iqFeedbackWord;
            val_7.UpdateDisplay();
            WordIQFeedbackWord val_9 = val_7.iqFeedbackWord;
            val_20 = 0;
            val_7 + 12.SetActive(value:  true);
            this.appleFeedbackGroup.SetActive(value:  false);
        }
        
        }
        
        }
        
        UnityEngine.Transform val_10 = this.canvasGroup.transform;
        UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        this.canvasGroup.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Transform val_12 = this.canvasGroup.transform;
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.canvasGroup, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  this.FadeInTime);
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  this.FadeInTime, duration:  null);
        object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  this.FadeInEase);
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = new DG.Tweening.TweenCallback(object:  -1239569248, method:  new IntPtr(3055373024));
        object val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.canvasGroup, action:  190734336);
    }
    protected void FadeOut()
    {
        float val_1 = this.canvasGroup.alpha;
        if(this.canvasGroup == 0)
        {
                return;
        }
        
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  this.canvasGroup, duration:  null);
        object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  this.FadeOutEase);
    }
    protected virtual void UpdateText()
    {
        TMPro.TextMeshProUGUI val_6;
        string val_1 = this.wordQueue.Dequeue();
        this.applesToEarn = this.applesnumQueue.Dequeue();
        bool val_3 = UnityEngine.Object.op_Implicit(exists:  this.feedbackWord);
        val_6 = this.feedbackWord_TMPro;
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) != false)
        {
                val_6 = this.feedbackWord_TMPro;
            val_6.text = this.wordQueue;
        }
        
        string val_5 = -1467947360(-1467947360) + 13152256;
        if(this.plusApplesText != 0)
        {
                return;
        }
    
    }
    protected virtual void PlayParticles()
    {
        UnityEngine.Vector3 val_1 = position;
        this.appleParticle.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  this.applesToEarn, animateStatView:  true);
    }
    public GoldenApplesFeedbackWord()
    {
        this.FadeInEase = 6;
        this.FadeOutEase = 6;
        System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
        this.wordQueue = null;
        System.Collections.Generic.Queue<System.Int32> val_2 = new System.Collections.Generic.Queue<System.Int32>();
        this.applesnumQueue = null;
    }
    private void <FadeIn>b__30_0()
    {
        goto typeof(GoldenApplesFeedbackWord).__il2cppRuntimeField_104;
    }

}
