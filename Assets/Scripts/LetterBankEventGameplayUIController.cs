using UnityEngine;
public class LetterBankEventGameplayUIController : MonoSingleton<LetterBankEventGameplayUIController>
{
    // Fields
    private UnityEngine.GameObject eventButton;
    private UnityEngine.GameObject glowPrefab;
    private UnityEngine.GameObject currencyTextDisplayGroup;
    private TweenCoinsText tweenCoinsText;
    private UnityEngine.ParticleSystem glowEffect;
    
    // Properties
    private bool IsFeaturedGameEvent { get; }
    
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
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventHandler val_10 = GetGameSceneOrderedEventHandler(dailyChallengeState:  PlayingChallenge);
        string val_11 = EventType;
        return System.String.op_Equality(a:  -2101040096, b:  -1342036480);
    }
    private void Start()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1341900256, name:  -1341924384);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1341900256, name:  -1401236768);
        this.RefreshUI();
    }
    public void UpdateCurrency(int from, int to)
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        int val_10;
        UnityEngine.GameObject val_12;
        var val_13;
        int val_14;
        var val_15;
        val_12 = this.currencyTextDisplayGroup;
        val_13 = 0;
        if(this.IsFeaturedGameEvent != false)
        {
                val_14 = 11842592 + 23794703;
            if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
            val_15 = null;
            val_15 = null;
            if(LetterBankEventHandler._EligibleForEvent == true)
        {
                val_13 = 1;
        }
        
        }
        
        val_12.SetActive(value:  true);
        if(val_12.IsFeaturedGameEvent == false)
        {
                return;
        }
        
        if(from < to)
        {
                decimal val_4 = System.Decimal.op_Implicit(value:  -1341792116);
            decimal val_5 = System.Decimal.op_Implicit(value:  -1341792132);
            val_14 = val_6;
            val_12 = val_9;
            this.tweenCoinsText.Tween(startValue:  new System.Decimal() {mid = val_7}, endValue:  new System.Decimal() {flags = val_14, hi = val_8, lo = val_12, mid = val_10}, seconds:  null);
            this.StartProgressHighlightingAnim();
            return;
        }
        
        decimal val_11 = System.Decimal.op_Implicit(value:  -1341792116);
        this.tweenCoinsText.Set(instantValue:  new System.Decimal() {mid = val_7});
    }
    public void OnLetterBankEventDataUpdate()
    {
        this.RefreshUI();
    }
    public void OnGameEventButtonUpdate()
    {
        this.RefreshUI();
    }
    private void RefreshUI()
    {
        int val_7;
        var val_8;
        var val_9;
        var val_10;
        val_8 = 0;
        if(this.IsFeaturedGameEvent != false)
        {
                var val_8 = 23795319;
            val_8 = 11841976 + val_8;
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_9 = null;
            if(LetterBankEventHandler._EligibleForEvent == true)
        {
                val_8 = 1;
        }
        
        }
        
        this.currencyTextDisplayGroup.SetActive(value:  true);
        int val_2 = LetterBankEventHandler.MyScore;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1341435636);
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[this.tweenCoinsText.currentTextValue + (0)], hi = mem[this.tweenCoinsText.currentTextValue + (4)], lo = mem[this.tweenCoinsText.currentTextValue + (8)], mid = mem[this.tweenCoinsText.currentTextValue + (12)]}, d2:  new System.Decimal())) == true)
        {
                return;
        }
        
        int val_5 = LetterBankEventHandler.MyScore;
        val_10 = 0;
        decimal val_6 = System.Decimal.op_Implicit(value:  -1341435636);
        this.tweenCoinsText.Set(instantValue:  new System.Decimal() {mid = val_7});
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
    public LetterBankEventGameplayUIController()
    {
    
    }

}
