using UnityEngine;
[Serializable]
public class WGEventButton_Game : MonoBehaviour
{
    // Fields
    public const string ON_WGEVENT_GAME_BUTTON_UPDATE = "OnGameEventButtonUpdate";
    private readonly UnityEngine.Vector2 icon_size;
    public UGUINetworkedButton event_button;
    public UnityEngine.UI.Image button_prefix;
    public UnityEngine.UI.Text event_text_above;
    public UnityEngine.GameObject event_text_bg;
    public UnityEngine.UI.Text event_text;
    public UnityEngine.UI.Image button_suffix;
    public UnityEngine.UI.Image event_icon;
    public UnityEngine.GameObject opposingButton;
    public UnityEngine.GameObject rewardTooltip;
    public UnityEngine.GameObject messageTooltip;
    public UnityEngine.UI.Text messageTooltipText;
    public UnityEngine.Transform event_middle_root;
    private UnityEngine.Coroutine removeMessageTooltipCoroutine;
    private UnityEngine.Coroutine timerCoroutine;
    public UnityEngine.Sprite lcMenuSprite;
    public UnityEngine.Sprite lcGameSprite;
    public UnityEngine.Sprite ecMenuSprite;
    public UnityEngine.Sprite ecGameSprite;
    public UnityEngine.Sprite wwGameSprite;
    public UnityEngine.Sprite pcMenuSprite;
    public UnityEngine.Sprite pcGameSprite;
    public UnityEngine.Sprite ccCvCGameSprite;
    public UnityEngine.Sprite apGameSprite;
    public UnityEngine.Sprite pbGameSprite;
    public UnityEngine.Sprite pb2GameSprite;
    public UnityEngine.Sprite lbdGameSprite;
    public UnityEngine.GameObject lbdRankupFlyout;
    private UnityEngine.Coroutine removeFlyoutCoroutine;
    public UnityEngine.Sprite lwGameSprite;
    public UnityEngine.Sprite wordHuntGameSprite;
    public UnityEngine.Sprite vipPartyGameSprite;
    public UnityEngine.Sprite ggGameSprite;
    public UnityEngine.Sprite superStreakGameSprite;
    public UnityEngine.Sprite superStreakInactiveSprite;
    public UnityEngine.Sprite hotStreakGameSprite;
    public UnityEngine.Sprite hotStreakInactiveSprite;
    public UnityEngine.Sprite lightningLevelsGameSprite;
    public UnityEngine.Sprite hintManiaGameSprite;
    public UnityEngine.Sprite onTheTrailGameSprite;
    public UnityEngine.Sprite keyToRichesSprite;
    public UnityEngine.Sprite superBundleSprite;
    public UnityEngine.Sprite bingoSprite;
    public UnityEngine.Sprite piggyBankRaidGameSprite;
    public UnityEngine.Sprite seasonPassSprite;
    public UnityEngine.Sprite snakesAndLaddersGameSprite;
    public UnityEngine.Sprite spinKingMenuSprite;
    public UnityEngine.Sprite islandParadiseSprite;
    public UnityEngine.Sprite letterBankGameSprite;
    public UnityEngine.Sprite forestFrenzySprite;
    public UnityEngine.Sprite prgressiveIAPSprite;
    public UnityEngine.ParticleSystem progressEffect;
    private WGEventHandler currentEventHandler;
    private bool mustShowRankupFlyout;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_9;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -294949248, name:  -1649709888);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -294949248, name:  -1649709760);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -294949248, name:  1799422256);
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -294949248, name:  -294986800);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -294949248, name:  -950707424);
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -294949248, name:  -294986688);
        this.event_button.RemoveAllListeners();
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  -294949248, method:  new IntPtr(3999993024));
        System.Delegate val_8 = System.Delegate.Combine(a:  this.event_button.OnConnectionClick, b:  7401472);
        val_9 = this.event_button.OnConnectionClick;
        if(val_9 != 0)
        {
                if(null == null)
        {
            goto label_14;
        }
        
        }
        
        val_9 = 0;
        label_14:
        this.event_button.OnConnectionClick = val_9;
    }
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.UpdateDisplayDelayed();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -294824960);
    }
    private void OnClick(bool result)
    {
        WGEventHandler val_6;
        var val_7;
        val_6 = 35628005;
        if(this.currentEventHandler == 0)
        {
            goto label_4;
        }
        
        if(this.currentEventHandler != 0)
        {
            goto label_2;
        }
        
        val_6 = this.currentEventHandler;
        if(val_6 == 0)
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 1152921504765685760;
        if(this.rewardTooltip != 0)
        {
                this.rewardTooltip.SetActive(value:  false);
        }
        
        if(this.messageTooltip == 0)
        {
                return;
        }
        
        this.messageTooltip.SetActive(value:  false);
        return;
        label_4:
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void OnGameEventControllerUpdate()
    {
        System.Collections.IEnumerator val_1 = this.UpdateDisplayDelayed();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -294543616);
    }
    private void OnGameEventHandlerProgress()
    {
        System.Collections.IEnumerator val_1 = this.UpdateDisplayDelayed();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -294431616);
    }
    private void OnLocalize()
    {
        System.Collections.IEnumerator val_1 = this.UpdateDisplayDelayed();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -294319616);
    }
    private void UpdateDisplay()
    {
        System.Collections.IEnumerator val_1 = this.UpdateDisplayDelayed();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -294207616);
    }
    private System.Collections.IEnumerator UpdateDisplayDelayed()
    {
        object val_1 = new System.Object();
        typeof(WGEventButton_Game.<UpdateDisplayDelayed>d__62).__il2cppRuntimeField_8 = 0;
        typeof(WGEventButton_Game.<UpdateDisplayDelayed>d__62).__il2cppRuntimeField_10 = this;
    }
    private void showLeaderboardFlyout()
    {
        var val_3;
        this.lbdRankupFlyout.SetActive(value:  true);
        var val_3 = 28392616;
        val_3 = 7234808 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        typeof(LeaderboardPlayerInfo_Self).__il2cppRuntimeField_1C = 0;
        System.Collections.IEnumerator val_1 = this.RemoveFlyoutOnClick(flyout:  this.lbdRankupFlyout);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -293975424);
        this.removeFlyoutCoroutine = this;
    }
    private void ShowWordHuntTooltip()
    {
        var val_2 = 28392808;
        val_2 = 7235212 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(this.currentEventHandler.myEvent != 0)
        {
                "" = this.currentEventHandler.myEvent.type;
        }
        
        if((System.String.op_Equality(a:  mem[this.currentEventHandler.myEvent.type], b:  -1298909328)) == false)
        {
                return;
        }
        
        this.ShowToolTip(message:  -293871040);
    }
    private void DoneQueuingAvailablePopups()
    {
        if(this.mustShowRankupFlyout == false)
        {
                return;
        }
        
        var val_7 = 28392324;
        val_7 = 7235696 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        if(this.currentEventHandler.myEvent != 0)
        {
                "" = this.currentEventHandler.myEvent.type;
        }
        
        if((System.String.op_Equality(a:  mem[this.currentEventHandler.myEvent.type], b:  -1266462880)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = GetWindow<System.Object>();
        System.Action val_4 = new System.Action(object:  -293715456, method:  new IntPtr(4001225792));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_C = null;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowRankupFlyout()
    {
        this.mustShowRankupFlyout = true;
    }
    private void ShowToolTip(string message)
    {
        UnityEngine.GameObject val_4 = this.messageTooltip;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = this.messageTooltipText;
        this.messageTooltip.SetActive(value:  true);
        System.Collections.IEnumerator val_2 = this.RemoveFlyoutOnClick(flyout:  this.messageTooltip);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -293462784);
        this.removeMessageTooltipCoroutine = this;
    }
    private System.Collections.IEnumerator RemoveFlyoutOnClick(UnityEngine.GameObject flyout)
    {
        typeof(WGEventButton_Game.<RemoveFlyoutOnClick>d__68).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGEventButton_Game.<RemoveFlyoutOnClick>d__68).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WGEventButton_Game.<RemoveFlyoutOnClick>d__68).__il2cppRuntimeField_10 = flyout;
    }
    private System.Collections.IEnumerator UpdateButtonTextTimer(int seconds)
    {
        typeof(WGEventButton_Game.<UpdateButtonTextTimer>d__69).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGEventButton_Game.<UpdateButtonTextTimer>d__69).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WGEventButton_Game.<UpdateButtonTextTimer>d__69).__il2cppRuntimeField_10 = seconds;
    }
    public WGEventButton_Game()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        this.icon_size = val_1.x;
        mem[1152921512903683472] = val_1.y;
    }

}
