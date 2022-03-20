using UnityEngine;
public class WGLeaderboardCompletePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject winner_section;
    private UnityEngine.UI.HorizontalLayoutGroup rank_group;
    private UnityEngine.UI.Text winner_rank;
    private UnityEngine.UI.Text winner_rank_suffix;
    private UnityEngine.UI.Text winner_reward;
    private UnityEngine.UI.Button collect_button;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private GemsCollectAnimationInstantiator gemAnim;
    private UnityEngine.GameObject loser_section;
    private UnityEngine.UI.Text loser_rank;
    private UnityEngine.UI.Button continue_button;
    private int playerReward;
    private int playerRank;
    
    // Methods
    private void Awake()
    {
        this.rank_group.enabled = false;
        this.winner_section.SetActive(value:  false);
        this.loser_section.SetActive(value:  false);
    }
    private void OnEnable()
    {
        var val_2;
        var val_3;
        var val_2 = 28716732;
        val_2 = 6910692 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        this.playerRank = LeaderboardEventHandler.instance.playerInfo;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        int val_1 = LeaderboardEventHandler.instance.GetCurrentReward();
        this.playerReward = val_1;
        if(val_1 != 0)
        {
                this.SetupWinnerSection();
            return;
        }
        
        this.SetupLoserSection();
    }
    private void SetupWinnerSection()
    {
        var val_9;
        GemsCollectAnimationInstantiator val_10;
        var val_11;
        System.Action val_12;
        System.Action val_13;
        var val_14;
        string val_1 = this.playerRank.ToString();
        string val_2 = Ordinal.AddOrdinal(num:  this.playerRank);
        string val_3 = this.playerReward.ToString();
        var val_9 = 28715852;
        val_9 = 6911572 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if(LeaderboardEventHandler.instance.EventRewardsGems() != false)
        {
                UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -3705664, method:  new IntPtr(4291214080));
            this.collect_button.m_OnClick.AddListener(call:  162246656);
            val_10 = this.gemAnim;
            val_11 = val_10;
            val_12 = 1152921504614301696;
        }
        else
        {
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -3705664, method:  new IntPtr(4291219200));
            this.collect_button.m_OnClick.AddListener(call:  162246656);
            val_10 = this.coinAnim;
            val_11 = val_10;
            val_12 = 1152921504614301696;
            val_13 = this.coinAnim.OnCompleteCallback;
        }
        
        val_12 = new System.Action(object:  -3705664, method:  new IntPtr(4291228416));
        System.Delegate val_8 = System.Delegate.Combine(a:  val_13, b:  7454720);
        val_14 = val_13;
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_19;
        }
        
        }
        
        val_14 = 0;
        label_19:
        mem2[0] = val_14;
        this.winner_section.SetActive(value:  true);
        this.rank_group.enabled = true;
    }
    private void SetupLoserSection()
    {
        string val_1 = 13152256 + -1467947360(-1467947360);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -3535296, method:  new IntPtr(4291402880));
        this.continue_button.m_OnClick.AddListener(call:  162246656);
        this.loser_section.SetActive(value:  true);
    }
    private void PlayGemAnim()
    {
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        var val_14;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -3394512, method:  new IntPtr(4291219200));
        this.collect_button.m_OnClick.RemoveListener(call:  162246656);
        Player val_2 = App.Player;
        0.AddGems(amount:  this.playerReward, source:  -3422720, subsource:  null);
        Player val_3 = App.Player;
        string val_4 = this.playerReward.ToString();
        0.TrackNonCoinReward(source:  -3422720, subSource:  null, rewardType:  -1668821072, rewardAmount:  this.playerReward, additionalParams:  0);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopAllCoroutines();
        var val_14 = 28714812;
        val_14 = 6912612 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        LeaderboardEventHandler.instance.UpdateProgressionToServer(progress:  0, rewarded:  true);
        Player val_6 = App.Player;
        Player val_7 = App.Player;
        decimal val_8 = System.Decimal.op_Implicit(value:  -3406560);
        this.gemAnim.Play(fromValue:  0 - this.playerReward, toValue:  new System.Decimal() {flags = val_11, hi = val_12, lo = val_10, mid = val_9}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void PlayCoinAnim()
    {
        int val_4;
        int val_10;
        var val_11;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -3257936, method:  new IntPtr(4291219200));
        this.collect_button.m_OnClick.RemoveListener(call:  162246656);
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -3269988);
        0.AddCredits(amount:  new System.Decimal() {mid = val_4}, source:  "Leaderboard Reward", subSource:  0, externalParams:  0, doTrack:  true);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopAllCoroutines();
        var val_11 = 28713976;
        val_11 = 6913448 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        LeaderboardEventHandler.instance.UpdateProgressionToServer(progress:  0, rewarded:  true);
        Player val_6 = App.Player;
        var val_12 = 0;
        val_12 = val_12 + 64;
        decimal val_7 = System.Decimal.op_Implicit(value:  -3270004);
        decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -3270020, hi = 52, lo = mem[(0 + 64) + (0)], mid = mem[(0 + 64) + (4)]}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)]});
        Player val_9 = App.Player;
        this.coinAnim.Play(fromValue:  new System.Decimal() {mid = val_10}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void OnCoinAnimFinished()
    {
        this.ClosePopup();
    }
    private void ClosePopup()
    {
        var val_3;
        var val_4;
        var val_3 = 28713512;
        val_3 = 6913912 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        rewarded = true;
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -3021648, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDisable()
    {
        var val_1;
        var val_1 = 28713068;
        val_1 = 6914356 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        LeaderboardEventHandler.instance.OnMyEventPopupClosed();
    }
    public WGLeaderboardCompletePopup()
    {
    
    }

}
