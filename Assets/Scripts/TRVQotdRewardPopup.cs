using UnityEngine;
public class TRVQotdRewardPopup : MonoBehaviour
{
    // Fields
    private const string REWARD_DESCRIPTION = "Great job!\nHere’s your prize!";
    private const string BONUS_QUESTION_DESCRIPTION = "Answer a Bonus Question\nfor another reward!";
    private UnityEngine.UI.Text description;
    private UnityEngine.GameObject rewardGroup;
    private UnityEngine.UI.Text rewardValue;
    private UnityEngine.UI.Image rewardImg;
    private UnityEngine.Sprite coinSp;
    private UnityEngine.Sprite gemSp;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.GameObject bonusQuestionGroup;
    private UnityEngine.UI.Button bonusQuestionButton;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private GemsCollectAnimationInstantiator gemAnim;
    private bool isBonus;
    
    // Methods
    public void Init(TRVReward reward, bool isBonus)
    {
        if(new System.Object() != 0)
        {
                typeof(TRVQotdRewardPopup.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVQotdRewardPopup.<>c__DisplayClass14_0).__il2cppRuntimeField_C = reward;
        this.isBonus = isBonus;
        string val_3 = (reward + 12).ToString();
        if((reward + 8) == 1)
        {
                28 = 32;
        }
        
        this.rewardImg.sprite = this.gemSp;
        this.rewardGroup.SetActive(value:  true);
        this.bonusQuestionGroup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  362565632, method:  new IntPtr(3836359328));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void SwitchToBonusQuestionState()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -458412576, method:  new IntPtr(3836517408));
        this.bonusQuestionButton.m_OnClick.AddListener(call:  162246656);
        this.rewardGroup.SetActive(value:  false);
        this.bonusQuestionGroup.SetActive(value:  true);
    }
    private void OnQOTDFinished()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Complete();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -458280096, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Collect(TRVReward reward)
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        int val_17;
        UnityEngine.UI.Button val_17;
        var val_18;
        var val_19;
        int val_20;
        int val_21;
        val_17 = this.collectButton;
        val_17.interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectReward(reward:  reward);
        if(reward.rewardType == 0)
        {
            goto label_6;
        }
        
        if(reward.rewardType != 1)
        {
                return;
        }
        
        if(this.isBonus == false)
        {
            goto label_8;
        }
        
        val_18 = 1152921512738605856;
        goto label_9;
        label_6:
        if(this.isBonus == false)
        {
            goto label_10;
        }
        
        val_19 = 1152921512738605856;
        goto label_11;
        label_8:
        val_18 = 1152921512738610976;
        label_9:
        System.Action val_2 = new System.Action(object:  -458137376, method:  new IntPtr(3836796704));
        mem2[0] = null;
        Player val_3 = App.Player;
        val_20 = reward.rewardAmount;
        val_17 = 0;
        Player val_4 = App.Player;
        val_21 = 0;
        decimal val_5 = System.Decimal.op_Implicit(value:  -458149428);
        this.gemAnim.Play(fromValue:  val_17 - val_20, toValue:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_7, mid = val_6}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        return;
        label_10:
        val_19 = 1152921512738610976;
        label_11:
        System.Action val_11 = new System.Action(object:  -458137376, method:  new IntPtr(3836796704));
        this.coinAnim.OnCompleteCallback = null;
        val_20 = this.coinAnim;
        Player val_12 = App.Player;
        var val_13 = 0 + 60;
        decimal val_14 = System.Decimal.op_Implicit(value:  -458149428);
        decimal val_15 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -458149444, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256});
        Player val_16 = App.Player;
        val_20.Play(fromValue:  new System.Decimal() {mid = val_17}, toValue:  new System.Decimal() {hi = val_17, lo = val_21}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void OnClick_BonusQuestion()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartNextQOTDQuestion();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -457996704, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -457884704, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVQotdRewardPopup()
    {
    
    }

}
