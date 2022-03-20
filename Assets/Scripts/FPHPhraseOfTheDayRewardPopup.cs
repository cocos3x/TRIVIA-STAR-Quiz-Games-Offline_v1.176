using UnityEngine;
public class FPHPhraseOfTheDayRewardPopup : MonoBehaviour
{
    // Fields
    private const string REWARD_DESCRIPTION = "Nice work\nYou answered all daily phrases!";
    private const string BONUS_QUESTION_DESCRIPTION = "Great job!\nOnto the more difficult bonus phrase for an additional reward!";
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
    
    // Properties
    public FPHQOTDPhrase reward { get; }
    
    // Methods
    public FPHQOTDPhrase get_reward()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static FPHPhraseOfTheDayController MonoSingleton<FPHPhraseOfTheDayController>::get_Instance()) != 0)
        {
                return GetReward();
        }
        
        return GetReward();
    }
    public void Start()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = "Great job!\nOnto the more difficult bonus phrase for an additional reward!";
        UnityEngine.UI.Text val_6 = this.description;
        FPHQOTDPhrase val_2 = val_6.reward;
        val_6 = val_6 + 12;
        string val_3 = val_6.ToString();
        FPHQOTDPhrase val_4 = this.rewardValue.reward;
        if(this.rewardValue == 1)
        {
                28 = 32;
        }
        
        this.rewardImg.sprite = this.gemSp;
        this.rewardGroup.SetActive(value:  true);
        this.bonusQuestionGroup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1610707280, method:  new IntPtr(2684234992));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void SwitchToBonusQuestionState()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1610541008, method:  new IntPtr(2684388976));
        this.bonusQuestionButton.m_OnClick.AddListener(call:  162246656);
        this.rewardGroup.SetActive(value:  false);
        this.bonusQuestionGroup.SetActive(value:  true);
    }
    private void OnQOTDFinished()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Complete();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1610408528, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Collect()
    {
        int val_11;
        int val_12;
        int val_13;
        int val_14;
        int val_22;
        int val_23;
        var val_24;
        GridCoinCollectAnimationInstantiator val_26;
        this.collectButton.interactable = false;
        val_22 = 1152921504901095424;
        val_23 = 1152921511577970752;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectReward();
        FPHQOTDPhrase val_2 = reward;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_24 = 1152921511586469232;
        System.Action val_6 = new System.Action(object:  -1610275024, method:  new IntPtr(2684388976));
        mem2[0] = null;
        Player val_7 = App.Player;
        val_26 = 0;
        FPHQOTDPhrase val_8 = this.reward;
        val_22 = 0;
        Player val_9 = App.Player;
        val_23 = 0;
        decimal val_10 = System.Decimal.op_Implicit(value:  -1610287076);
        this.gemAnim.Play(fromValue:  val_26 - val_22, toValue:  new System.Decimal() {flags = val_13, hi = val_14, lo = val_12, mid = val_11}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void OnClick_BonusQuestion()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartNextQOTDQuestion();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1610142544, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1610030544, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public FPHPhraseOfTheDayRewardPopup()
    {
    
    }
    private void <Start>b__16_0()
    {
        this.OnClick_Collect();
    }

}
