using UnityEngine;
public class SuperStreakPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject infoPopupParent;
    private UnityEngine.UI.Text descriptionText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.GameObject coinInfoBox;
    private UnityEngine.GameObject wheelInfoBox;
    private UnityEngine.GameObject spinInfoBox;
    private UnityEngine.UI.Text coinInfoText;
    private UnityEngine.GameObject timerParent;
    private UnityEngine.GameObject collectPopupParent;
    private UnityEngine.GameObject coinRewardBox;
    private UnityEngine.GameObject wheelRewardBox;
    private UnityEngine.GameObject spinRewardBox;
    private UnityEngine.UI.Text rewardText;
    private UnityEngine.UI.Text coinText;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private UnityEngine.UI.Text playButtonText;
    
    // Methods
    private void OnEnable()
    {
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE != null)
        {
                this.infoPopupParent.SetActive(value:  false);
            this.ShowCanCollectPopup();
        }
        else
        {
                this.collectPopupParent.SetActive(value:  false);
            this.ShowInfoPopup();
        }
        
        this.UpdateFeaturePoint();
    }
    private void UpdateFeaturePoint()
    {
        var val_4;
        var val_5;
        FeatureAccessPoints val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                val_4 = 1152921504895770624;
            var val_3 = 29353567;
            val_3 = 6272224 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 64;
        }
        else
        {
                GameBehavior val_2 = App.getBehavior;
            if(0 != 2)
        {
                return;
        }
        
            val_4 = 1152921504895770624;
            var val_4 = 29353371;
            val_4 = 6272420 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 65;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = val_6;
    }
    private void ShowInfoPopup()
    {
        float val_27;
        UnityEngine.GameObject val_28;
        this.coinInfoBox.SetActive(value:  false);
        this.spinInfoBox.SetActive(value:  false);
        this.wheelInfoBox.SetActive(value:  false);
        this.timerParent.SetActive(value:  true);
        UnityEngine.GameObject val_1 = this.infoPopupParent.gameObject;
        this.infoPopupParent.SetActive(value:  true);
        val_27 = 1152921504941137920;
        GameEventRewardType val_2 = SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.GetRewardType();
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE == 4)
        {
            goto label_9;
        }
        
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE == 3)
        {
            goto label_10;
        }
        
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE != 1)
        {
            goto label_21;
        }
        
        string val_3 = Localization.Localize(key:  -988214096, defaultValue:  -988214448, useSingularKey:  false);
        val_27 = SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE;
        string val_4 = System.String.Format(format:  -988214096, arg0:  13152256, arg1:  13152256);
        this.coinInfoBox.SetActive(value:  true);
        string val_6 = SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.GetCoinRewardForTier().ToString();
        if(this.coinInfoText != 0)
        {
            goto label_21;
        }
        
        goto label_21;
        label_9:
        string val_7 = Localization.Localize(key:  -988201248, defaultValue:  -988201696, useSingularKey:  false);
        val_27 = "ssw_event_popup_bonus_spin";
        string val_8 = System.String.Format(format:  -988201248, arg0:  13152256, arg1:  13152256);
        val_28 = this.spinInfoBox;
        goto label_27;
        label_10:
        string val_9 = Localization.Localize(key:  -988192464, defaultValue:  -988192928, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        GameEcon val_10 = App.getGameEcon;
        int val_11 = 0.maxBonusGameWheelAwardCoins;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        GameEcon val_12 = App.getGameEcon;
        int val_13 = 0.maxBonusGameWheelAwardGoldenCurrency;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_14 = System.String.Format(format:  -988192464, args:  472754880);
        val_28 = this.wheelInfoBox;
        label_27:
        val_28.SetActive(value:  true);
        label_21:
        UnityEngine.GameObject val_15 = this.gameObject;
        UnityEngine.UI.LayoutElement val_16 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -988129424);
        System.Action val_17 = new System.Action(object:  -988129424, method:  new IntPtr(3306783152));
        this.playButton = null;
        UnityEngine.Events.UnityAction val_18 = new UnityEngine.Events.UnityAction(object:  -988129424, method:  new IntPtr(3306792368));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_19 = new UnityEngine.Events.UnityAction(object:  -988129424, method:  new IntPtr(3306792368));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        string val_20 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_21 = App.Player;
        string val_22 = System.String.Format(format:  -1672741904, arg0:  13152256);
        UnityEngine.GameObject val_23 = this.playButton.gameObject;
        GameBehavior val_24 = App.getBehavior;
        this.playButton.SetActive(value:  true);
        UnityEngine.GameObject val_25 = this.continueButton.gameObject;
        GameBehavior val_26 = App.getBehavior;
        if(this.continueButton != 0)
        {
                -1 = 1;
        }
        
        this.continueButton.SetActive(value:  true);
    }
    private void ShowCanCollectPopup()
    {
        UnityEngine.GameObject val_7;
        UnityEngine.GameObject val_1 = this.collectPopupParent.gameObject;
        this.collectPopupParent.SetActive(value:  true);
        this.timerParent.SetActive(value:  false);
        this.coinRewardBox.SetActive(value:  false);
        this.wheelRewardBox.SetActive(value:  false);
        this.spinRewardBox.SetActive(value:  false);
        GameEventRewardType val_2 = SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.GetRewardType();
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE == 4)
        {
            goto label_9;
        }
        
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE == 3)
        {
            goto label_10;
        }
        
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE != 1)
        {
            goto label_16;
        }
        
        this.coinRewardBox.SetActive(value:  true);
        string val_4 = SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.GetCoinRewardForTier().ToString();
        if(this.coinText != 0)
        {
            goto label_16;
        }
        
        goto label_16;
        label_9:
        val_7 = this.spinRewardBox;
        goto label_17;
        label_10:
        val_7 = this.wheelRewardBox;
        label_17:
        val_7.SetActive(value:  true);
        label_16:
        string val_5 = Localization.Localize(key:  -991256336, defaultValue:  -987926736, useSingularKey:  false);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -987889296, method:  new IntPtr(3307052976));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void UpdateTimerText()
    {
        int val_5;
        ulong val_13;
        var val_14;
        var val_13 = 29353445;
        val_13 = 6272620 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = mem[SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.m_stringLength + 32];
        val_13 = SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.m_stringLength + 32;
        val_14 = 0;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512209045472}, d2:  new System.DateTime() {dateData = val_13});
        double val_7 = val_5.TotalSeconds;
        this.Close();
    }
    private void OnClickCollect()
    {
        var val_7 = 29352457;
        val_7 = 6273608 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        GameEventRewardType val_1 = SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.GetRewardType();
        if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE == 1)
        {
                if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            if(SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.GetCoinRewardForTier() >= 1)
        {
                this.collectButton.interactable = false;
            Player val_3 = App.Player;
            if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.CollectReward();
            UnityEngine.GameObject val_4 = this.coinAnim.gameObject;
            this.coinAnim.SetActive(value:  true);
            System.Action val_5 = new System.Action(object:  -987590544, method:  new IntPtr(3307347632));
            this.coinAnim.OnCompleteCallback = null;
            Player val_6 = App.Player;
            this.coinAnim.Play(fromValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, toValue:  new System.Decimal() {mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
            return;
        }
        
        }
        
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE.CollectReward();
        this.Close();
    }
    private void OnPlayButtonPressed()
    {
        var val_3;
        this.UpdateFeaturePoint();
        val_3 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        this.Close();
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public SuperStreakPopup()
    {
    
    }

}
