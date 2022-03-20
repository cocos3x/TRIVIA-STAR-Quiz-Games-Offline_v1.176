using UnityEngine;
public class WFOAttackMadnessPopup : AttackMadnessPopup
{
    // Fields
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.UI.Image finalPrizeIconImage;
    
    // Methods
    protected override void Initialize()
    {
        AttackMadnessEventHandler val_1 = this.Handler;
        RESEventRewardData val_2 = this.GetFinalPrize();
        if(R6 == 4)
        {
            goto label_8;
        }
        
        if(R6 == 3)
        {
            goto label_5;
        }
        
        if(R6 != 1)
        {
            goto label_6;
        }
        
        goto label_8;
        label_5:
        label_8:
        this.finalPrizeIconImage.sprite = -1537192592;
        label_6:
        AttackMadnessEventHandler val_3 = this.Handler;
        AttackMadnessEventHandler val_4 = this.Handler;
        if(this.HasCollectedAllRewards() != false)
        {
                this.buttonText.CrossFadeColor(targetColor:  new UnityEngine.Color() {r = 1f, g = 3.250163E-38f, b = 3.250163E-38f, a = ???}, duration:  null, ignoreTimeScale:  typeof(WFOAttackMadnessPopup).__il2cppRuntimeField_F8, useAlpha:  false);
            UnityEngine.GameObject val_6 = typeof(WFOAttackMadnessPopup).__il2cppRuntimeField_F4.gameObject;
            typeof(WFOAttackMadnessPopup).__il2cppRuntimeField_F4.SetActive(value:  false);
            return;
        }
        
        AttackMadnessEventHandler val_7 = this.Handler;
        WFOAttackMadnessPopup val_13 = this;
        AttackMadnessEventHandler val_8 = this.Handler;
        int val_9 = this.PointsCollectedInLevel;
        Player val_10 = App.Player;
        string val_11 = System.String.Format(format:  2127161280, arg0:  13152256);
        val_13 = val_13 - val_9;
        float val_14 = (float)R8;
        val_14 = (float)val_13 / val_14;
        this.buttonText.CrossFadeColor(targetColor:  new UnityEngine.Color() {r = val_14, g = 3.250163E-38f, b = 3.250163E-38f, a = ???}, duration:  val_14, ignoreTimeScale:  typeof(WFOAttackMadnessPopup).__il2cppRuntimeField_F8, useAlpha:  false);
        string val_12 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        if(val_9 != 0)
        {
                return;
        }
    
    }
    protected override void OnMainButtonClicked()
    {
        var val_5 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                AttackMadnessEventHandler val_2 = this.Handler;
            if(this.HasCollectedAllRewards() != true)
        {
                GameBehavior val_4 = App.getBehavior;
        }
        
        }
        
        this.OnMainButtonClicked();
    }
    protected override string GetTimerText()
    {
        var val_1;
        var val_8 = 22023911;
        val_8 = 13604268 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_3 = val_1.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_4 = val_1.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_5 = val_1.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_6 = val_1.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_7 = System.String.Format(format:  -1536980304, args:  472754880);
    }
    protected override string GetAmountString(decimal amount)
    {
        GameEcon val_1 = App.getGameEcon;
        string val_2 = amount.flags.ToString(format:  null);
    }
    public WFOAttackMadnessPopup()
    {
    
    }

}
