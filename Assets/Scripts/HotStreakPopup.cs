using UnityEngine;
public class HotStreakPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject promoPopupParent;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Text promoRewardText;
    private UnityEngine.UI.Text playButtonText;
    private UnityEngine.GameObject rewardPopupParent;
    private UnityEngine.UI.Text coinText;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinAnimator;
    
    // Methods
    private void OnEnable()
    {
        this.promoPopupParent.SetActive(value:  false);
        this.rewardPopupParent.SetActive(value:  false);
        if(HotStreakEventHandler.HOT_STREAK_ID != null)
        {
                this.InitEventCollectPopup();
        }
        else
        {
                this.InitEventInfoPopup();
        }
        
        this.UpdateFeaturePoint();
    }
    private void InitEventInfoPopup()
    {
        this.promoPopupParent.SetActive(value:  true);
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1188484128);
        System.Action val_3 = new System.Action(object:  -1188484128, method:  new IntPtr(3106424352));
        this.continueButton = null;
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1188484128, method:  new IntPtr(3106433568));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1188484128, method:  new IntPtr(3106433568));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        string val_6 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_7 = App.Player;
        string val_8 = System.String.Format(format:  -1672741904, arg0:  13152256);
        UnityEngine.GameObject val_9 = this.playButton.gameObject;
        GameBehavior val_10 = App.getBehavior;
        this.playButton.SetActive(value:  true);
        UnityEngine.GameObject val_11 = this.continueButton.gameObject;
        GameBehavior val_12 = App.getBehavior;
        if(this.continueButton != 0)
        {
                -1 = 1;
        }
        
        this.continueButton.SetActive(value:  true);
        string val_13 = System.String.Format(format:  -1225078832, arg0:  13152256);
        if(this.promoRewardText != 0)
        {
                return;
        }
    
    }
    private void InitEventCollectPopup()
    {
        this.rewardPopupParent.SetActive(value:  true);
        string val_1 = HotStreakEventHandler.HOT_STREAK_ID + 76.ToString();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1188312736, method:  new IntPtr(3106624416));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        System.Action val_3 = new System.Action(object:  -1188312736, method:  new IntPtr(3106629536));
        this.coinAnimator.OnCompleteCallback = null;
    }
    private void CollectButtonClick()
    {
        UnityEngine.GameObject val_1 = this.coinAnimator.gameObject;
        this.coinAnimator.SetActive(value:  true);
        this.collectButton.interactable = false;
        Player val_2 = App.Player;
        var val_4 = 24178654;
        val_4 = 11449528 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        HotStreakEventHandler.HOT_STREAK_ID.CollectReward();
        Player val_3 = App.Player;
        this.coinAnimator.Play(fromValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, toValue:  new System.Decimal() {mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
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
            var val_3 = 24176811;
            val_3 = 11448980 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 66;
        }
        else
        {
                GameBehavior val_2 = App.getBehavior;
            if(0 != 2)
        {
                return;
        }
        
            val_4 = 1152921504895770624;
            var val_4 = 24176615;
            val_4 = 11449176 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 67;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = val_6;
    }
    private void UpdateTimerText()
    {
        int val_5;
        ulong val_13;
        var val_14;
        var val_13 = 24178346;
        val_13 = 11449836 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = mem[HotStreakEventHandler.HOT_STREAK_ID.m_stringLength + 32];
        val_13 = HotStreakEventHandler.HOT_STREAK_ID.m_stringLength + 32;
        val_14 = 0;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512008841936}, d2:  new System.DateTime() {dateData = val_13});
        double val_7 = val_5.TotalSeconds;
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
    public HotStreakPopup()
    {
    
    }

}
