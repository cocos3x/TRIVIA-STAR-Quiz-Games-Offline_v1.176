using UnityEngine;
public class TRVPlayButton : ButtonPlayGame
{
    // Fields
    private TweenCoinsText entryCostText;
    private CoinCurrencyCollectAnimationInstantiator coinAnim;
    private UnityEngine.Transform coinFlyTo;
    private int costStartLevel;
    private UnityEngine.GameObject playTextGO;
    private UnityEngine.GameObject playTextFtuxGO;
    
    // Properties
    private int entryCost { get; }
    
    // Methods
    private int get_entryCost()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return dynamicQuizEntryCost;
        }
        
        return dynamicQuizEntryCost;
    }
    protected override void Start()
    {
        int val_6;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -474423952, name:  -474472640);
        this.Start();
        mem[1152921512722357628] = 1;
        this.playTextFtuxGO.SetActive(value:  false);
        this.playTextGO.SetActive(value:  false);
        GameBehavior val_2 = App.getBehavior;
        if(0 < this.costStartLevel)
        {
                UnityEngine.GameObject val_3 = this.coinFlyTo.gameObject;
            this.coinFlyTo.SetActive(value:  false);
            this.playTextFtuxGO.SetActive(value:  true);
            return;
        }
        
        int val_4 = this.entryCost;
        decimal val_5 = System.Decimal.op_Implicit(value:  -474435992);
        this.entryCostText.Set(instantValue:  new System.Decimal() {mid = val_6});
        this.playTextGO.SetActive(value:  true);
    }
    public override void OnButtonClick()
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        GameBehavior val_1 = App.getBehavior;
        if(0 < this.costStartLevel)
        {
                0.interactable = false;
            this.OnButtonClick();
            return;
        }
        
        Player val_2 = App.Player;
        int val_3 = this.entryCost;
        decimal val_4 = System.Decimal.op_Implicit(value:  -474291236);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  null, vol:  null);
            int val_7 = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.entryCost;
            decimal val_8 = System.Decimal.op_Implicit(value:  -474291236);
            bool val_9 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  "Start Quiz", externalParams:  0, animated:  true);
            val_17 = 0;
            UnityEngine.Vector3 val_10 = position;
            int val_11 = entryCost;
            val_18 = 0;
            this.coinAnim.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  false);
            this.coinAnim.interactable = false;
            UUI_EventsController.DisableInputs();
            object val_12 = this.GetComponentInChildren<System.Object>();
            this.Stop(withChildren:  true, stopBehavior:  0);
            System.Collections.IEnumerator val_13 = this.WaitForCoinAnimation();
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  -474279184);
            return;
        }
        
        var val_17 = 24738529;
        val_17 = 10887532 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_19 = null;
        val_20 = 1152921504892043264;
        PurchaseProxy.currentPurchasePoint = 0;
        GameBehavior val_15 = App.getBehavior;
        0.Init(outOfCredits:  true, onCloseAction:  0);
    }
    private System.Collections.IEnumerator WaitForCoinAnimation()
    {
        object val_1 = new System.Object();
        typeof(TRVPlayButton.<WaitForCoinAnimation>d__10).__il2cppRuntimeField_8 = 0;
        typeof(TRVPlayButton.<WaitForCoinAnimation>d__10).__il2cppRuntimeField_10 = this;
    }
    private void OnDisable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -474046992, name:  -474472640);
    }
    private void OnStarMultiChanged()
    {
        int val_3;
        int val_1 = this.entryCost;
        decimal val_2 = System.Decimal.op_Implicit(value:  -473942936);
        this.entryCostText.CountUp(endValue:  new System.Decimal() {mid = val_3}, seconds:  null);
    }
    public TRVPlayButton()
    {
        this.costStartLevel = 3;
    }
    private void <>n__0()
    {
        this.OnButtonClick();
    }

}
