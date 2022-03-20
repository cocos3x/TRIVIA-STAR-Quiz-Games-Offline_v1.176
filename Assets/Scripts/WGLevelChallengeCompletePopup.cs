using UnityEngine;
public class WGLevelChallengeCompletePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text coinsRewardText;
    private UnityEngine.UI.Text goldenCurrencyRewardText;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.GameObject windowGroup;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private GoldenCurrencyCollectAnimationInstantiator goldenCurrencyAnimControl;
    private decimal curr_reward;
    private int curr_goldencurr_reward;
    
    // Methods
    private void Awake()
    {
        System.Action val_1 = new System.Action(object:  -1524608, method:  new IntPtr(4293404352));
        mem2[0] = null;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1524608, method:  new IntPtr(4293413568));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        this.windowGroup.SetActive(value:  false);
    }
    private void OnEnable()
    {
        this.UpdateUI();
        if(this.windowGroup == 0)
        {
                return;
        }
        
        R4 + 24.SetActive(value:  true);
    }
    private void UpdateUI()
    {
        if(this.coinsRewardText != 0)
        {
                string val_3 = LevelChallengeHandler.Reward.ToString();
        }
        
        if(this.goldenCurrencyRewardText == 0)
        {
                return;
        }
        
        string val_6 = LevelChallengeHandler.RewardGoldenCurrency.ToString();
    }
    private void OnClick_Collect()
    {
        this.collectButton.interactable = false;
        int val_1 = LevelChallengeHandler.Reward;
        decimal val_2 = System.Decimal.op_Implicit(value:  -1136960);
        this.curr_goldencurr_reward = LevelChallengeHandler.RewardGoldenCurrency;
        Player val_4 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = this.curr_reward, hi = R7, lo = R8, mid = -1136960}, source:  "Level_Challenge", subSource:  0, externalParams:  0, doTrack:  true);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  -1124896, method:  new IntPtr(4293816352));
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  null, callback:  0);
        DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  -1124896, method:  new IntPtr(4293817376));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  null, callback:  1066192077);
    }
    private void OnGoldenCurrencyAnimFinished()
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGLevelChallengeCompletePopup()
    {
    
    }
    private void <OnClick_Collect>b__11_0()
    {
        int val_5;
        int val_5;
        Player val_1 = App.Player;
        var val_2 = 0 + 60;
        val_5 = mem[(0 + 60) + (0)];
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -792756, hi = val_5, lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = mem[this.curr_reward + (0)], lo = mem[this.curr_reward + (4)], mid = mem[this.curr_reward + (8)]});
        Player val_4 = App.Player;
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {mid = val_5}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void <OnClick_Collect>b__11_1()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -672560);
        this.goldenCurrencyAnimControl.Play(fromValue:  (5.605194E-45f) - this.curr_goldencurr_reward, toValue:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_5, mid = val_4}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  1065353216, originObject:  1056964608);
    }

}
