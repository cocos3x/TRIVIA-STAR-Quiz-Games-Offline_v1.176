using UnityEngine;
public class ForestFrenzyEventGameplayUIController : MonoSingleton<ForestFrenzyEventGameplayUIController>
{
    // Fields
    private UnityEngine.GameObject eventButton;
    private UnityEngine.GameObject glowPrefab;
    private UnityEngine.GameObject currencyTextDisplayPrefab;
    private UnityEngine.GameObject gameSceneTextDisplayParent;
    private UnityEngine.ParticleSystem glowEffect;
    private UnityEngine.GameObject _CurrencyTextDisplayGroup;
    private TweenCoinsText _ShovelsTweenText;
    
    // Properties
    private bool IsFeaturedGameEvent { get; }
    private UnityEngine.GameObject CurrencyTextDisplayGroup { get; }
    private TweenCoinsText ShovelsTweenText { get; }
    
    // Methods
    private bool get_IsFeaturedGameEvent()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventHandler val_6 = GetGameSceneOrderedEventHandler(dailyChallengeState:  PlayingChallenge);
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0)
        {
                return false;
        }
        
        string val_7 = EventType;
        return System.String.op_Equality(a:  -2101040096, b:  -1401622144);
    }
    private UnityEngine.GameObject get_CurrencyTextDisplayGroup()
    {
        if(this._CurrencyTextDisplayGroup != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.gameSceneTextDisplayParent.transform;
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.currencyTextDisplayPrefab, parent:  this.gameSceneTextDisplayParent);
        this._CurrencyTextDisplayGroup = this.currencyTextDisplayPrefab;
    }
    private TweenCoinsText get_ShovelsTweenText()
    {
        if(this._ShovelsTweenText != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.CurrencyTextDisplayGroup;
        object val_3 = this.GetComponentInChildren<System.Object>();
        this._ShovelsTweenText = this;
    }
    private void Start()
    {
        int val_7;
        var val_8;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1401212640, name:  -1401236896);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1401212640, name:  -1401236768);
        UnityEngine.GameObject val_3 = this.CurrencyTextDisplayGroup;
        this.SetActive(value:  this.IsFeaturedGameEvent);
        TweenCoinsText val_5 = this.ShovelsTweenText;
        var val_8 = 28431088;
        val_8 = 7196868 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        decimal val_6 = System.Decimal.op_Implicit(value:  -1401224680);
        this.Set(instantValue:  new System.Decimal() {mid = val_7});
    }
    public void UpdateCurrency(int from, int to)
    {
        int val_7;
        int val_8;
        int val_10;
        bool val_11;
        val_10 = from;
        val_11 = this.IsFeaturedGameEvent;
        UnityEngine.GameObject val_2 = this.CurrencyTextDisplayGroup;
        this.SetActive(value:  val_11);
        if(val_11 == false)
        {
                return;
        }
        
        TweenCoinsText val_3 = this.ShovelsTweenText;
        if(val_10 < to)
        {
                decimal val_5 = System.Decimal.op_Implicit(value:  -1401112692);
            decimal val_6 = System.Decimal.op_Implicit(value:  -1401112708);
            val_10 = val_8;
            this.Tween(startValue:  new System.Decimal() {mid = val_7}, endValue:  new System.Decimal() {flags = val_10}, seconds:  null);
            this.StartProgressHighlightingAnim();
            return;
        }
        
        decimal val_9 = System.Decimal.op_Implicit(value:  -1401112692);
        this.Set(instantValue:  new System.Decimal() {mid = val_7});
    }
    public void OnForestFrenzyEventDataUpdate()
    {
        this.RefreshUI();
    }
    public void OnGameEventButtonUpdate()
    {
        this.RefreshUI();
    }
    private void RefreshUI()
    {
        var val_11;
        UnityEngine.GameObject val_12;
        UnityEngine.GameObject val_13;
        TweenCoinsText val_14;
        var val_15;
        UnityEngine.ParticleSystem val_16;
        var val_17;
        bool val_1 = this.IsFeaturedGameEvent;
        UnityEngine.GameObject val_2 = this.CurrencyTextDisplayGroup;
        val_11 = this;
        this.SetActive(value:  val_1);
        if(val_1 == false)
        {
                return;
        }
        
        TweenCoinsText val_3 = this.ShovelsTweenText;
        val_11 = 1152921504923832320;
        val_12 = this.gameSceneTextDisplayParent;
        val_13 = this._CurrencyTextDisplayGroup;
        val_14 = this._ShovelsTweenText;
        var val_11 = 28429788;
        val_11 = 7198168 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = 0;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1400743924);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_12, hi = this.glowEffect, lo = val_13, mid = val_14}, d2:  new System.Decimal())) == false)
        {
                return;
        }
        
        val_13 = val_11;
        TweenCoinsText val_6 = this.ShovelsTweenText;
        if(val_14.IsTweening == true)
        {
                return;
        }
        
        TweenCoinsText val_8 = this.ShovelsTweenText;
        TweenCoinsText val_9 = this.ShovelsTweenText;
        val_12 = this.gameSceneTextDisplayParent;
        val_16 = this.glowEffect;
        val_14 = this._ShovelsTweenText;
        var val_12 = 28429460;
        val_12 = 7198496 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_17 = null;
        val_17 = null;
        val_13 = 0;
        decimal val_10 = System.Decimal.op_Implicit(value:  -1400743924);
        val_11 = 1056964608;
        val_14.Tween(startValue:  new System.Decimal() {flags = val_12, hi = val_16, lo = this._CurrencyTextDisplayGroup, mid = val_14}, endValue:  new System.Decimal(), seconds:  null);
        this.StartProgressHighlightingAnim();
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
        if(this.glowEffect == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.glowEffect.gameObject;
        if(this.glowEffect == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = this.glowEffect.gameObject;
        UnityEngine.Object.Destroy(obj:  this.glowEffect);
    }
    public ForestFrenzyEventGameplayUIController()
    {
    
    }

}
