using UnityEngine;
public class WFORaidMadnessPopup : RaidMadnessPopup
{
    // Fields
    protected UnityEngine.UI.Text buttonText;
    protected UnityEngine.UI.Image finalPrizeIconImage;
    
    // Methods
    protected override void Initialize()
    {
        var val_11;
        UnityEngine.UI.Image val_12;
        var val_13;
        val_11 = this;
        RaidMadnessEventHandler val_1 = val_11.Handler;
        RESEventRewardData val_2 = this.GetFinalPrize();
        val_13 = val_11;
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
        val_12 = this.finalPrizeIconImage;
        val_12.sprite = -1063859184;
        label_6:
        RaidMadnessEventHandler val_3 = val_11.Handler;
        if(this.HasCollectedAllRewards() != false)
        {
                UnityEngine.GameObject val_5 = this.gameObject;
            this.SetActive(value:  false);
            if(this.buttonText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        }
        else
        {
                Player val_6 = App.Player;
            string val_7 = System.String.Format(format:  2127161280, arg0:  13152256);
            var val_8 = FP - 24;
        }
    
    }
    protected override void OnMainButtonClicked()
    {
        var val_5;
        RaidMadnessEventHandler val_1 = this.Handler;
        if(this.HasCollectedAllRewards() != true)
        {
                val_5 = 1152921504892043264;
            GameBehavior val_3 = App.getBehavior;
            if(0 != 2)
        {
                GameBehavior val_4 = App.getBehavior;
        }
        
        }
        
        this.OnMainButtonClicked();
    }
    protected override string GetTimerText()
    {
        var val_2;
        var val_9 = 27237164;
        val_9 = 8392836 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetTimeLeft();
        int val_4 = val_2.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_5 = val_2.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_6 = val_2.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_7 = val_2.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_8 = System.String.Format(format:  -1536980304, args:  472754880);
    }
    protected override string GetAmountString(decimal amount)
    {
        GameEcon val_1 = App.getGameEcon;
        string val_2 = amount.flags.ToString(format:  null);
    }
    public WFORaidMadnessPopup()
    {
    
    }

}
