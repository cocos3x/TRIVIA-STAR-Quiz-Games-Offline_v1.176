using UnityEngine;
public class FPHPlayButton : ButtonPlayGame
{
    // Fields
    private UnityEngine.UI.Text entryCostText;
    private CoinCurrencyCollectAnimationInstantiator coinAnim;
    private UnityEngine.Transform coinFlyTo;
    private bool showInterstitialAd;
    
    // Properties
    private int entryCost { get; }
    
    // Methods
    private int get_entryCost()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>()) != 0)
        {
                return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_118;
        }
        
        return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_118;
    }
    protected override void Start()
    {
        var val_11;
        this.Start();
        mem[1152921511575077788] = 1;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(CanResumeGame() != false)
        {
                UnityEngine.GameObject val_4 = this.coinFlyTo.gameObject;
            this.coinFlyTo.SetActive(value:  false);
            val_11 = "CONTINUE";
            return;
        }
        
        }
        
        UnityEngine.GameObject val_5 = this.coinFlyTo.gameObject;
        this.coinFlyTo.SetActive(value:  true);
        string val_7 = this.coinFlyTo.entryCost.ToString();
        if(this.entryCostText == 0)
        {
                return;
        }
        
        val_11 = "PLAY";
    }
    public override void OnButtonClick()
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(CanResumeGame() != false)
        {
                val_22 = null;
            val_22 = null;
            FPHGameplayController.currentGameplayMode = 0;
            this.OnButtonClick();
            return;
        }
        
        }
        
        Player val_4 = App.Player;
        int val_5 = this.entryCost;
        decimal val_6 = System.Decimal.op_Implicit(value:  -1621582340);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
        {
                if(this.showInterstitialAd != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_9 = ShowInterstitial(context:  2);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  null, vol:  null);
            int val_11 = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.entryCost;
            decimal val_12 = System.Decimal.op_Implicit(value:  -1621582340);
            bool val_13 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  "Level Start", externalParams:  0, animated:  true);
            val_25 = null;
            val_25 = null;
            FPHGameplayController.currentGameplayMode = 0;
            val_23 = 0;
            UnityEngine.Vector3 val_14 = position;
            int val_15 = entryCost;
            val_24 = 0;
            this.coinAnim.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  false);
            this.coinAnim.interactable = false;
            UUI_EventsController.DisableInputs();
            object val_16 = this.GetComponentInChildren<System.Object>();
            if((-1621570288) != 0)
        {
                this.Stop(withChildren:  true, stopBehavior:  0);
        }
        
            System.Collections.IEnumerator val_18 = this.WaitForCoinAnimation();
            UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  -1621570288);
            return;
        }
        
        var val_22 = 28492533;
        val_22 = 7133528 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = null;
        val_27 = 1152921504892043264;
        PurchaseProxy.currentPurchasePoint = 123;
        GameBehavior val_20 = App.getBehavior;
        0.Init(outOfCredits:  true, onCloseAction:  0);
    }
    private System.Collections.IEnumerator WaitForCoinAnimation()
    {
        object val_1 = new System.Object();
        typeof(FPHPlayButton.<WaitForCoinAnimation>d__8).__il2cppRuntimeField_8 = 0;
        typeof(FPHPlayButton.<WaitForCoinAnimation>d__8).__il2cppRuntimeField_10 = this;
    }
    public FPHPlayButton()
    {
    
    }
    private void <>n__0()
    {
        this.OnButtonClick();
    }

}
