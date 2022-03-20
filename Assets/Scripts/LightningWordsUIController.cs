using UnityEngine;
public class LightningWordsUIController : MonoSingleton<LightningWordsUIController>
{
    // Fields
    private UnityEngine.Transform mainLayout;
    private UnityEngine.Rect wordRegion;
    private UnityEngine.GameObject eventButton;
    private UnityEngine.Transform eventButtonParent;
    private UnityEngine.GameObject wordLightningEffectPrefab;
    private UnityEngine.GameObject lightningCountdownButtonPrefab;
    private UnityEngine.GameObject glowPrefab;
    private UnityEngine.Transform word;
    private System.Collections.Generic.List<UnityEngine.Transform> wordEffects;
    private LightningCountdownButton countdownButton;
    private FrameSkipper frameSkipper;
    private int countdownTimer;
    private bool pausedCountdownTimer;
    private bool isAppPaused;
    private WGLightningProgressPopup lightningStrikeFlyout;
    private bool closedPreviousFlyout;
    private UnityEngine.ParticleSystem glowEffect;
    
    // Properties
    public System.Collections.Generic.List<UnityEngine.Transform> GetWordEffectsTransform { get; }
    
    // Methods
    public System.Collections.Generic.List<UnityEngine.Transform> get_GetWordEffectsTransform()
    {
    
    }
    public void ApplyLightningEffects(int wordIndex)
    {
        FrameSkipper val_16;
        UnityEngine.Transform val_17;
        var val_18;
        val_16 = 35632186;
        this.DestroyLightningEffects();
        if(wordIndex == 1)
        {
                return;
        }
        
        if(this.eventButton != 0)
        {
                this.eventButton.SetActive(value:  false);
        }
        
        WordRegion val_2 = WordRegion.instance;
        if(0 <= wordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_16 = 0;
        val_16 = val_16 + (wordIndex << 2);
        UnityEngine.Transform val_3 = (0 + (wordIndex) << 2) + 16.transform;
        val_17 = (0 + (wordIndex) << 2) + 16;
        this.word = (0 + (wordIndex) << 2) + 16;
        val_18 = 0;
        goto label_12;
        label_23:
        UnityEngine.Transform val_4 = this.word.GetChild(index:  0);
        object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.wordLightningEffectPrefab, parent:  this.word);
        UnityEngine.Transform val_6 = this.wordLightningEffectPrefab.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        if(this.wordLightningEffectPrefab != 0)
        {
                this.wordLightningEffectPrefab.localScale = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        }
        else
        {
                0.localScale = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        }
        
        this.wordLightningEffectPrefab.localPosition = new UnityEngine.Vector3();
        this.wordEffects.Add(item:  this.wordLightningEffectPrefab);
        val_17 = this.word;
        val_18 = 1;
        label_12:
        if(val_18 < val_17.childCount)
        {
            goto label_23;
        }
        
        object val_11 = UnityEngine.Object.Instantiate<System.Object>(original:  this.lightningCountdownButtonPrefab, parent:  this.eventButtonParent);
        object val_12 = this.lightningCountdownButtonPrefab.GetComponent<System.Object>();
        this.countdownButton = this.lightningCountdownButtonPrefab;
        UnityEngine.GameObject val_13 = this.gameObject;
        UnityEngine.UI.LayoutElement val_14 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -241344704);
        this.frameSkipper = this;
        mem[1152921512955436888] = 0;
        val_16 = this.frameSkipper;
        System.Action val_15 = new System.Action(object:  -241344704, method:  new IntPtr(4053597568));
        this.frameSkipper.updateLogic = null;
    }
    public void ShowFTUX()
    {
        UnityEngine.Transform val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.Transform val_3 = this.word.GetChild(index:  0);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) == 0)
        {
                val_4 = mem[this.mainLayout + (0)];
        }
        
        ShowFTUX(word:  this.word, firstLetter:  this.word, mainLayout:  val_4, wordRegion:  new UnityEngine.Rect() {m_XMin = mem[this.mainLayout + (4)], m_YMin = mem[this.mainLayout + (8)], m_Width = ???, m_Height = this});
    }
    public void ShowLightningStrikeFlyout()
    {
        if((this.lightningStrikeFlyout != 0) && (this.closedPreviousFlyout != true))
        {
                this.lightningStrikeFlyout.ClosePopup();
            this.closedPreviousFlyout = true;
        }
        
        GameBehavior val_2 = App.getBehavior;
        this.lightningStrikeFlyout = 0;
        0.Setup(e:  0);
    }
    public void PlayLightningSFX()
    {
        null = null;
        MonoSingleton<T>.searchedFailed + 12.PlayGameSpecificSound(id:  -1173946304, randomIndex:  false, vol:  null);
    }
    public void UpdateEventButton()
    {
        if(this.eventButton != 0)
        {
                this.eventButton.SetActive(value:  true);
        }
        
        this.StartProgressHighlightingAnim();
    }
    private void DestroyLightningEffects()
    {
        var val_11;
        LightningCountdownButton val_12;
        if(true < 1)
        {
            goto label_2;
        }
        
        val_11 = 4;
        goto label_3;
        label_16:
        if(true <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_1 = 2621443.gameObject;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  2621443, y:  0);
        if(val_2 != false)
        {
                if(val_2 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_3 = 2621443.gameObject;
            UnityEngine.Object.Destroy(obj:  2621443);
        }
        
        val_11 = 5;
        label_3:
        val_12 = val_11 - 4;
        if(val_12 < 2621443)
        {
            goto label_16;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.wordEffects = null;
        label_2:
        if(this.countdownButton != 0)
        {
                UnityEngine.GameObject val_6 = this.countdownButton.gameObject;
            if(this.countdownButton != 0)
        {
                val_12 = 0;
            UnityEngine.GameObject val_8 = this.countdownButton.gameObject;
            UnityEngine.Object.Destroy(obj:  this.countdownButton);
            this.countdownButton = val_12;
        }
        
        }
        
        if(this.lightningStrikeFlyout != 0)
        {
                if(this.closedPreviousFlyout != true)
        {
                val_12 = 0;
            this.lightningStrikeFlyout.ClosePopup();
            this.lightningStrikeFlyout = val_12;
        }
        
            this.closedPreviousFlyout = false;
        }
        
        if(this.frameSkipper == 0)
        {
                return;
        }
        
        this.frameSkipper.updateLogic = 0;
    }
    private bool HasValidQueuedWindows()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if(HasQueuedWindows() == false)
        {
                return (bool)val_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = GetWindow<System.Object>();
        val_6 = isActiveAndEnabled ^ 1;
        return (bool)val_6;
    }
    private void UpdateEffects()
    {
        var val_11 = 26235481;
        val_11 = 9392700 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE == 0)
        {
            goto label_2;
        }
        
        if(this.isAppPaused != true)
        {
                this.HandleTimerPause(paused:  this.isAppPaused.HasValidQueuedWindows());
            if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        if((LightningWordsHandler.DEFAULT_REWARD_VALUE + 20 + 44) == 0)
        {
            goto label_7;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.countdownButton)) == false)
        {
                return;
        }
        
        string val_3 = this.countdownTimer.ToString(format:  -1827641632);
        string val_4 = 1269544640 + this.countdownTimer;
        label_36:
        this.countdownButton.SetupCountdownText(text:  1269544640, size:  0);
        return;
        label_2:
        this.DestroyLightningEffects();
        return;
        label_7:
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE.GetLightningCountDown() < 0)
        {
            goto label_20;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if((LightningWordsHandler.DEFAULT_REWARD_VALUE + 16 + 23) != 0)
        {
            goto label_20;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE.InExpireInterval() == false)
        {
            goto label_23;
        }
        
        label_20:
        this.DestroyLightningEffects();
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        LightningWordsHandler.DEFAULT_REWARD_VALUE.ResetLightningWordJustFoundStatus();
        this.eventButton.SetActive(value:  true);
        if(val_11 != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        return;
        label_23:
        this.eventButton.SetActive(value:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.countdownButton)) == false)
        {
                return;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_9 = LightningWordsHandler.DEFAULT_REWARD_VALUE.GetLightningCountDown().ToString(format:  -1827641632);
        string val_10 = 1269544640 + -240379196(-240379196);
        if(this.countdownButton != 0)
        {
            goto label_36;
        }
        
        goto label_36;
    }
    private void HandleTimerPause(bool paused)
    {
        var val_4;
        var val_5;
        val_4 = 35628181;
        val_5 = 1152921504927453184;
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE == 0)
        {
                return;
        }
        
        if(paused != false)
        {
                if(LightningWordsHandler.DEFAULT_REWARD_VALUE.GetLightningCountDown() < 1)
        {
                return;
        }
        
            LightningWordsHandler.DEFAULT_REWARD_VALUE.PauseLightningCountDownTimer();
            if(this.pausedCountdownTimer == true)
        {
                return;
        }
        
            mem2[0] = 1;
            if(R6 == 0)
        {
                mem2[0] = 1;
        }
        
            mem2[0] = R7 + 92.GetLightningCountDown();
            return;
        }
        
        this.pausedCountdownTimer = false;
        LightningWordsHandler.DEFAULT_REWARD_VALUE.ResumeLightningCountDownTimer();
    }
    private void StartProgressHighlightingAnim()
    {
        UnityEngine.Transform val_1 = this.eventButton.transform;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.glowPrefab, parent:  this.eventButton);
        object val_3 = this.glowPrefab.GetComponent<System.Object>();
        this.glowEffect = this.glowPrefab;
        UnityEngine.Transform val_4 = this.glowPrefab.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.glowPrefab.localPosition = new UnityEngine.Vector3();
        this.glowEffect.Play();
        MainModule val_6 = this.glowEffect.main;
        this.Invoke(methodName:  -1400594720, time:  val_6.m_ParticleSystem.duration);
    }
    private void OnProgressHighlightingAnimFinished()
    {
        if(this.glowEffect != 0)
        {
                UnityEngine.GameObject val_2 = this.glowEffect.gameObject;
            if(this.glowEffect != 0)
        {
                UnityEngine.GameObject val_4 = this.glowEffect.gameObject;
            UnityEngine.Object.Destroy(obj:  this.glowEffect);
        }
        
        }
        
        var val_5 = 26233753;
        val_5 = 9394428 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE == 0)
        {
            
        }
    
    }
    private void Start()
    {
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        1152921504886931456;
        UnityEngine.Rect val_4 = getSafeAreaRect;
    }
    private void OnApplicationPause(bool pause)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        this.HandleTimerPause(paused:  pause);
        this.isAppPaused = pause;
    }
    private void OnApplicationFocus(bool focus)
    {
        bool val_3 = focus;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        val_3 = val_3 ^ 1;
        this.HandleTimerPause(paused:  val_3);
        this.isAppPaused = val_3;
    }
    private void OnDestroy()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != false)
        {
                return;
        }
        
        }
        
        this.HandleTimerPause(paused:  true);
    }
    public LightningWordsUIController()
    {
        UnityEngine.Rect val_1 = UnityEngine.Rect.zero;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.wordEffects = null;
    }

}
