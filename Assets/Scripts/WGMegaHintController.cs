using UnityEngine;
public class WGMegaHintController : MonoSingleton<WGMegaHintController>
{
    // Fields
    private bool canHint;
    private UnityEngine.Sprite raySprite;
    private int numMegaHints;
    private float TimePerAnim;
    private float timePerSecondary;
    private float timeProgress;
    
    // Methods
    public void OnMegaHintPressed(bool freeHint = False)
    {
        bool val_25;
        float val_26;
        var val_27;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_29;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        val_25 = freeHint;
        if(this.canHint == false)
        {
                return;
        }
        
        decimal val_1 = CurrencyController.GetBalance();
        val_26 = 1152921504892043264;
        GameEcon val_2 = App.getGameEcon;
        var val_3 = 0 + 204;
        val_29 = 0;
        bool val_4 = System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = mem[(0 + 204) + (0)], hi = mem[(0 + 204) + (4)], lo = mem[(0 + 204) + (8)]});
        if(val_25 == false)
        {
            goto label_7;
        }
        
        if(val_25 != true)
        {
                GameEcon val_5 = App.getGameEcon;
            var val_6 = 0 + 204;
            bool val_7 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = mem[(0 + 204) + (0)], hi = mem[(0 + 204) + (4)], lo = mem[(0 + 204) + (8)], mid = mem[(0 + 204) + (12)]}, source:  "Mega Hint", externalParams:  0, animated:  false);
        }
        
        Prefs.AddToNumHint(world:  Prefs.currentWorld, subWorld:  Prefs.currentChapter, level:  Prefs.currentLevel);
        val_29 = null;
        val_29 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_31 = 4;
        goto label_12;
        label_30:
        WordRegion val_12 = WordRegion.instance;
        if(false <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        WordRegion val_13 = WordRegion.instance;
        if(false <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(item:  2621443);
        val_31 = 5;
        label_12:
        WordRegion val_14 = WordRegion.instance;
        val_27 = 0;
        val_25 = val_31 - 4;
        if(val_25 < 0)
        {
            goto label_30;
        }
        
        val_26 = val_25;
        Prefs.AddToNumHint(world:  Prefs.currentWorld, subWorld:  Prefs.currentChapter, level:  Prefs.currentLevel);
        Prefs.HasUsedHintMega = true;
        val_25 = 1152921504885600256;
        MainController val_18 = MainController.instance;
        if(0 == 0)
        {
            goto label_35;
        }
        
        val_32 = 4096;
        goto label_36;
        label_7:
        var val_27 = 27130941;
        val_27 = 8495120 + val_27;
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        val_33 = null;
        val_33 = null;
        PurchaseProxy.currentPurchasePoint = 9;
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_20 = ShowUGUIMonolith<System.Object>(showNext:  false);
        Init(outOfCredits:  true, onCloseAction:  0);
        return;
        label_35:
        val_32 = 4096;
        label_36:
        0.HintsUsedMega = 4097;
        if(val_26 != false)
        {
                MainController val_21 = MainController.instance;
            0.FreeHintsUsed = true;
        }
        else
        {
                NotificationCenter val_22 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  -287941856, aName:  -302451824);
            var val_28 = 27129942;
            val_28 = 8495596 + val_28;
            if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
            val_34 = null;
            val_34 = null;
            App.trackerManager.track(eventName:  -287965952);
            Player val_23 = App.Player;
            val_35 = 2621448;
            if(val_35 != 0)
        {
                val_36 = static_value_00280060;
        }
        else
        {
                val_35 = 88;
            val_36 = 0;
        }
        
            mem[88] = 1;
        }
        
        this.canHint = false;
        WordRegion val_24 = WordRegion.instance;
        val_27 = 0;
        mem[72] = 0;
        System.Collections.IEnumerator val_25 = this.CoolMegaHint(availableLines:  80883712, tutorial:  val_26);
        UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  -287941856);
    }
    private System.Collections.IEnumerator CoolMegaHint(System.Collections.Generic.List<LineWord> availableLines, bool tutorial = False)
    {
        typeof(WGMegaHintController.<CoolMegaHint>d__7).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGMegaHintController.<CoolMegaHint>d__7).__il2cppRuntimeField_14 = availableLines;
            typeof(WGMegaHintController.<CoolMegaHint>d__7).__il2cppRuntimeField_18 = this;
        }
        else
        {
                mem[24] = this;
            mem[20] = availableLines;
        }
        
        typeof(WGMegaHintController.<CoolMegaHint>d__7).__il2cppRuntimeField_10 = tutorial;
    }
    private System.Collections.IEnumerator CellAnimation(Cell chosenCell)
    {
        typeof(WGMegaHintController.<CellAnimation>d__8).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGMegaHintController.<CellAnimation>d__8).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGMegaHintController.<CellAnimation>d__8).__il2cppRuntimeField_14 = chosenCell;
    }
    public WGMegaHintController()
    {
        this.canHint = true;
        this.numMegaHints = 5;
        this.TimePerAnim = 0.1f;
        this.timePerSecondary = 0.1f;
    }

}
